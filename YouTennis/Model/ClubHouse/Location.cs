using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.ClubHouse
{
    public class Location
    {
        #region Ctor
        public Location()
        {
            Courts = new List<Court>();
        }
        #endregion
        #region Properties
        public EntityAddress Address { get; set; }

        public Club Club { get; set; }
        public List<Court> Courts { get; private set; } 
        #endregion
    }
}
