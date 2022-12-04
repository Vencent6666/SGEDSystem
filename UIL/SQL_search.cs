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
    public partial class SQL_search : Form
    {
        string sql = "";
        bool start = false;
        public SQL_search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void sql_button_Click(object sender, EventArgs e)
        {
            if(Convert.ToString(sqltext.Text) != "")
            {
                sql = Convert.ToString(sqltext.Text);
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入目标要素的属性信息");
            }
        }

        public bool GetStart()
        {
            return start;
        }

        public string GetInformation()
        {
            if(Convert.ToString(sqltext.Text) != "")
                return sql;
            else
                return "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
