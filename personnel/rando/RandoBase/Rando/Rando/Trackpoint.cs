using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rando
{
    class Trackpoint
    {
        public double latitude { get; }
        public double longitude { get; }
        public double elevation { get; }

        public Trackpoint(double lat, double lon, double ele)
        {
            latitude = lat;
            longitude = lon;
            elevation = ele;
        }
    }
}
