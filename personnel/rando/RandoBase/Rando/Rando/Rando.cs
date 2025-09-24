using Aspose.Gis;
using Aspose.Gis.Geometries;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Rando
{
    public partial class Rando : Form
    {
        private List<Trackpoint> _trackpoints = new List<Trackpoint>();
        public Rando()
        {
            InitializeComponent();
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            ReadGpx("C:\\Users\\pe41bnd\\Documents\\GitHub\\323-Programmation_fonctionnelle\\personnel\\rando\\gpx\\Ballade_châtaignère_🌰.gpx");
            
            System.Drawing.Point[] points = new System.Drawing.Point[4] { new System.Drawing.Point(30, 50), new System.Drawing.Point(50, 10), new System.Drawing.Point(80, 50), new System.Drawing.Point(111, 400) };
            this.CreateGraphics().DrawLines(myPen, points);
        }


        public void ReadGpx(string filePath)
        {
            // This code example demonstrates how to read waypoints from GPX file
            // Load the GPX file
            var layer = Drivers.Gpx.OpenLayer(filePath);
            Debug.WriteLine("path : " + filePath);
            layer.ToList().ForEach(feature =>
            {
                Debug.WriteLine("douce : " + feature.Geometry.GeometryType);
                // Check for Point geometry
                if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                {
                    Debug.WriteLine("dedant : " + feature.ToString());
                    // Read Points
                    var lines = (MultiLineString)feature.Geometry;
                    lines.ToList().ForEach(line =>
                    {
                        List<string> coordoneeslines = line.AsText().ToString().Replace("LINESTRING Z (", "").Replace(")", "").Split(",").ToList();
                        coordoneeslines.ForEach(coordoneesline => {
                            
                            List<string> coords = coordoneesline.ToString().Trim().Split(" ").ToList();


                            double lag = double.Parse(coords.First().ToString());
                            double lon = double.Parse(coords.Skip(1).First().ToString());
                            double ele = double.Parse(coords.Last().ToString());
                            Debug.WriteLine("lag : " + lag);
                            Debug.WriteLine("lon : " + lon);
                            Debug.WriteLine("ele : " + ele);
                            _trackpoints.Add(new Trackpoint(lag,lon,ele));
                        });

                    });
                }
            });
        }

    }
}
