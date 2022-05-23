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


namespace SGEDSystem //special geographical entity distinguish system
{
    public partial class Form1 : Form
    {
        
        string Filepath = string.Empty;
        string shapeType;
        #region Point ShapeFile class level variable

        //the new point feature set
        FeatureSet pointF = new FeatureSet(FeatureType.Point);

        //the id of point
        int pointID = 0;

        //to differentiate the right and left mouse click
        bool pointmouseClick = false;

        #endregion

        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF = new FeatureSet(FeatureType.Line);

        int lineID = 0;

        //boolean variable for first time mouse click
        bool firstClick = false;

        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;

        #endregion

        #region Polygon ShapeFile class level variables

        FeatureSet polygonF = new FeatureSet(FeatureType.Polygon);

        int polygonID = 0;

        bool polygonmouseClick = false;

        #endregion

        #region line0  ShapeFile class level variables

        MapLineLayer lineLayer0 = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF0 = new FeatureSet(FeatureType.Line);

        int lineID0 = 0;

        #endregion

        

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddLayer() method is used to add a shape file in the MapControl.
            //FeatureSet featureSet1 = new FeatureSet();
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Shapefiles|*.shp";
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    //add layer to first map
            //    FeatureSet.Open(fileDialog.FileName);
            //    featureSet1.FilePath = fileDialog.FileName;

            //    //set the projection
            //    //featureSet1.Reproject(Map1.Projection);
            //    Map1.Layers.Add(featureSet1);
            //    MessageBox.Show("加载成功");

            //}
            //Map1.AddLayer();
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Shapefiles (*.shp)|*.shp|所有文件 (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获取指定文件的路径
                    Filepath = openFileDialog.FileName;
                }
            }
            Map1.AddLayer(Filepath);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear() method is used to clear the layers from the map control.
            Map1.Layers.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm with users that  they are ready to close application or not with the help of message box.
            if (MessageBox.Show("Do you want to close this application?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Close() method is used to close the application.
                this.Close();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomOut();
        }

        private void zoomExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomToMaxExtent();
        }

