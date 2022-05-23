namespace SGEDSystem
{
    partial class CraterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraterForm));
            this.btnHelpfilename = new System.Windows.Forms.Button();
            this.labfilename = new System.Windows.Forms.Label();
            this.txboutfilename = new System.Windows.Forms.TextBox();
            this.cmbInput = new System.Windows.Forms.ComboBox();
            this.btnoutput = new System.Windows.Forms.Button();
            this.laboutput = new System.Windows.Forms.Label();
            this.txboutput = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chbShow = new System.Windows.Forms.CheckBox();
            this.labInput = new System.Windows.Forms.Label();
            this.btnHelpAlw = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.labAlw = new System.Windows.Forms.Label();
            this.txbAlw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHelpfilename
            // 
            this.btnHelpfilename.Image = global::Map4._0.Properties.Resources.help;
            this.btnHelpfilename.Location = new System.Drawing.Point(451, 109);
            this.btnHelpfilename.Name = "btnHelpfilename";
            this.btnHelpfilename.Size = new System.Drawing.Size(30, 30);
            this.btnHelpfilename.TabIndex = 36;
            this.btnHelpfilename.UseVisualStyleBackColor = true;
            this.btnHelpfilename.Click += new System.EventHandler(this.btnHelpfilename_Click);
            // 
            // labfilename
            // 
            this.labfilename.AutoSize = true;
            this.labfilename.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labfilename.Location = new System.Drawing.Point(17, 118);
            this.labfilename.Name = "labfilename";
            this.labfilename.Size = new System.Drawing.Size(94, 21);
            this.labfilename.TabIndex = 35;
            this.labfilename.Text = "输出文件名:";
            // 
            // txboutfilename
            // 
            this.txboutfilename.Location = new System.Drawing.Point(129, 116);
            this.txboutfilename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txboutfilename.Name = "txboutfilename";
            this.txboutfilename.Size = new System.Drawing.Size(295, 23);
            this.txboutfilename.TabIndex = 34;
            this.txboutfilename.Text = "请输入文件名";
            // 
            // cmbInput
            // 
            this.cmbInput.FormattingEnabled = true;
            this.cmbInput.Location = new System.Drawing.Point(129, 66);
            this.cmbInput.Name = "cmbInput";
            this.cmbInput.Size = new System.Drawing.Size(295, 25);
            this.cmbInput.TabIndex = 33;
            this.cmbInput.Text = "请选择识别图层";
            // 
            // btnoutput
            // 
            this.btnoutput.Location = new System.Drawing.Point(451, 159);
            this.btnoutput.Name = "btnoutput";
            this.btnoutput.Size = new System.Drawing.Size(50, 30);
            this.btnoutput.TabIndex = 32;
            this.btnoutput.Text = "浏览...";
            this.btnoutput.UseVisualStyleBackColor = true;
            this.btnoutput.Click += new System.EventHandler(this.btnoutput_Click);
            // 
            // laboutput
            // 
            this.laboutput.AutoSize = true;
            this.laboutput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laboutput.Location = new System.Drawing.Point(33, 163);
            this.laboutput.Name = "laboutput";
            this.laboutput.Size = new System.Drawing.Size(78, 21);
            this.laboutput.TabIndex = 31;
            this.laboutput.Text = "输出目录:";
            // 
            // txboutput
            // 
            this.txboutput.Location = new System.Drawing.Point(129, 163);
            this.txboutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txboutput.Name = "txboutput";
            this.txboutput.Size = new System.Drawing.Size(295, 23);
            this.txboutput.TabIndex = 30;
            this.txboutput.Text = "请选择输出目录";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::Map4._0.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(451, 66);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // chbShow
            // 
            this.chbShow.AutoSize = true;
            this.chbShow.Checked = true;
            this.chbShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShow.Location = new System.Drawing.Point(47, 214);
            this.chbShow.Name = "chbShow";
            this.chbShow.Size = new System.Drawing.Size(135, 21);
            this.chbShow.TabIndex = 28;
            this.chbShow.Text = "是否加载至当前图层";
            this.chbShow.UseVisualStyleBackColor = true;
            // 
            // labInput
            // 
            this.labInput.AutoSize = true;
            this.labInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInput.Location = new System.Drawing.Point(33, 69);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(78, 21);
            this.labInput.TabIndex = 27;
            this.labInput.Text = "输入图层:";
            // 
            // btnHelpAlw
            // 
            this.btnHelpAlw.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelpAlw.Image = global::Map4._0.Properties.Resources.help;
            this.btnHelpAlw.Location = new System.Drawing.Point(451, 23);
            this.btnHelpAlw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelpAlw.Name = "btnHelpAlw";
            this.btnHelpAlw.Size = new System.Drawing.Size(30, 30);
            this.btnHelpAlw.TabIndex = 26;
            this.btnHelpAlw.UseVisualStyleBackColor = false;
            this.btnHelpAlw.Click += new System.EventHandler(this.btnHelpAlw_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(383, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 29);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(273, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 29);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labAlw
            // 
            this.labAlw.AutoSize = true;
            this.labAlw.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAlw.Location = new System.Drawing.Point(65, 26);
            this.labAlw.Name = "labAlw";
            this.labAlw.Size = new System.Drawing.Size(46, 21);
            this.labAlw.TabIndex = 23;
            this.labAlw.Text = "阈值:";
            // 
            // txbAlw
            // 
            this.txbAlw.Location = new System.Drawing.Point(129, 23);
            this.txbAlw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAlw.Name = "txbAlw";
            this.txbAlw.Size = new System.Drawing.Size(295, 23);
            this.txbAlw.TabIndex = 22;
            this.txbAlw.Text = "请输入一个整数";
            // 
            // CraterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 260);
            this.Controls.Add(this.btnHelpfilename);
            this.Controls.Add(this.labfilename);
            this.Controls.Add(this.txboutfilename);
            this.Controls.Add(this.cmbInput);
            this.Controls.Add(this.btnoutput);
            this.Controls.Add(this.laboutput);
            this.Controls.Add(this.txboutput);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chbShow);
            this.Controls.Add(this.labInput);
            this.Controls.Add(this.btnHelpAlw);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labAlw);
            this.Controls.Add(this.txbAlw);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "火山口识别";
            this.Load += new System.EventHandler(this.CraterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelpfilename;
        private System.Windows.Forms.Label labfilename;
        private System.Windows.Forms.TextBox txboutfilename;
        private System.Windows.Forms.ComboBox cmbInput;
        private System.Windows.Forms.Button btnoutput;
        private System.Windows.Forms.Label laboutput;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox chbShow;
        private System.Windows.Forms.Label labInput;
        private System.Windows.Forms.Button btnHelpAlw;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labAlw;
        private System.Windows.Forms.TextBox txbAlw;
        public System.Windows.Forms.TextBox txboutput;
    }
}