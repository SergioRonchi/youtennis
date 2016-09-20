using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model
{
    public class Team: Player
    {
        #region Ctor
        public Team()
        {
            Members = new List<Player>();
        }
        #endregion


        #region Properties
        public List<Player> Members { get; private set; } 
        #endregion
    }
}
