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
    public partial class Line_hcSearch : Form
    {
        int ID;
        double Range;
        bool start = false;

        public Line_hcSearch()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Int32 GetID()
        {
            if (Convert.ToInt32(searchID.Text) >= 0)
                return Convert.ToInt32(searchID.Text);
            else
                return -1;
        }

        public double GetRange()
        {
            if (Convert.ToDouble(searchRange.Text) >= 0)
                return Convert.ToDouble(searchRange.Text);
            else
                return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( 0 <= Convert.ToInt32(searchID.Text) & Convert.ToDouble(searchRange.Text) >= 0)
            {
                ID = Convert.ToInt32(searchID.Text);
                Range = Convert.ToDouble(searchRange.Text);
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("请按要求输入数据");
            }
        }

        public bool GetStart()
        {
            return start;
        }
    }
}
