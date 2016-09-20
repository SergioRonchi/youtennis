using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;
using YouTennis.Model.Enums;

namespace YouTennis.Model.ClubHouse
{
    public class Court: IRankable
    {
        public Court()
        {
            Ranks = new List<Rank>();
        }
        #region Properties
        public Location Location { get; set; }
        public CourtLocation CourtLocation { get; set; }
        #endregion

        #region IRankable
        public List<Rank> Ranks { get; private set; }
        public void AddRank(int rank, string description, Player player)
        {
            Rank newRank = new Rank() { Author = player, Time = DateTime.Now, Value = rank, Description=description };
            Ranks.Add(newRank);
        }

        public double GetOverAllRank()
        {
            var r = Ranks.Average(x => x.Value);
            return r;
        }
        #endregion


    }
}
