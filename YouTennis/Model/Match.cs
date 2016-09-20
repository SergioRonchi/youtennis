using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.ClubHouse;

namespace YouTennis.Model
{
    public class Match
    {

        #region Properties
        public DateTime ScheduledTime { get; set; }
        public DateTime TimeOfStart { get; set; }
        public TimeSpan Duration { get; set; }
        public TournamentPlayer FirstPlayer { get; set; }
        public TournamentPlayer SecondPlayer { get; set; }

        public TournamentPlayer Winner { get; set; }

        public Score MatchScore { get;  set; }

        public Court Court { get; set; }

        public bool IsIndoor { get; set; }
        #endregion
    }
}
