using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.Common
{
    public interface IRankable
    {
        /// <summary>
        /// Adds a rank value
        /// </summary>
        /// <param name="rank"></param>
        void AddRank(int rank,string description, Player player);
        /// <summary>
        /// gets the over alla rank
        /// </summary>
        double GetOverAllRank();

        List<Rank> Ranks { get; }
    }
}