        private void Map1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if ((pointmouseClick))
                        {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            Coordinate coord = Map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);

                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);

                            //increase the point id
                            pointID = pointID + 1;

                            //set the ID attribute
                            currentFeature.DataRow["ID"] = pointID;

                            //refresh the map
                            Map1.ResetBuffer();
                        }
                    }
                    else
                    {
                        //mouse right click
                        Map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "line":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        Coordinate coord = Map1.PixelToProj(e.Location);
                        if (linemouseClick)
                         {
                            if (firstClick)
                            {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                List<Coordinate> lineArray = new List<Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF.AddFeature(lineGeometry);
                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(coord);
                                //set the line feature attribute
                                lineID = lineID + 1;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 2)
                                {
                                    lineF.InitializeVertices();   //初始化顶点
                                    Map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                        Map1.ResetBuffer();
                    }
                    break;

                case "Polygon":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        Coordinate coord = Map1.PixelToProj(e.Location);
                        if (polygonmouseClick)
                        {
                            if (firstClick)
                            {
                                //Create a new List called polygonArray.

                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.

                                List<Coordinate> polygonArray = new List<Coordinate>();

                                //Create an instance for LinearRing class.
                                //We pass the polygon List to the constructor of this class
                                LinearRing polygonGeometry = new LinearRing(polygonArray);

                                //Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);

                                // add first coordinate to the polygon feature
                                polygonFeature.Coordinates.Add(coord);

                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 3)
                                {
                                    //refresh the map
                                    polygonF.InitializeVertices();
                                    Map1.ResetBuffer();
                                }

                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                    }
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By No.7 group");
        }

        private void Map1_GeoMouseMove(object sender, GeoMouseArgs e)
        {
            string locStr = "X:" + e.GeographicLocation.X.ToString("F2") +

                ", Y:" + e.GeographicLocation.Y.ToString("F2");

            toolStripStatusLabelXY.Text = locStr;

            //statusBar1.Width = this.Width - statusBarBlocker2.Width - 100;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TriangleForm f4 = new TriangleForm();
            f4.ShowDialog();
            if (f4.GetStart())
            {
                if (Map1.Layers[0] is MapLineLayer)
                {
                    MapLineLayer ContourlineLayer = default(MapLineLayer);
                    ContourlineLayer = (MapLineLayer)Map1.Layers[0];
                    IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                    LineScheme scheme = new LineScheme();

                    for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                    {
                        IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                        var box = pi.Envelope;
                        double xmin = box.X, xmax = box.X + box.Width;
                        double ymax = box.Y, ymin = box.Y - box.Height;
                        List<Coordinate> Coords = pi.Coordinates.ToList();
                        //FeatureSet point=new FeatureSet();
                        Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                        {
                            DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                            //IFeature currentFeature = point.AddFeature(Point);
                            //currentFeature.DataRow["ID"] = j;
                            //currentFeature.DataRow["SourceLayer"] = i;
                        });

                        if (Shapes.Triangle(Coords, xmin, xmax, ymin, ymax,f4.GetVertices(),f4.GetDegree()))
                        {
                            String s = Convert.ToString(pi.DataRow.ItemArray[0]);
                            ContourlineLayer.DataSet.FillAttributes();
                            LineCategory category = new LineCategory(Color.Red, 5);
                            string filter = "[ID] =" + s;
                            category.FilterExpression = filter;
                            category.LegendText = filter;
                            scheme.AddCategory(category);

                        }
                    }

                    ContourlineLayer.Symbology = scheme;
                }
            }
            
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleForm f2 = new CircleForm();
            f2.ShowDialog();
            if(f2.GetStart())
            {
                if (Map1.Layers[0] is MapLineLayer)
                {
                    MapLineLayer ContourlineLayer = default(MapLineLayer);
                    ContourlineLayer = (MapLineLayer)Map1.Layers[0];
                    IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                    LineScheme scheme = new LineScheme();

                    for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                    {
                        IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                        var box = pi.Envelope;
                        double xmin = box.X, xmax = box.X + box.Width;
                        double ymax = box.Y, ymin = box.Y - box.Height;
                        List<Coordinate> Coords = pi.Coordinates.ToList();
                        //FeatureSet point=new FeatureSet();
                        Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                        {
                            DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                            //IFeature currentFeature = point.AddFeature(Point);
                            //currentFeature.DataRow["ID"] = j;
                            //currentFeature.DataRow["SourceLayer"] = i;
                        });

                        if (Shapes.Circles(Coords, xmin, xmax, ymin, ymax, Convert.ToInt16(f2.GetInformation())))
                        {
                            String s = Convert.ToString(pi.DataRow.ItemArray[0]);
                            ContourlineLayer.DataSet.FillAttributes();
                            LineCategory category = new LineCategory(Color.Red, 5);
                            string filter = "[ID] =" + s;
                            category.FilterExpression = filter;
                            category.LegendText = filter;
                            scheme.AddCategory(category);

                        }
                    }

                    ContourlineLayer.Symbology = scheme;
                }
            }
            
            
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineForm f3 = new LineForm();
            f3.ShowDialog();
            if (f3.GetStart())
            {
                if (Map1.Layers[0] is MapLineLayer)
                {
                    MapLineLayer ContourlineLayer = default(MapLineLayer);
                    ContourlineLayer = (MapLineLayer)Map1.Layers[0];
                    IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                                                                   //LineScheme scheme = new LineScheme();
                    
                    List<Line> lines = new List<Line>();

                    //set projection
                    lineF0.Projection = Map1.Projection;

                    //initialize the featureSet attribute table
                    DataColumn column = new DataColumn("LineID");

                    if (!lineF0.DataTable.Columns.Contains("LineID"))
                    {
                        lineF0.DataTable.Columns.Add(column);
                    }

                    //add the featureSet as map layer
                    lineLayer0 = (MapLineLayer)Map1.Layers.Add(lineF0);

                    //Set the symbolizer to the line feature.
                    LineSymbolizer symbol = new LineSymbolizer(Color.Red, 2);
                    lineLayer0.Symbolizer = symbol;
                    lineLayer0.LegendText = "line";

                    int line = 0;

                    for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                    {
                        IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                        List<Coordinate> Coords = pi.Coordinates.ToList();
                        //IFeatureSet point=new FeatureSet();
                        Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                        {
                            DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                            //IFeature currentFeature = point.AddFeature(Point);
                            //currentFeature.DataRow["ID"] = j;
                            //currentFeature.DataRow["SourceLayer"] = i;
                        });

                        lines = Shapes.Line(Coords, Convert.ToInt16(f3.GetInformation()));
                        if (CreateLine(lines))
                            line++;
                    }
                    if (line > 0)
                        MessageBox.Show("There are some lines in this layer");
                    else
                        MessageBox.Show("There aren't line in this layer");
                }
            }
            

        }

        private bool CreateLine(List<Line> lines)
        {
            if (lines.Count != 0)   //创建线要素
            {

                for (int i = 0; i < lines.Count; i++)   //每条线
                {
                    for (int k = 0; k < lines[i].NumPoints; k++)   //每条线的点
                    {
                        if (k == 0)
                        {
                            //Create a new List called lineArray.                          
                            //This list will store the Coordinates
                            //We are going to store the mouse click coordinates into this array.
                            List<Coordinate> lineArray = new List<Coordinate>();

                            //Create an instance for LineString class.
                            //We need to pass collection of list coordinates
                            LineString lineGeometry = new LineString(lineArray);

                            //Add the linegeometry to line feature
                            IFeature lineFeature = lineF0.AddFeature(lineGeometry);
                            //add first coordinate to the line feature
                            lineFeature.Coordinates.Add(lines[i].Points[k]);

                            //set the line feature attribute
                            lineID0 = lineID0 + 1;
                            lineFeature.DataRow["LineID"] = lineID0;
                        }
                        else
                        {
                            //second or more clicks - add points to the existing feature
                            IFeature existingFeature = lineF0.Features[lineF0.Features.Count - 1];
                            existingFeature.Coordinates.Add(lines[i].Points[k]);
                        }
                    }
                }
                return true;
            }
            else
                return false;
        }

        private void toolStripButtonDeselect_Click(object sender, EventArgs e)
        {
            Map1.ClearSelection();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Map1.Layers.Clear();
        }

        private void toolStripButtonNewShape_Click(object sender, EventArgs e)
        {
            ShapefileForm f1 = new ShapefileForm();
            f1.ShowDialog();
            if (f1.GetStart())
            {
                switch (f1.GetInformation())
                {
                    case "Point": CreatePoint(); break;
                    case "Polyline": CreatePolyline(); break;
                    case "Polygon": CreatePolygon(); break;
                    default:  break;
                }
            }
        }

        private bool CreatePolygon()
        {
            //initialize polyline feature set
            Map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "Polygon";

            //set projection
            polygonF.Projection = Map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");

            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }
            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)Map1.Layers.Add(polygonF);

            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);

            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "Polygon";

            firstClick = true;

            polygonmouseClick = true;
            return true;
        }

        private bool CreatePolyline()
        {
            //Change the mouse cursor
            Map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "line";

            //set projection
            lineF.Projection = Map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)Map1.Layers.Add(lineF);

            //Set the symbolizer to the line feature.
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;

            linemouseClick = true;
            return true;
        }

        private bool CreatePoint()
        {
            //Change the cursor style
            Map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = Map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)Map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;
            return true;
        }

        private void toolStripButtonSaveShape_Click(object sender, EventArgs e)
        {
                switch (shapeType)
                {
                    case "Point":
                        pointF.SaveAs("Point.shp", true);
                        MessageBox.Show("The point shapefile has been saved.");
                        break;
                    case "Polyline":
                        lineF.SaveAs("Polyline.shp", true);
                        MessageBox.Show("The line shapefile has been saved.");
                        linemouseClick = false;
                        break;
                    case "Polygon":
                        polygonF.SaveAs("polygon.shp", true);
                        MessageBox.Show("The polygon shapefile first has been saved");
                        polygonmouseClick = false;
                        break;
                    default: break;
                }
                Map1.Cursor = Cursors.Arrow;   
        }

        private void AearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            
        }

        private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void OverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverviewForm f1 = new OverviewForm();
            f1.Overview_Addfile(Filepath);
            f1.Show();
        }

        private void SphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> areas = new List<double>();
            AreaStrategy strategy = new SphereArea();
            Area area = new Area(strategy);

            if (Map1.Layers[0] is MapPolygonLayer)
            {
                MapPolygonLayer ContourlineLayer = default(MapPolygonLayer);
                ContourlineLayer = (MapPolygonLayer)Map1.Layers[0];
                IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                List<Line> lines = new List<Line>();

                for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                {
                    IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                    List<Coordinate> Coords = pi.Coordinates.ToList();
                    Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                    {
                        DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                    });
                    lines.Add(new Line(j + 1, Coords));
                }
                areas = area.Polygon(lines);

                double s = 0;
                foreach (double area1 in areas)
                    s += area1;
                MessageBox.Show(Convert.ToString(s) + " ; ");
            }
        }

        private void PlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> areas = new List<double>();
            AreaStrategy strategy = new PlaneArea();
            Area area = new Area(strategy);

            if (Map1.Layers[0] is MapPolygonLayer)
            {
                MapPolygonLayer ContourlineLayer = default(MapPolygonLayer);
                ContourlineLayer = (MapPolygonLayer)Map1.Layers[0];
                IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                List<Line> lines = new List<Line>();

                for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                {
                    IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                    List<Coordinate> Coords = pi.Coordinates.ToList();
                    Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                    {
                        DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                    });
                    lines.Add(new Line(Coords.Count, Coords));
                }
                areas = area.Polygon(lines);
                
                double s = 0;
                foreach (double area1 in areas)
                    s += area1;
                MessageBox.Show(Convert.ToString(s) + " ; ");
            }
        }
    }
}
