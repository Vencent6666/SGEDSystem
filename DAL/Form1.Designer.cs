namespace SGEDSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.距离ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splcMapLegend = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLegend = new System.Windows.Forms.TabPage();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.Map1 = new DotSpatial.Controls.Map();
            this.statusBarBlocker2 = new System.Windows.Forms.Label();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.toolStripStatusLabelBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spatialToolStrip1 = new DotSpatial.Controls.SpatialToolStrip();
            this.toolStripButtonDeselect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNewShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.坐标查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多边形查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缓冲区查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.区块识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面积量算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.距离测量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).BeginInit();
            this.splcMapLegend.Panel1.SuspendLayout();
            this.splcMapLegend.Panel2.SuspendLayout();
            this.splcMapLegend.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLegend.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.spatialStatusStrip1.SuspendLayout();
            this.spatialToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapOperationsToolStripMenuItem,
            this.PatternToolStripMenuItem,
            this.extensionToolStripMenuItem,
            this.配置参数ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(993, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Map4._0.Properties.Resources.打开文件;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "加载地图";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::Map4._0.Properties.Resources.清除文件;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.clearToolStripMenuItem.Text = "清空地图";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Map4._0.Properties.Resources.退出;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Map4._0.Properties.Resources._1143785;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mapOperationsToolStripMenuItem
            // 
            this.mapOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomExtentToolStripMenuItem});
            this.mapOperationsToolStripMenuItem.Name = "mapOperationsToolStripMenuItem";
            this.mapOperationsToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.mapOperationsToolStripMenuItem.Text = "图形浏览";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = global::Map4._0.Properties.Resources.放大;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.zoomInToolStripMenuItem.Text = "放大";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = global::Map4._0.Properties.Resources.缩小;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.zoomOutToolStripMenuItem.Text = "缩小";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomExtentToolStripMenuItem
            // 
            this.zoomExtentToolStripMenuItem.Image = global::Map4._0.Properties.Resources.缩放;
            this.zoomExtentToolStripMenuItem.Name = "zoomExtentToolStripMenuItem";
            this.zoomExtentToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.zoomExtentToolStripMenuItem.Text = "全图";
            this.zoomExtentToolStripMenuItem.Click += new System.EventHandler(this.zoomExtentToolStripMenuItem_Click);
            // 
            // PatternToolStripMenuItem
            // 
            this.PatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaToolStripMenuItem,
            this.BlockToolStripMenuItem,
            this.距离ToolStripMenuItem});
            this.PatternToolStripMenuItem.Name = "PatternToolStripMenuItem";
            this.PatternToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.PatternToolStripMenuItem.Text = "图形量算";
            // 
            // AreaToolStripMenuItem
            // 
            this.AreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlaneToolStripMenuItem,
            this.SphereToolStripMenuItem});
            this.AreaToolStripMenuItem.Name = "AreaToolStripMenuItem";
            this.AreaToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AreaToolStripMenuItem.Text = "面积";
            this.AreaToolStripMenuItem.Click += new System.EventHandler(this.AearToolStripMenuItem_Click);
            // 
            // PlaneToolStripMenuItem
            // 
            this.PlaneToolStripMenuItem.Name = "PlaneToolStripMenuItem";
            this.PlaneToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.PlaneToolStripMenuItem.Text = "平面";
            this.PlaneToolStripMenuItem.Click += new System.EventHandler(this.PlaneToolStripMenuItem_Click);
            // 
            // SphereToolStripMenuItem
            // 
            this.SphereToolStripMenuItem.Name = "SphereToolStripMenuItem";
            this.SphereToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SphereToolStripMenuItem.Text = "球面";
            this.SphereToolStripMenuItem.Click += new System.EventHandler(this.SphereToolStripMenuItem_Click);
            // 
            // BlockToolStripMenuItem
            // 
            this.BlockToolStripMenuItem.Name = "BlockToolStripMenuItem";
            this.BlockToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.BlockToolStripMenuItem.Text = "区块";
            this.BlockToolStripMenuItem.Click += new System.EventHandler(this.BlockToolStripMenuItem_Click);
            // 
            // 距离ToolStripMenuItem
            // 
            this.距离ToolStripMenuItem.Name = "距离ToolStripMenuItem";
            this.距离ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.距离ToolStripMenuItem.Text = "距离";
            // 
            // extensionToolStripMenuItem
            // 
            this.extensionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.extensionToolStripMenuItem.Name = "extensionToolStripMenuItem";
            this.extensionToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.extensionToolStripMenuItem.Text = "地理实体识别";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.lineToolStripMenuItem.Text = "河流";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.circleToolStripMenuItem.Text = "火山口";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.triangleToolStripMenuItem.Text = "角峰";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // 配置参数ToolStripMenuItem
            // 
            this.配置参数ToolStripMenuItem.Name = "配置参数ToolStripMenuItem";
            this.配置参数ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.配置参数ToolStripMenuItem.Text = "配置参数";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OverviewToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // OverviewToolStripMenuItem
            // 
            this.OverviewToolStripMenuItem.Name = "OverviewToolStripMenuItem";
            this.OverviewToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.OverviewToolStripMenuItem.Text = "总览";
            this.OverviewToolStripMenuItem.Click += new System.EventHandler(this.OverviewToolStripMenuItem_Click);
            // 
            // splcMapLegend
            // 
            this.splcMapLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcMapLegend.Location = new System.Drawing.Point(0, 54);
            this.splcMapLegend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            this.splcMapLegend.Panel1.Controls.Add(this.tabControl1);
            // 
            // splcMapLegend.Panel2
            // 
            this.splcMapLegend.Panel2.Controls.Add(this.tabControl2);
            this.splcMapLegend.Panel2.Controls.Add(this.statusBarBlocker2);
            this.splcMapLegend.Size = new System.Drawing.Size(993, 534);
            this.splcMapLegend.SplitterDistance = 250;
            this.splcMapLegend.SplitterWidth = 3;
            this.splcMapLegend.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLegend);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 534);
            this.tabControl1.TabIndex = 1;
            // 
            // tabLegend
            // 
            this.tabLegend.Controls.Add(this.legend1);
            this.tabLegend.Location = new System.Drawing.Point(4, 26);
            this.tabLegend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLegend.Name = "tabLegend";
            this.tabLegend.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLegend.Size = new System.Drawing.Size(242, 504);
            this.tabLegend.TabIndex = 0;
            this.tabLegend.Text = "Legend";
            this.tabLegend.UseVisualStyleBackColor = true;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 236, 496);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(3, 4);
            this.legend1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 6);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = true;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(236, 496);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabMap);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(740, 534);
            this.tabControl2.TabIndex = 2;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.Map1);
            this.tabMap.Location = new System.Drawing.Point(4, 26);
            this.tabMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMap.Size = new System.Drawing.Size(732, 504);
            this.tabMap.TabIndex = 1;
            this.tabMap.Text = "Map";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // Map1
            // 
            this.Map1.AllowDrop = true;
            this.Map1.BackColor = System.Drawing.Color.White;
            this.Map1.CollectAfterDraw = false;
            this.Map1.CollisionDetection = false;
            this.Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map1.ExtendBuffer = false;
            this.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.Map1.IsBusy = false;
            this.Map1.IsZoomedToMaxExtent = false;
            this.Map1.Legend = this.legend1;
            this.Map1.Location = new System.Drawing.Point(3, 4);
            this.Map1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Map1.Name = "Map1";
            this.Map1.ProgressHandler = null;
            this.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.RedrawLayersWhileResizing = false;
            this.Map1.SelectionEnabled = true;
            this.Map1.Size = new System.Drawing.Size(726, 496);
            this.Map1.TabIndex = 0;
            this.Map1.GeoMouseMove += new System.EventHandler<DotSpatial.Controls.GeoMouseArgs>(this.Map1_GeoMouseMove);
            this.Map1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map1_MouseDown);
            // 
            // statusBarBlocker2
            // 
            this.statusBarBlocker2.AutoSize = true;
            this.statusBarBlocker2.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusBarBlocker2.Location = new System.Drawing.Point(740, 0);
            this.statusBarBlocker2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusBarBlocker2.Name = "statusBarBlocker2";
            this.statusBarBlocker2.Size = new System.Drawing.Size(0, 17);
            this.statusBarBlocker2.TabIndex = 1;
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelBlank,
            this.toolStripStatusLabelXY,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 566);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.spatialStatusStrip1.ProgressBar = this.toolStripProgressBar1;
            this.spatialStatusStrip1.ProgressLabel = this.toolStripStatusLabelBlank;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(993, 22);
            this.spatialStatusStrip1.TabIndex = 10;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // toolStripStatusLabelBlank
            // 
            this.toolStripStatusLabelBlank.Name = "toolStripStatusLabelBlank";
            this.toolStripStatusLabelBlank.Size = new System.Drawing.Size(492, 17);
            this.toolStripStatusLabelBlank.Text = "                                                                                 " +
    "                                        ";
            // 
            // toolStripStatusLabelXY
            // 
            this.toolStripStatusLabelXY.Name = "toolStripStatusLabelXY";
            this.toolStripStatusLabelXY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelXY.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabelXY.Text = "X:     ,Y:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(257, 17);
            this.toolStripStatusLabel1.Text = "Copyright © NNU GIS设计开发第七组. 2019";
            // 
            // spatialToolStrip1
            // 
            this.spatialToolStrip1.AllowDrop = true;
            this.spatialToolStrip1.ApplicationManager = null;
            this.spatialToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDeselect,
            this.toolStripButtonRemove,
            this.toolStripSeparator1,
            this.toolStripButtonNewShape,
            this.toolStripButtonSaveShape,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.spatialToolStrip1.Location = new System.Drawing.Point(0, 27);
            this.spatialToolStrip1.Map = this.Map1;
            this.spatialToolStrip1.Name = "spatialToolStrip1";
            this.spatialToolStrip1.Size = new System.Drawing.Size(993, 27);
            this.spatialToolStrip1.TabIndex = 11;
            this.spatialToolStrip1.Text = "spatialToolStrip1";
            // 
            // toolStripButtonDeselect
            // 
            this.toolStripButtonDeselect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeselect.Image = global::Map4._0.Properties.Resources.deselect_all;
            this.toolStripButtonDeselect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeselect.Name = "toolStripButtonDeselect";
            this.toolStripButtonDeselect.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeselect.Text = "Deselect All";
            this.toolStripButtonDeselect.Click += new System.EventHandler(this.toolStripButtonDeselect_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Image = global::Map4._0.Properties.Resources.clear_map;
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemove.Text = "Clear layer";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonNewShape
            // 
            this.toolStripButtonNewShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewShape.Image = global::Map4._0.Properties.Resources.new_shape;
            this.toolStripButtonNewShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewShape.Name = "toolStripButtonNewShape";
            this.toolStripButtonNewShape.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNewShape.Text = "New Shape";
            this.toolStripButtonNewShape.Click += new System.EventHandler(this.toolStripButtonNewShape_Click);
            // 
            // toolStripButtonSaveShape
            // 
            this.toolStripButtonSaveShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveShape.Image = global::Map4._0.Properties.Resources.save_shape;
            this.toolStripButtonSaveShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveShape.Name = "toolStripButtonSaveShape";
            this.toolStripButtonSaveShape.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSaveShape.Text = "Save Shape";
            this.toolStripButtonSaveShape.Click += new System.EventHandler(this.toolStripButtonSaveShape_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.坐标查询ToolStripMenuItem,
            this.矩形查询ToolStripMenuItem,
            this.多边形查询ToolStripMenuItem,
            this.缓冲区查询ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 坐标查询ToolStripMenuItem
            // 
            this.坐标查询ToolStripMenuItem.Name = "坐标查询ToolStripMenuItem";
            this.坐标查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.坐标查询ToolStripMenuItem.Text = "坐标查询";
            // 
            // 矩形查询ToolStripMenuItem
            // 
            this.矩形查询ToolStripMenuItem.Name = "矩形查询ToolStripMenuItem";
            this.矩形查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.矩形查询ToolStripMenuItem.Text = "矩形查询";
            // 
            // 多边形查询ToolStripMenuItem
            // 
            this.多边形查询ToolStripMenuItem.Name = "多边形查询ToolStripMenuItem";
            this.多边形查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.多边形查询ToolStripMenuItem.Text = "多边形查询";
            // 
            // 缓冲区查询ToolStripMenuItem
            // 
            this.缓冲区查询ToolStripMenuItem.Name = "缓冲区查询ToolStripMenuItem";
            this.缓冲区查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缓冲区查询ToolStripMenuItem.Text = "缓冲区查询";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.区块识别ToolStripMenuItem,
            this.面积量算ToolStripMenuItem,
            this.距离测量ToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // 区块识别ToolStripMenuItem
            // 
            this.区块识别ToolStripMenuItem.Name = "区块识别ToolStripMenuItem";
            this.区块识别ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.区块识别ToolStripMenuItem.Text = "区块识别";
            // 
            // 面积量算ToolStripMenuItem
            // 
            this.面积量算ToolStripMenuItem.Name = "面积量算ToolStripMenuItem";
            this.面积量算ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.面积量算ToolStripMenuItem.Text = "面积计算";
            // 
            // 距离测量ToolStripMenuItem
            // 
            this.距离测量ToolStripMenuItem.Name = "距离测量ToolStripMenuItem";
            this.距离测量ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.距离测量ToolStripMenuItem.Text = "距离测量";
            // 
            // spatialHeaderControl1
            // 
            this.spatialHeaderControl1.ApplicationManager = this.appManager1;
            this.spatialHeaderControl1.MenuStrip = this.menuStrip1;
            this.spatialHeaderControl1.ToolbarsContainer = null;
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = null;
            this.appManager1.HeaderControl = null;
            this.appManager1.Legend = this.legend1;
            this.appManager1.Map = this.Map1;
            this.appManager1.ProgressHandler = this.spatialStatusStrip1;
            this.appManager1.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 588);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.splcMapLegend);
            this.Controls.Add(this.spatialToolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "特殊地理实体识别";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splcMapLegend.Panel1.ResumeLayout(false);
            this.splcMapLegend.Panel2.ResumeLayout(false);
            this.splcMapLegend.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).EndInit();
            this.splcMapLegend.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLegend.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.spatialToolStrip1.ResumeLayout(false);
            this.spatialToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOperationsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcMapLegend;
        private DotSpatial.Controls.Legend legend1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label statusBarBlocker2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLegend;
        private System.Windows.Forms.TabControl tabControl2;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelXY;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeselect;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewShape;
        private System.Windows.Forms.TabPage tabMap;
        private DotSpatial.Controls.Map Map1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveShape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBlank;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl1;
        private DotSpatial.Controls.AppManager appManager1;
        private System.Windows.Forms.ToolStripMenuItem PatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 坐标查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多边形查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缓冲区查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem 区块识别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面积量算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 距离测量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 距离ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OverviewToolStripMenuItem;
    }
}

