
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YouTennis.Model.Common;

namespace YouTennis.Model
{
    public class Player: User, IRankable
    {
       


        public Player()
        {
            Profiles = new List<PlayerProfile>();
            Pictures = new List<Picture>();
            Follows = new List<Player>();
            Follower = new List<Player>();
            Ranks = new List<Rank>();
        }
       
        public List<PlayerProfile> Profiles { get; private set; }

        public List<Picture> Pictures { get; private set; }

      

        public List<Player>Follows { get; private set; }

      
        public List<Player> Follower { get; private set; }


        #region IRankable
        public List<Rank> Ranks { get; private set; }
        public void AddRank(int rank, string description, Player player)
        {
            Rank newRank = new Rank() { Author = player, Time = DateTime.Now, Value = rank,Description=description };
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
