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
    public partial class ShapefileForm : Form
    {
        string shapeType;
        bool start = false;

        public ShapefileForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbShapefile.Text != "")
            {
                shapeType = cmbShapefile.Text;              
                this.start = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose the type of shape ");
            }
        }

        public bool GetStart()
        {
            return start;
        }

        public string GetInformation()
        {
            if (cmbShapefile.Text != "")
                return shapeType;
            else
                return null;
        }
    }
}
