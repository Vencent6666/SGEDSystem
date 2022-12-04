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
    public partial class TriangleForm : Form
    {
        int vertices = 0;
        int degree = 0;
        bool start = false;

        public TriangleForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txbVertices.Text) >= 0 && Convert.ToInt16(txbDegree.Text) >= 10 && Convert.ToInt16(txbDegree.Text) <= 10000)
            {
                vertices = Convert.ToInt16(txbVertices.Text);
                degree = Convert.ToInt16(txbDegree.Text);
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input a integer(1~20)");
            }
        }

        private void btnHelp_tolerance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The smaller the value, the closer the triangle.");
        }

        private void btnHelp_degree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The larger the value, the closer the triangle.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool GetStart()
        {
            return start;
        }

        public int GetVertices()
        {
            if (Convert.ToInt16(txbVertices.Text) >= 0)
                return vertices;
            else
                return 0;
        }

        public int GetDegree()
        {
            if (Convert.ToInt16(txbDegree.Text) >= 10 && Convert.ToInt16(txbDegree.Text) <= 10000)
                return degree;
            else
                return 0;
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void labTolerance_Click(object sender, EventArgs e)
        {

        }
    }
}
