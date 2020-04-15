using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeModify
{
    public partial class Form1 : Form
    {
        private const string descSuffix = "输入修改的后缀，多个之间使用(,)隔开";
        private const string descFolder = "可将文件夹拖动到输入框";

        private List<string> suffixList=new List<string>(); 

        private List<FileInfo> fileInfoList=new List<FileInfo>(); 

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TextBoxLostFocus(tbsuffix, descSuffix);
            TextBoxLostFocus(tbFolder, descFolder);
            cbEncode.SelectedIndex = 0;
        }
        /// <summary>
        /// 后缀输入框获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txsuffix_Enter(object sender, EventArgs e)
        {
            if (tbsuffix.Text == descSuffix)
            {
                TextBoxGetFocus(tbsuffix, "");
            }
        }
        /// <summary>
        /// 后缀输入框失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txsuffix_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbsuffix.Text))
            {
                TextBoxLostFocus(tbsuffix, descSuffix);
            }
        }

        private void TextBoxGetFocus(TextBox tb,string desc)
        {
            tb.ForeColor = ColorTranslator.FromHtml("#333333");
            tb.Text = desc;
        }
        private void TextBoxLostFocus(TextBox tb, string desc)
        {
            tb.ForeColor = ColorTranslator.FromHtml("#999999");
            tb.Text = desc;
        }

        private void btnSelevtFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFolder.Text))
            {
                MessageBox.Show("请选择目录！");
                return;
            }
            if (tbsuffix.Text==descSuffix)
            {
                MessageBox.Show("请输入需要修改的文件的后缀！");
                return;
            }
            suffixList.Clear();
            fileInfoList.Clear();
            rtbFileList.Text = "";
            labFileNum.Text = "文件个数：0";
            string strSuffix = tbsuffix.Text;
            string[] suffixs = strSuffix.Split(',');
            if (suffixs.Length>0)
            {
                for (int i = 0; i < suffixs.Length; i++)
                {
                    suffixList.Add(suffixs[i]);
                }
            }
            DirectoryInfo di = new DirectoryInfo(tbFolder.Text);
            if (!di.Exists)
            {
                MessageBox.Show(tbFolder.Text + "不是一个有效的路径！");
            }
            else
            {
                LoadFile(di);
            }
            if (fileInfoList.Count>0)
            {
                for (int i = 0; i < fileInfoList.Count; i++)
                {
                    rtbFileList.AppendText(fileInfoList[i].Name);
                    rtbFileList.AppendText("\r\n");
                }
            }
            labFileNum.Text = "文件个数："+fileInfoList.Count;
        }

        private void LoadFile(DirectoryInfo di)
        {
            DirectoryInfo[] dis = di.GetDirectories();
            FileInfo[] fis = di.GetFiles();
            if (fis.Length>0)
            {
                for (int i = 0; i < fis.Length; i++)
                {
                    string suff = fis[i].Extension;
                    if (suff.Length > 0)//过滤掉没有后缀的
                    {
                        suff = suff.Remove(0, 1); //移除"."
                        if (suffixList.Contains(suff))
                        {
                            fileInfoList.Add(fis[i]);
                        }
                    }
                }
            }
            if (cbChildFolder.Checked)
            {
                if (dis.Length>0)
                {
                    for (int i = 0; i < dis.Length; i++)
                    {
                        DirectoryInfo di0 = new DirectoryInfo(dis[i].FullName);
                        LoadFile(di0);
                    }
                }
            }
        }

        private void btnChangeEncode_Click(object sender, EventArgs e)
        {
            if (fileInfoList.Count==0)
            {
                MessageBox.Show("请先选择文件！");
                return;
            }
            string strcode = cbEncode.SelectedItem.ToString();
            Encoding encode=Encoding.UTF8;
            switch (strcode)
            {
                case "UTF-8":
                    encode=Encoding.UTF8;
                    break;
                case "Unicode":
                    encode = Encoding.Unicode;
                    break;
                case "ASCII":
                    encode = Encoding.ASCII;
                    break;
                case "BigEndianUnicode":
                    encode = Encoding.BigEndianUnicode;
                    break;
                case "UTF32":
                    encode = Encoding.UTF32;
                    break;
                case "UTF7":
                    encode = Encoding.UTF7;
                    break;
                case "Default":
                    encode = Encoding.Default;
                    break;
            }
            for (int i = 0; i < fileInfoList.Count; i++)
            {
                File.WriteAllText(fileInfoList[i].FullName, File.ReadAllText(fileInfoList[i].FullName, Encoding.Default), encode);
            }
            MessageBox.Show("文件修改完成！");
        }

        private void tbFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.tbFolder.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void tbFolder_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            tbFolder.Text = path;
            this.tbFolder.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状
        }

        private void tbFolder_Enter(object sender, EventArgs e)
        {
            if (tbFolder.Text == descFolder)
            {
                TextBoxGetFocus(tbFolder, "");
            }
        }

        private void tbFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFolder.Text))
            {
                TextBoxLostFocus(tbFolder, descFolder);
            }
        }
    }
}
