using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocationProject
{
    class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }

        public TacoBell(string name, double lat, double longitude)
        {
            Name = name;
            Location = new Point(lat, longitude);
        }

    }
}
