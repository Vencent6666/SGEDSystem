namespace SGEDSystem
{
    partial class ConfigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labNewFilePath = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labResultPath = new System.Windows.Forms.Label();
            this.btnCleanPath = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labTempPath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetting = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labSelect = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbTh6 = new System.Windows.Forms.TextBox();
            this.labTh6 = new System.Windows.Forms.Label();
            this.txbTh4 = new System.Windows.Forms.TextBox();
            this.labTh4 = new System.Windows.Forms.Label();
            this.txbTh3 = new System.Windows.Forms.TextBox();
            this.labTh3 = new System.Windows.Forms.Label();
            this.txbTh2 = new System.Windows.Forms.TextBox();
            this.labTh2 = new System.Windows.Forms.Label();
            this.btnResetting2 = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.txbTh1 = new System.Windows.Forms.TextBox();
            this.labTh1 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnNewFile);
            this.tabPage1.Controls.Add(this.btnTemp);
            this.tabPage1.Controls.Add(this.btnResult);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.labNewFilePath);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.labResultPath);
            this.tabPage1.Controls.Add(this.btnCleanPath);
            this.tabPage1.Controls.Add(this.btnSavePath);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.labTempPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 297);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "存储路径";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(383, 186);
            this.btnNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(61, 20);
            this.btnNewFile.TabIndex = 10;
            this.btnNewFile.Text = "浏览...";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.xjlj_button_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(383, 49);
            this.btnTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(61, 20);
            this.btnTemp.TabIndex = 9;
            this.btnTemp.Text = "浏览...";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.zjlj_button_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(383, 117);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(61, 20);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "浏览...";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 21);
            this.textBox3.TabIndex = 7;
            // 
            // labNewFilePath
            // 
            this.labNewFilePath.AutoSize = true;
            this.labNewFilePath.Location = new System.Drawing.Point(20, 190);
            this.labNewFilePath.Name = "labNewFilePath";
            this.labNewFilePath.Size = new System.Drawing.Size(125, 12);
            this.labNewFilePath.TabIndex = 6;
            this.labNewFilePath.Text = "默认新建文件存储路径";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "E:\\my file\\火山识别算法\\测试结果";
            // 
            // labResultPath
            // 
            this.labResultPath.AutoSize = true;
            this.labResultPath.Location = new System.Drawing.Point(20, 121);
            this.labResultPath.Name = "labResultPath";
            this.labResultPath.Size = new System.Drawing.Size(125, 12);
            this.labResultPath.TabIndex = 4;
            this.labResultPath.Text = "默认识别结果存储路径";
            // 
            // btnCleanPath
            // 
            this.btnCleanPath.Location = new System.Drawing.Point(335, 243);
            this.btnCleanPath.Name = "btnCleanPath";
            this.btnCleanPath.Size = new System.Drawing.Size(72, 29);
            this.btnCleanPath.TabIndex = 3;
            this.btnCleanPath.Text = "清空";
            this.btnCleanPath.UseVisualStyleBackColor = true;
            this.btnCleanPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(216, 243);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(72, 29);
            this.btnSavePath.TabIndex = 2;
            this.btnSavePath.Text = "应用";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 21);
            this.textBox1.TabIndex = 1;
            // 
            // labTempPath
            // 
            this.labTempPath.AutoSize = true;
            this.labTempPath.Location = new System.Drawing.Point(20, 53);
            this.labTempPath.Name = "labTempPath";
            this.labTempPath.Size = new System.Drawing.Size(125, 12);
            this.labTempPath.TabIndex = 0;
            this.labTempPath.Text = "默认中间文件存储路径";
            this.labTempPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnResetting);
            this.tabPage2.Controls.Add(this.btnOK);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.labSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 297);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "主题配置";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(124, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetting
            // 
            this.btnResetting.Location = new System.Drawing.Point(235, 242);
            this.btnResetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetting.Name = "btnResetting";
            this.btnResetting.Size = new System.Drawing.Size(72, 29);
            this.btnResetting.TabIndex = 8;
            this.btnResetting.Text = "恢复默认";
            this.btnResetting.UseVisualStyleBackColor = true;
            this.btnResetting.Click += new System.EventHandler(this.btnResetting_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(350, 242);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 29);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "应用";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(106, 40);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 136);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labSelect
            // 
            this.labSelect.AutoSize = true;
            this.labSelect.Location = new System.Drawing.Point(28, 40);
            this.labSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSelect.Name = "labSelect";
            this.labSelect.Size = new System.Drawing.Size(53, 12);
            this.labSelect.TabIndex = 5;
            this.labSelect.Text = "选择主题";
            this.labSelect.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.txbTh6);
            this.tabPage3.Controls.Add(this.labTh6);
            this.tabPage3.Controls.Add(this.txbTh4);
            this.tabPage3.Controls.Add(this.labTh4);
            this.tabPage3.Controls.Add(this.txbTh3);
            this.tabPage3.Controls.Add(this.labTh3);
            this.tabPage3.Controls.Add(this.txbTh2);
            this.tabPage3.Controls.Add(this.labTh2);
            this.tabPage3.Controls.Add(this.btnResetting2);
            this.tabPage3.Controls.Add(this.btnSaveP);
            this.tabPage3.Controls.Add(this.txbTh1);
            this.tabPage3.Controls.Add(this.labTh1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(455, 297);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "火山口识别参数";
            // 
            // txbTh6
            // 
            this.txbTh6.Location = new System.Drawing.Point(289, 197);
            this.txbTh6.Name = "txbTh6";
            this.txbTh6.Size = new System.Drawing.Size(118, 21);
            this.txbTh6.TabIndex = 24;
            // 
            // labTh6
            // 
            this.labTh6.AutoSize = true;
            this.labTh6.Location = new System.Drawing.Point(27, 200);
            this.labTh6.Name = "labTh6";
            this.labTh6.Size = new System.Drawing.Size(137, 12);
            this.labTh6.TabIndex = 23;
            this.labTh6.Text = "默认真圆最少点阈值阈值";
            // 
            // txbTh4
            // 
            this.txbTh4.Location = new System.Drawing.Point(289, 151);
            this.txbTh4.Name = "txbTh4";
            this.txbTh4.Size = new System.Drawing.Size(118, 21);
            this.txbTh4.TabIndex = 20;
            // 
            // labTh4
            // 
            this.labTh4.AutoSize = true;
            this.labTh4.Location = new System.Drawing.Point(27, 154);
            this.labTh4.Name = "labTh4";
            this.labTh4.Size = new System.Drawing.Size(209, 12);
            this.labTh4.TabIndex = 19;
            this.labTh4.Text = "默认半径阈值（单位与图层单位相等）";
            // 
            // txbTh3
            // 
            this.txbTh3.Location = new System.Drawing.Point(289, 109);
            this.txbTh3.Name = "txbTh3";
            this.txbTh3.Size = new System.Drawing.Size(118, 21);
            this.txbTh3.TabIndex = 18;
            // 
            // labTh3
            // 
            this.labTh3.AutoSize = true;
            this.labTh3.Location = new System.Drawing.Point(27, 112);
            this.labTh3.Name = "labTh3";
            this.labTh3.Size = new System.Drawing.Size(233, 12);
            this.labTh3.TabIndex = 17;
            this.labTh3.Text = "默认识别圆心阈值（单位与图层单位相等）";
            // 
            // txbTh2
            // 
            this.txbTh2.Location = new System.Drawing.Point(289, 67);
            this.txbTh2.Name = "txbTh2";
            this.txbTh2.Size = new System.Drawing.Size(118, 21);
            this.txbTh2.TabIndex = 16;
            // 
            // labTh2
            // 
            this.labTh2.AutoSize = true;
            this.labTh2.Location = new System.Drawing.Point(27, 70);
            this.labTh2.Name = "labTh2";
            this.labTh2.Size = new System.Drawing.Size(113, 12);
            this.labTh2.TabIndex = 15;
            this.labTh2.Text = "默认最小识别长宽比";
            // 
            // btnResetting2
            // 
            this.btnResetting2.Location = new System.Drawing.Point(335, 248);
            this.btnResetting2.Name = "btnResetting2";
            this.btnResetting2.Size = new System.Drawing.Size(72, 29);
            this.btnResetting2.TabIndex = 14;
            this.btnResetting2.Text = "恢复默认";
            this.btnResetting2.UseVisualStyleBackColor = true;
            this.btnResetting2.Click += new System.EventHandler(this.btnResetting2_Click);
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(227, 248);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(72, 29);
            this.btnSaveP.TabIndex = 13;
            this.btnSaveP.Text = "应用";
            this.btnSaveP.UseVisualStyleBackColor = true;
            this.btnSaveP.Click += new System.EventHandler(this.btnOK3_Click);
            // 
            // txbTh1
            // 
            this.txbTh1.Location = new System.Drawing.Point(289, 25);
            this.txbTh1.Name = "txbTh1";
            this.txbTh1.Size = new System.Drawing.Size(118, 21);
            this.txbTh1.TabIndex = 12;
            // 
            // labTh1
            // 
            this.labTh1.AutoSize = true;
            this.labTh1.Location = new System.Drawing.Point(27, 28);
            this.labTh1.Name = "labTh1";
            this.labTh1.Size = new System.Drawing.Size(233, 12);
            this.labTh1.TabIndex = 11;
            this.labTh1.Text = "默认最小识别面积（单位与图层单位相等）";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 323);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labResultPath;
        private System.Windows.Forms.Button btnCleanPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labTempPath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labNewFilePath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnResetting;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labSelect;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txbTh2;
        private System.Windows.Forms.Label labTh2;
        private System.Windows.Forms.Button btnResetting2;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.TextBox txbTh1;
        private System.Windows.Forms.Label labTh1;
        private System.Windows.Forms.TextBox txbTh4;
        private System.Windows.Forms.Label labTh4;
        private System.Windows.Forms.TextBox txbTh3;
        private System.Windows.Forms.Label labTh3;
        private System.Windows.Forms.TextBox txbTh6;
        private System.Windows.Forms.Label labTh6;
    }
}