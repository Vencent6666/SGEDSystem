using System;
using System.Windows.Forms;

namespace SGEDSystem
{
    partial class HelpDocument
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("欢迎使用帮助库");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("加载地图");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("清空地图");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("关于");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("文件", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("总览");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("视图", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("点击查询");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("查看属性表");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("SQL查询");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("缓冲区查询");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("查询", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("放大");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("缩小");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("全图");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("图形浏览", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("图形量算");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("直线实体");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("火山口");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("地理实体识别", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("存储路径");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("主题配置");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("火山口识别参数");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("配置", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("帮助文档");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("关于文档");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("帮助", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("新建shapefile");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("保存shapefile");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("shapefile", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDocument));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(988, 476);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "欢迎使用帮助库";
            treeNode2.Name = "节点2";
            treeNode2.Text = "加载地图";
            treeNode3.Name = "节点3";
            treeNode3.Text = "清空地图";
            treeNode4.Name = "节点4";
            treeNode4.Text = "退出";
            treeNode5.Name = "节点5";
            treeNode5.Text = "关于";
            treeNode6.Name = "节点1";
            treeNode6.Text = "文件";
            treeNode7.Name = "节点7";
            treeNode7.Text = "总览";
            treeNode8.Name = "节点6";
            treeNode8.Text = "视图";
            treeNode9.Name = "节点0";
            treeNode9.Text = "点击查询";
            treeNode10.Name = "节点1";
            treeNode10.Text = "查看属性表";
            treeNode11.Name = "节点2";
            treeNode11.Text = "SQL查询";
            treeNode12.Name = "节点3";
            treeNode12.Text = "缓冲区查询";
            treeNode13.Name = "节点14";
            treeNode13.Text = "查询";
            treeNode14.Name = "节点20";
            treeNode14.Text = "放大";
            treeNode15.Name = "节点21";
            treeNode15.Text = "缩小";
            treeNode16.Name = "节点22";
            treeNode16.Text = "全图";
            treeNode17.Name = "节点19";
            treeNode17.Text = "图形浏览";
            treeNode18.Name = "节点25";
            treeNode18.Text = "图形量算";
            treeNode19.Name = "节点1";
            treeNode19.Text = "直线实体";
            treeNode20.Name = "节点2";
            treeNode20.Text = "火山口";
            treeNode21.Name = "节点0";
            treeNode21.Text = "地理实体识别";
            treeNode22.Name = "节点6";
            treeNode22.Text = "存储路径";
            treeNode23.Name = "节点7";
            treeNode23.Text = "主题配置";
            treeNode24.Name = "节点0";
            treeNode24.Text = "火山口识别参数";
            treeNode25.Name = "节点5";
            treeNode25.Text = "配置";
            treeNode26.Name = "节点4";
            treeNode26.Text = "帮助文档";
            treeNode27.Name = "节点5";
            treeNode27.Text = "关于文档";
            treeNode28.Name = "节点6";
            treeNode28.Text = "帮助";
            treeNode29.Name = "节点2";
            treeNode29.Text = "新建shapefile";
            treeNode30.Name = "节点3";
            treeNode30.Text = "保存shapefile";
            treeNode31.Name = "节点1";
            treeNode31.Text = "shapefile";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode8,
            treeNode13,
            treeNode17,
            treeNode18,
            treeNode21,
            treeNode25,
            treeNode28,
            treeNode31});
            this.treeView1.Size = new System.Drawing.Size(326, 476);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // HelpDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 508);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "特殊地理实体识别系统帮助";
            this.Load += new System.EventHandler(this.HelpDocument_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }   





        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
    }
}