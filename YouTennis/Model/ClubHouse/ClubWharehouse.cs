using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.ClubHouse
{
    public class ClubWharehouse
    {
        #region Ctor
        public ClubWharehouse()
        {
            Clubs = new List<Club>();

        }
        #endregion

        #region Properties
        public List<Club> Clubs { get; private set; }
        public List<Player> Players { get; private set; } 
        #endregion



        #region Methods

        public List<CalendarEntry> GetReservations(Player player, DateTime from, int duration)
        {
            throw new NotImplementedException();
        }
        public List<CalendarEntry> GetCalendarEntries(Court court, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }

        public List<Court> GetFreeCourts(DateTime from, int duration)
        {
            throw new NotImplementedException();
        }
        public List<Court> GetFreeCourts(Club club, DateTime from, int duration)
        {
            throw new NotImplementedException();
        }
        public List<Court> GetFreeCourts(Club club,Location location, DateTime from, int duration)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
