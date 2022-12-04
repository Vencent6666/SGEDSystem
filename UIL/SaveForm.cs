using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map4._0
{
    public partial class SaveForm : Form
    {
        private string filePath= string.Empty;
        private bool start=false;

        public SaveForm()
        {
            InitializeComponent();
        }

        private void Eixtbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "shp files (*.shp)|*.shp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获取指定文件的路径
                    filePath = openFileDialog.FileName;

                }
            }
            txbOut.Text += filePath;
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (filePath!= string.Empty)
            {              
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input a filepath");
            }
        }

        public string GetFilePath()
        {
            return filePath;
        }


    }
}
