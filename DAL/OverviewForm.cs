using DotSpatial.Controls;
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
    public partial class OverviewForm : Form
    {
        public OverviewForm()
        {
            InitializeComponent();
        }

        public void Overview_nowlayer(FeatureSet featureSet1)
        {
            Overviewmap.Layers.Add(featureSet1);
            //Overviewmap.ZoomToMaxExtent();
        }

        public void Overview_Addfile(string filepath)
        {
            Overviewmap.AddLayer(filepath);
            Overviewmap.ZoomToMaxExtent();
        }
    }
}
