namespace SGEDSystem
{
    partial class TriangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForm));
            this.btnHelp_tolerance = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.labTolerance = new System.Windows.Forms.Label();
            this.txbVertices = new System.Windows.Forms.TextBox();
            this.btnHelp_degree = new System.Windows.Forms.Button();
            this.labDegree = new System.Windows.Forms.Label();
            this.txbDegree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHelp_tolerance
            // 
            this.btnHelp_tolerance.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelp_tolerance.Image = global::Map4._0.Properties.Resources.identify;
            this.btnHelp_tolerance.Location = new System.Drawing.Point(550, 51);
            this.btnHelp_tolerance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp_tolerance.Name = "btnHelp_tolerance";
            this.btnHelp_tolerance.Size = new System.Drawing.Size(30, 30);
            this.btnHelp_tolerance.TabIndex = 14;
            this.btnHelp_tolerance.UseVisualStyleBackColor = false;
            this.btnHelp_tolerance.Click += new System.EventHandler(this.btnHelp_tolerance_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(423, 222);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(266, 222);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 40);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labTolerance
            // 
            this.labTolerance.AutoSize = true;
            this.labTolerance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTolerance.Location = new System.Drawing.Point(73, 60);
            this.labTolerance.Name = "labTolerance";
            this.labTolerance.Size = new System.Drawing.Size(116, 31);
            this.labTolerance.TabIndex = 11;
            this.labTolerance.Text = "区域容差:";
            this.labTolerance.Click += new System.EventHandler(this.labTolerance_Click);
            // 
            // txbVertices
            // 
            this.txbVertices.Location = new System.Drawing.Point(230, 58);
            this.txbVertices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbVertices.Name = "txbVertices";
            this.txbVertices.Size = new System.Drawing.Size(314, 31);
            this.txbVertices.TabIndex = 10;
            this.txbVertices.Text = "请输入一个整数(0~255)";
            // 
            // btnHelp_degree
            // 
            this.btnHelp_degree.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelp_degree.Image = global::Map4._0.Properties.Resources.identify;
            this.btnHelp_degree.Location = new System.Drawing.Point(550, 140);
            this.btnHelp_degree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp_degree.Name = "btnHelp_degree";
            this.btnHelp_degree.Size = new System.Drawing.Size(30, 30);
            this.btnHelp_degree.TabIndex = 17;
            this.btnHelp_degree.UseVisualStyleBackColor = false;
            this.btnHelp_degree.Click += new System.EventHandler(this.btnHelp_degree_Click);
            // 
            // labDegree
            // 
            this.labDegree.AutoSize = true;
            this.labDegree.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDegree.Location = new System.Drawing.Point(73, 147);
            this.labDegree.Name = "labDegree";
            this.labDegree.Size = new System.Drawing.Size(92, 31);
            this.labDegree.TabIndex = 16;
            this.labDegree.Text = "逼近度:";
            // 
            // txbDegree
            // 
            this.txbDegree.Location = new System.Drawing.Point(230, 147);
            this.txbDegree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDegree.Name = "txbDegree";
            this.txbDegree.Size = new System.Drawing.Size(314, 31);
            this.txbDegree.TabIndex = 15;
            this.txbDegree.Text = "请输入一个整数（10~1000） ";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 294);
            this.Controls.Add(this.btnHelp_degree);
            this.Controls.Add(this.labDegree);
            this.Controls.Add(this.txbDegree);
            this.Controls.Add(this.btnHelp_tolerance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labTolerance);
            this.Controls.Add(this.txbVertices);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TriangleForm";
            this.Text = "角峰识别";
            this.Load += new System.EventHandler(this.TriangleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp_tolerance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labTolerance;
        private System.Windows.Forms.TextBox txbVertices;
        private System.Windows.Forms.Button btnHelp_degree;
        private System.Windows.Forms.Label labDegree;
        private System.Windows.Forms.TextBox txbDegree;
    }
}