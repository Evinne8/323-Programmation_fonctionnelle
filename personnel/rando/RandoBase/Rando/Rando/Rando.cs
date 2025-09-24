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
            Pen myPen = new Pen(Color.Red,2);

            ReadGpx("C:\\Users\\pe41bnd\\Documents\\GitHub\\323-Programmation_fonctionnelle\\personnel\\rando\\gpx\\Ballade_châtaignère_🌰.gpx");

            var points = ConvertToPoints(_trackpoints, this.ClientSize);

            this.CreateGraphics().DrawLines(myPen, points.ToArray());
        }


        public void ReadGpx(string filePath)
        {
            var layer = Drivers.Gpx.OpenLayer(filePath);
            Debug.WriteLine("path : " + filePath);
            layer.ToList().ForEach(feature =>
            {
                Debug.WriteLine("douce : " + feature.Geometry.GeometryType);
                
                if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                {
                    Debug.WriteLine("dedant : " + feature.ToString());
                    
                    var lines = (MultiLineString)feature.Geometry;
                    lines.ToList().ForEach(line =>
                    {
                        List<string> coordslines = line.AsText().ToString().Replace("LINESTRING Z (", "").Replace(")", "").Split(",").ToList();
                        coordslines.ForEach(coordsline => {
                            
                            List<string> coords = coordsline.ToString().Trim().Split(" ").ToList();


                            double lat = double.Parse(coords.First().ToString());
                            double lon = double.Parse(coords.Skip(1).First().ToString());
                            double ele = double.Parse(coords.Last().ToString());
                            Debug.WriteLine("lag : " + lat);
                            Debug.WriteLine("lon : " + lon);
                            Debug.WriteLine("ele : " + ele);
                            _trackpoints.Add(new Trackpoint(lat, lon,ele));
                        });

                    });
                }
            });
        }

        private List<System.Drawing.Point> ConvertToPoints(List<Trackpoint> trackpoints, Size size)
        {
            double minLat = trackpoints.Min(tp => tp.latitude);
            double maxLat = trackpoints.Max(tp => tp.latitude);
            double minLon = trackpoints.Min(tp => tp.longitude);
            double maxLon = trackpoints.Max(tp => tp.longitude);

            double scaleX = size.Width / (maxLon - minLon);
            double scaleY = size.Height / (maxLat - minLat);


            double scale = Math.Min(scaleX, scaleY);

            List<System.Drawing.Point> points = new List<System.Drawing.Point>();
            trackpoints.ForEach(tp =>
            {
                int x = (int)((tp.longitude - minLon) * scale);
                int y = (int)((maxLat - tp.latitude) * scale); // inverser Y pour que le Nord soit en haut
                points.Add(new System.Drawing.Point(x, y));

            });

            return points;
        }
    }
}
