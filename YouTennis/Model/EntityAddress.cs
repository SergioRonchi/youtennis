using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model
{
    public class EntityAddress
    {
        public CivicAddress Address { get; set; }
      
        public GeoCoordinate Coordinate { get; set; }

   }
}
