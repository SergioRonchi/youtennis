using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;

namespace YouTennis.Model.ClubHouse
{
    public class Club: IRankable
    {
        #region Ctor
        public Club()
        {
            Rates = new List<Rate>();
            Locations = new List<Location>();
            Members = new List<Member>();
            Ranks = new List<Rank>();
        }
        #endregion

        #region Properties
        public List<Rate> Rates { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Member> Members { get; private set; }

      
        #endregion

        #region Methods

        public List<CalendarEntry> GetCalendarEntries(Court court, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }

        public List<Court> GetFreeCourts(DateTime from, int duration)
        {
            throw new NotImplementedException();
        }


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

