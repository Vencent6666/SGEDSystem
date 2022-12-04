namespace Map4._0
{
    partial class SaveForm
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
            this.Eixtbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.txbOut = new System.Windows.Forms.TextBox();
            this.labOut = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eixtbutton
            // 
            this.Eixtbutton.Location = new System.Drawing.Point(389, 143);
            this.Eixtbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eixtbutton.Name = "Eixtbutton";
            this.Eixtbutton.Size = new System.Drawing.Size(107, 40);
            this.Eixtbutton.TabIndex = 12;
            this.Eixtbutton.Text = "Cancel";
            this.Eixtbutton.UseVisualStyleBackColor = true;
            this.Eixtbutton.Click += new System.EventHandler(this.Eixtbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(246, 143);
            this.Startbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(107, 40);
            this.Startbutton.TabIndex = 11;
            this.Startbutton.Text = "OK";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // txbOut
            // 
            this.txbOut.Location = new System.Drawing.Point(144, 50);
            this.txbOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbOut.Name = "txbOut";
            this.txbOut.Size = new System.Drawing.Size(316, 23);
            this.txbOut.TabIndex = 22;
            // 
            // labOut
            // 
            this.labOut.AutoSize = true;
            this.labOut.Location = new System.Drawing.Point(27, 53);
            this.labOut.Name = "labOut";
            this.labOut.Size = new System.Drawing.Size(71, 17);
            this.labOut.TabIndex = 21;
            this.labOut.Text = "Output File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(466, 47);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(69, 28);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 211);
            this.Controls.Add(this.txbOut);
            this.Controls.Add(this.labOut);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.Eixtbutton);
            this.Controls.Add(this.Startbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SaveForm";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eixtbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.TextBox txbOut;
        private System.Windows.Forms.Label labOut;
        private System.Windows.Forms.Button btnBrowse;
    }
}