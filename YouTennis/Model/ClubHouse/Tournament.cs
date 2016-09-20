using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;

namespace YouTennis.Model.ClubHouse
{
    public class Tournament: IRankable
    {
        #region Ctor
        public Tournament()
        {
            Players = new List<TournamentPlayer>();
            Matches = new List<TournamentMatch>();
            Ranks = new List<Rank>();
        }
        #endregion
        #region Properties
        public Club Club { get; set; }
        public List<TournamentPlayer> Players { get; private set; }
        public List<TournamentMatch> Matches { get; private set; } 
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfFinal { get; set; }

        public DateTime DateOfRegistrationStart { get; set; }
        public DateTime DateOfRegistrationEnd { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }
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
