namespace SGEDSystem
{
    partial class SQL_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQL_search));
            this.sqltext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sql_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqltext
            // 
            this.sqltext.Location = new System.Drawing.Point(9, 70);
            this.sqltext.Margin = new System.Windows.Forms.Padding(2);
            this.sqltext.Name = "sqltext";
            this.sqltext.Size = new System.Drawing.Size(139, 21);
            this.sqltext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入目标要素的属性信息\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sql_button
            // 
            this.sql_button.Location = new System.Drawing.Point(9, 130);
            this.sql_button.Margin = new System.Windows.Forms.Padding(2);
            this.sql_button.Name = "sql_button";
            this.sql_button.Size = new System.Drawing.Size(67, 26);
            this.sql_button.TabIndex = 2;
            this.sql_button.Text = "确定";
            this.sql_button.UseVisualStyleBackColor = true;
            this.sql_button.Click += new System.EventHandler(this.sql_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(80, 130);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(67, 26);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // SQL_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 191);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.sql_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqltext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQL_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqltext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sql_button;
        private System.Windows.Forms.Button cancel_button;
    }
}