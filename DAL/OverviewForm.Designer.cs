namespace SGEDSystem
{
    partial class OverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewForm));
            this.Overviewmap = new DotSpatial.Controls.Map();
            this.SuspendLayout();
            // 
            // Overviewmap
            // 
            this.Overviewmap.AllowDrop = true;
            this.Overviewmap.BackColor = System.Drawing.Color.White;
            this.Overviewmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Overviewmap.CollectAfterDraw = false;
            this.Overviewmap.CollisionDetection = false;
            this.Overviewmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Overviewmap.ExtendBuffer = false;
            this.Overviewmap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.Overviewmap.IsBusy = false;
            this.Overviewmap.IsZoomedToMaxExtent = false;
            this.Overviewmap.Legend = null;
            this.Overviewmap.Location = new System.Drawing.Point(0, 0);
            this.Overviewmap.Name = "Overviewmap";
            this.Overviewmap.ProgressHandler = null;
            this.Overviewmap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Overviewmap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Overviewmap.RedrawLayersWhileResizing = false;
            this.Overviewmap.SelectionEnabled = true;
            this.Overviewmap.Size = new System.Drawing.Size(277, 226);
            this.Overviewmap.TabIndex = 0;
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 226);
            this.Controls.Add(this.Overviewmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverviewForm";
            this.Text = "总览";
            this.ResumeLayout(false);

        }

        #endregion

        private DotSpatial.Controls.Map Overviewmap;
    }
}