namespace CodeModify
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnSelevtFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsuffix = new System.Windows.Forms.TextBox();
            this.cbChildFolder = new System.Windows.Forms.CheckBox();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEncode = new System.Windows.Forms.ComboBox();
            this.btnChangeEncode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbFileList = new System.Windows.Forms.RichTextBox();
            this.labFileNum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "更改编码的文件目录：";
            // 
            // tbFolder
            // 
            this.tbFolder.AllowDrop = true;
            this.tbFolder.Location = new System.Drawing.Point(181, 19);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(338, 21);
            this.tbFolder.TabIndex = 1;
            this.tbFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragDrop);
            this.tbFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragEnter);
            this.tbFolder.Enter += new System.EventHandler(this.tbFolder_Enter);
            this.tbFolder.Leave += new System.EventHandler(this.tbFolder_Leave);
            // 
            // btnSelevtFolder
            // 
            this.btnSelevtFolder.Location = new System.Drawing.Point(542, 17);
            this.btnSelevtFolder.Name = "btnSelevtFolder";
            this.btnSelevtFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelevtFolder.TabIndex = 2;
            this.btnSelevtFolder.Text = "选择目录";
            this.btnSelevtFolder.UseVisualStyleBackColor = true;
            this.btnSelevtFolder.Click += new System.EventHandler(this.btnSelevtFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "需要更改的文件的后缀名：";
            // 
            // tbsuffix
            // 
            this.tbsuffix.Location = new System.Drawing.Point(181, 56);
            this.tbsuffix.Name = "tbsuffix";
            this.tbsuffix.Size = new System.Drawing.Size(210, 21);
            this.tbsuffix.TabIndex = 4;
            this.tbsuffix.Enter += new System.EventHandler(this.txsuffix_Enter);
            this.tbsuffix.Leave += new System.EventHandler(this.txsuffix_Leave);
            // 
            // cbChildFolder
            // 
            this.cbChildFolder.AutoSize = true;
            this.cbChildFolder.Checked = true;
            this.cbChildFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChildFolder.Location = new System.Drawing.Point(435, 56);
            this.cbChildFolder.Name = "cbChildFolder";
            this.cbChildFolder.Size = new System.Drawing.Size(84, 16);
            this.cbChildFolder.TabIndex = 5;
            this.cbChildFolder.Text = "包含子目录";
            this.cbChildFolder.UseVisualStyleBackColor = true;
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(542, 55);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(75, 23);
            this.btnFindFile.TabIndex = 6;
            this.btnFindFile.Text = "查找文件";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "更改后的文件编码：";
            // 
            // cbEncode
            // 
            this.cbEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncode.FormattingEnabled = true;
            this.cbEncode.Items.AddRange(new object[] {
            "UTF-8",
            "Unicode",
            "ASCII",
            "BigEndianUnicode",
            "UTF32",
            "UTF7",
            "Default"});
            this.cbEncode.Location = new System.Drawing.Point(181, 93);
            this.cbEncode.Name = "cbEncode";
            this.cbEncode.Size = new System.Drawing.Size(121, 20);
            this.cbEncode.TabIndex = 8;
            // 
            // btnChangeEncode
            // 
            this.btnChangeEncode.Location = new System.Drawing.Point(542, 89);
            this.btnChangeEncode.Name = "btnChangeEncode";
            this.btnChangeEncode.Size = new System.Drawing.Size(75, 23);
            this.btnChangeEncode.TabIndex = 9;
            this.btnChangeEncode.Text = "更改编码";
            this.btnChangeEncode.UseVisualStyleBackColor = true;
            this.btnChangeEncode.Click += new System.EventHandler(this.btnChangeEncode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbFileList);
            this.groupBox1.Location = new System.Drawing.Point(36, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 269);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更改文件列表";
            // 
            // rtbFileList
            // 
            this.rtbFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileList.BackColor = System.Drawing.Color.White;
            this.rtbFileList.Location = new System.Drawing.Point(6, 20);
            this.rtbFileList.Name = "rtbFileList";
            this.rtbFileList.ReadOnly = true;
            this.rtbFileList.Size = new System.Drawing.Size(681, 243);
            this.rtbFileList.TabIndex = 0;
            this.rtbFileList.Text = "";
            // 
            // labFileNum
            // 
            this.labFileNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labFileNum.AutoSize = true;
            this.labFileNum.Location = new System.Drawing.Point(626, 441);
            this.labFileNum.Name = "labFileNum";
            this.labFileNum.Size = new System.Drawing.Size(71, 12);
            this.labFileNum.TabIndex = 11;
            this.labFileNum.Text = "文件个数：0";
            this.labFileNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 462);
            this.Controls.Add(this.labFileNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChangeEncode);
            this.Controls.Add(this.cbEncode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.cbChildFolder);
            this.Controls.Add(this.tbsuffix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelevtFolder);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnSelevtFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsuffix;
        private System.Windows.Forms.CheckBox cbChildFolder;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEncode;
        private System.Windows.Forms.Button btnChangeEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbFileList;
        private System.Windows.Forms.Label labFileNum;
    }
}

