using Aspose.Gis;
using Aspose.Gis.Geometries;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Rando
{
    public partial class Rando : Form
    {
        private List<Trackpoint> _trackpoints = new List<Trackpoint>();
        private Color[] gradient = new Color[] {
            Color.FromArgb(255, 144, 238, 144), // Vert clair
            Color.FromArgb(255, 162, 216, 128),
            Color.FromArgb(255, 180, 194, 112),
            Color.FromArgb(255, 198, 172, 96),
            Color.FromArgb(255, 216, 150, 80),
            Color.FromArgb(255, 234, 128, 64),
            Color.FromArgb(255, 244, 106, 48),
            Color.FromArgb(255, 248,  84, 36),
            Color.FromArgb(255, 252,  62, 24),
            Color.FromArgb(255, 254,  48, 18),
            Color.FromArgb(255, 255,  32, 12),
            Color.FromArgb(255, 255,  16,  6),
            Color.FromArgb(255, 255,   0,  0)  // Rouge vif
        };
        public Rando()
        {
            InitializeComponent();
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red,2);

            ReadGpx("C:\\Users\\pe41bnd\\Documents\\GitHub\\323-Programmation_fonctionnelle\\personnel\\rando\\gpx\\Ballade_châtaignère_🌰.gpx");

            List<(Color color, System.Drawing.Point point)> points = ConvertToPoints(_trackpoints, this.ClientSize);


            points.Zip(points.Skip(1),(p1,p2 ) =>
            {
                myPen.Color = p1.color;
                e.Graphics.DrawLine(myPen, p1.point,p2.point);
                return 0;
            }).ToList();
        }


        public void ReadGpx(string filePath)
        {
            var layer = Drivers.Gpx.OpenLayer(filePath);
            Debug.WriteLine("path : " + filePath);
            layer.ToList().ForEach(feature =>
            {
                
                if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                {
                    
                    var lines = (MultiLineString)feature.Geometry;
                    lines.ToList().ForEach(line =>
                    {
                        List<string> coordslines = line.AsText().ToString().Replace("LINESTRING Z (", "").Replace(")", "").Split(",").ToList();
                        coordslines.ForEach(coordsline => {
                            
                            List<string> coords = coordsline.ToString().Trim().Split(" ").ToList();

                            double lat = double.Parse(coords.First().ToString());
                            double lon = double.Parse(coords.Skip(1).First().ToString());
                            double ele = double.Parse(coords.Last().ToString());
                            _trackpoints.Add(new Trackpoint(lat, lon,ele));
                        });

                    });
                }
            });
        }

        private List<(Color color, System.Drawing.Point point)> ConvertToPoints(List<Trackpoint> trackpoints, Size size)
        {
            double minLat = trackpoints.Min(tp => tp.latitude);
            double maxLat = trackpoints.Max(tp => tp.latitude);
            double minLon = trackpoints.Min(tp => tp.longitude);
            double maxLon = trackpoints.Max(tp => tp.longitude);
            double minEle = trackpoints.Min(tp => tp.elevation);
            double maxEle = trackpoints.Max(tp => tp.elevation);

            double scaleX = size.Width / (maxLon - minLon);
            double scaleY = size.Height / (maxLat - minLat);
            int heightDiff = Convert.ToInt32(maxEle - minEle);

            double scale = Math.Min(scaleX, scaleY);

            List<(Color color, System.Drawing.Point point)> points = new List<(Color color, System.Drawing.Point point)>();

            trackpoints.ForEach(tp =>
            {
                int x = (int)((tp.longitude - minLon) * scale);
                int y = (int)((maxLat - tp.latitude) * scale); 
                int idx;
                if (Convert.ToInt32(tp.elevation / heightDiff) > gradient.Length-1)
                    idx = gradient.Length-1;
                else if (Convert.ToInt32(tp.elevation / heightDiff) < 0)
                    idx = 0;
                else
                    idx = Convert.ToInt32(tp.elevation / heightDiff);
                    points.Add((color: gradient[idx], point: new System.Drawing.Point(x, y)));
                Debug.WriteLine(heightDiff+", "+Convert.ToInt32(tp.elevation / heightDiff));
            });
            return points;
        }
    }
}
