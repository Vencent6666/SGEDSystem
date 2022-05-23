using DotSpatial.Data;
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
    public partial class LineForm : Form
    {
        int alw = 0;
        bool start = false;
        bool show = true;
        string selected_layername = string.Empty;
        string output_filename = string.Empty;
        string output_filepath;
        
        public LineForm()
        {
            InitializeComponent();
        }

        public LineForm(List<string> filepath_list)
        {
            InitializeComponent();
            foreach (string filepath in filepath_list)
            {
                FeatureSet featureSet1 = new FeatureSet();
                featureSet1.FilePath = filepath;
                Fillcmb(featureSet1);
            }
            
        }

        private void Fillcmb(IFeatureSet featureSet)
        {
            cmbInput.Items.Add(LayerName(featureSet.Filename));
        }

        private string LayerName(string filename)
        {
            string layername=string.Empty;
            string temp = string.Empty;
            for (int i = filename.Length-1; i >= 0; i--)
            {
                if (filename[i] != '\\')
                    temp += filename[i];
                else
                    break;
            }
            for (int i = temp.Length-1; i >= 0; i--)
                layername += temp[i];
            return layername;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txbAlw.Text) >= 2 && Convert.ToInt16(txbAlw.Text) <= 255)
            {
                alw = Convert.ToInt16(txbAlw.Text);
                start = true;
                if (txboutfilename.Text != "请输入文件名" && txboutput.Text != "请选择输出目录")
                {
                    show = chbShow.Checked;
                    output_filename = txboutfilename.Text;
                    output_filepath = txboutput.Text;
                    selected_layername = cmbInput.Text;
                }
                else
                    MessageBox.Show("请输入文件名和输出路径");

                this.Close();
            }
            else
            {
                MessageBox.Show("请输入一个正整数阈值");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {           
             MessageBox.Show("霍夫变换识别直线阈值");            
        }

        public bool GetStart()
        {
            return start;
        }

        public bool GetShow()
        {
            return show;
        }

        public int GetAlw()
        {
            if (Convert.ToInt16(txbAlw.Text) >= 2 && Convert.ToInt16(txbAlw.Text) <= 255)
                return alw;
            else
                return 0;
        }

        public string GetSelected()
        {
            if (selected_layername != string.Empty)
                return selected_layername;
            else
                return null;
        }

        public string Getoutfilepath()
        {
            if (output_filepath != string.Empty)
                return output_filepath;
            else
                return null;
        }

        public string Getoutfilename()
        {
            if (output_filename != string.Empty)
                return output_filename;
            else
                return null;
        }

        private void labAlw_Click(object sender, EventArgs e)
        {

        }

        private void txbAlw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnoutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            output_filepath = fbd.SelectedPath;
            txboutput.Text = output_filepath;
        }

        private void btnHelpInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("进行识别的图层");
        }

        private void btnHelpfilename_Click(object sender, EventArgs e)
        {
            MessageBox.Show("识别结果导出文件的名称");
        }

        private void LineForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
