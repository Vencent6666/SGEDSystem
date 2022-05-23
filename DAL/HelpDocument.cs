using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using Map4._0.UIL;

namespace SGEDSystem
{
    public partial class HelpDocument : Form
    {
        public HelpDocument()
        {
            InitializeComponent();
        }
        string name;

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            name = e.Node.Text.ToString();
            if (name == "欢迎使用帮助库")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form1 f = new Form1();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if(name =="加载地图")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form2 f = new Form2();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "清空地图")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form3 f = new Form3();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "退出")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form4 f = new Form4();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "关于")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form5 f = new Form5();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "总览")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form6 f = new Form6();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "放大")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form7 f = new Form7();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "缩小")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form8 f = new Form8();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "全图")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form9 f = new Form9();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }

            if (name == "直线实体")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form13 f = new Form13();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "火山口")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form14 f = new Form14();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "帮助文档")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form15 f = new Form15();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "关于文档")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form11 f = new Form11();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "点击查询")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form12 f = new Form12();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "查看属性表")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form10 f = new Form10();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "SQL查询")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form16 f = new Form16();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "缓冲区查询")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form17 f = new Form17();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "存储路径")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form18 f = new Form18();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "主题配置")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form19 f = new Form19();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "图形量算")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form20 f = new Form20();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "火山口识别参数")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form21 f = new Form21();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "新建shapefile")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form22 f = new Form22();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
            if (name == "保存shapefile")
            {
                splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
                Form23 f = new Form23();//Form1为子窗口的name;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
                f.Show();
            }
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();//释放Panel2中的窗体  
            MainForm f = new MainForm();//Form1为子窗口的name;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);//在Pannel2中添加窗体 
            f.Show();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void HelpDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
