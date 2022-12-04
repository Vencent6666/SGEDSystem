using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDSystem
{
    public partial class ConfigureForm : Form
    {
        public bool sblj_start = false;
        public string sblj_filepath = "";
        public bool zjlj_start = false;
        public string zjlj_filepath = "";
        public bool xjlj_start = false;
        public string xjlj_filepath = "";
        private double Th1 = 0;
        private double Th2 = 0;
        private double Th3 = 0;
        private double Th4 = 0;
        //private int Th5 = 0;
        private int Th6 = 0;
        private string theme = string.Empty;

        public ConfigureForm(double Th1, double Th2, double Th3, double Th4, int Th6)
        {
            InitializeComponent();
            this.listBox1.Items.Add("Silver");
            this.listBox1.Items.Add("DeepOrange");
            this.listBox1.Items.Add("DeepGreen");
            this.listBox1.Items.Add("DeepCyan");
            this.listBox1.Items.Add("Page");
            this.listBox1.Items.Add("PageColor1");
            this.listBox1.Items.Add("PageColor2");
            this.listBox1.Items.Add("SportsBlack");
            this.listBox1.Items.Add("SportsBlue");
            txbTh1.Text = Convert.ToString(Th1);
            txbTh2.Text = Convert.ToString(Th2);
            txbTh3.Text = Convert.ToString(Th3);
            txbTh4.Text = Convert.ToString(Th4);
            //txbTh5.Text = Convert.ToString(Th5);
            txbTh6.Text = Convert.ToString(Th6);

            this.Th1 = Th1;
            this.Th2 = Th2;
            this.Th3 = Th3;
            this.Th4 = Th4;
            //this.Th5 = Th5;
            this.Th6 = Th6;
        }
        

        public ConfigureForm(string theme, double Th1, double Th2, double Th3, double Th4,  int Th6)
        {
            InitializeComponent();
            this.theme = theme;
            skinEngine1.Active = true;
            skinEngine1.SkinFile = Application.StartupPath + theme;
            this.listBox1.Items.Add("Silver");
            this.listBox1.Items.Add("DeepOrange");
            this.listBox1.Items.Add("DeepGreen");
            this.listBox1.Items.Add("DeepCyan");
            this.listBox1.Items.Add("Page");
            this.listBox1.Items.Add("PageColor1");
            this.listBox1.Items.Add("PageColor2");
            this.listBox1.Items.Add("SportsBlack");
            this.listBox1.Items.Add("SportsBlue");

            txbTh1.Text = Convert.ToString(Th1);
            txbTh2.Text = Convert.ToString(Th2);
            txbTh3.Text = Convert.ToString(Th3);
            txbTh4.Text = Convert.ToString(Th4);
            //txbTh5.Text = Convert.ToString(Th5);
            txbTh6.Text = Convert.ToString(Th6);
            this.Th1 = Th1;
            this.Th2 = Th2;
            this.Th3 = Th3;
            this.Th4 = Th4;
            //this.Th5 = Th5;
            this.Th6 = Th6;
        }

        public string GetTheme()
        {
            return theme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                sblj_filepath = this.textBox2.Text;
                sblj_start = true;
                
            }
            if(this.textBox1.Text != "")
            {
                zjlj_filepath = this.textBox1.Text;
                zjlj_start = true;
                
            }
            if(this.textBox3.Text != "")
            {
                xjlj_filepath = this.textBox3.Text;
                xjlj_start = true;
                
            }
            if(this.textBox2.Text != ""|| this.textBox1.Text != ""|| this.textBox3.Text != "")
                MessageBox.Show("默认路径已修改。");

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            skinEngine1.Active = true;//激活
            //判断所有选中项集合大于0
            if (this.listBox1.SelectedItems.Count > 0)
            {
                //获取选中的值
                this.listBox1.SelectedItem.ToString();
                if (listBox1.SelectedItem.ToString() == "Page")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\Page.ssk";
                    theme = @"\Page.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "DeepOrange")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\DeepOrange.ssk";
                    theme = @"\DeepOrange.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "DeepGreen")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\DeepGreen.ssk";
                    theme = @"\DeepGreen.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "DeepCyan")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\DeepCyan.ssk";
                    theme = @"\DeepCyan.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "PageColor1")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\PageColor1.ssk";
                    theme = @"\PageColor1.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "PageColor2")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\PageColor2.ssk";
                    theme = @"\PageColor2.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "SportsBlack")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\SportsBlack.ssk";
                    theme = @"\SportsBlack.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "SportsBlue")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\SportsBlue.ssk";
                    theme = @"\SportsBlue.ssk";
                }
                else if (listBox1.SelectedItem.ToString() == "Silver")
                {
                    skinEngine1.SkinFile = Application.StartupPath + @"\Silver.ssk";
                    theme = @"\Silver.ssk.ssk";
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("未选中某一主题");
            }
        }

        private void btnResetting_Click(object sender, EventArgs e)
        {
            skinEngine1.Active = false;//关闭
            theme = string.Empty;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zjlj_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();
            if (P_File_Folder.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = P_File_Folder.SelectedPath;//选定目录后打印路径信息
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();
            if (P_File_Folder.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = P_File_Folder.SelectedPath;//选定目录后打印路径信息
            }
        }

        private void xjlj_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();
            if (P_File_Folder.ShowDialog() == DialogResult.OK)
            {
                this.textBox3.Text = P_File_Folder.SelectedPath;//选定目录后打印路径信息
            }
        }

        public bool GetzjljStart()
        {
            return zjlj_start;
        }

        public bool GetxjljStart()
        {
            return xjlj_start;
        }

        public bool GetsbljStart()
        {
            return sblj_start;
        }

        public String GetzjljInformation()
        {
            if(this.textBox1.Text != "")
            {
                return zjlj_filepath;
            }
            else
            {
                return "请选择输出目录";
            }
        }

        public String GetsbljInformation()
        {
            if (this.textBox2.Text != "")
            {
                return sblj_filepath;
            }
            else
            {
                return "请选择输出目录";
            }
        }

        public String GetxjljInformation()
        {
            if (this.textBox3.Text != "")
            {
                return xjlj_filepath;
            }
            else
            {
                return "请选择输出目录";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            this.Th1 = Convert.ToDouble(txbTh1.Text);
            this.Th2 = Convert.ToDouble(txbTh2.Text);
            this.Th3 = Convert.ToDouble(txbTh3.Text);
            this.Th4 = Convert.ToDouble(txbTh4.Text);
            //this.Th5 = Convert.ToInt16(txbTh5.Text);
            this.Th6 = Convert.ToInt16(txbTh6.Text);
            MessageBox.Show("默认识别距离已修改");
            this.Close();
        }

        public double GetTh1()
        {
            return Th1;
        }

        public double GetTh2()
        {
            return Th2;
        }

        public double GetTh3()
        {
            return Th3;
        }

        public double GetTh4()
        {
            return Th4;
        }

        //public int GetTh5()
        //{
        //    return Th5;
        //}

        public int GetTh6()
        {
            return Th6;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnResetting2_Click(object sender, EventArgs e)
        {

        }
    }
}
