using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map4_0
{
    public partial class CircleForm : Form
    {
        int alw=0;
        bool start=false;

        public CircleForm()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The larger the value, the closer the circle.");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txbAlw.Text)>=2 && Convert.ToInt16(txbAlw.Text)<=20)
            {
                alw = Convert.ToInt16(txbAlw.Text);
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input a integer(1~20)");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool GetStart()
        {
            return start;
        }

        public int GetInformation()
        {
            if (Convert.ToInt16(txbAlw.Text) >= 2 && Convert.ToInt16(txbAlw.Text) <= 20)
                return alw;
            else
                return 0;
        }

        private void labAlw_Click(object sender, EventArgs e)
        {

        }
    }
}
