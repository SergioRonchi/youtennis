using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.ClubHouse
{
    public class TournamentMatch:Match
    {
        public TournamentMatch()
            :base()
        {

        }
        /// <summary>
        /// Gets/Sets the round        
        /// </summary>
        /// <remarks>
        ///  64 means R64 (64 players remaining)
        ///  32 means R32 (32 players remaining)
        ///  16 means R16 (16 players remaining)
        ///   8 means Q (Quarterfinal)
        ///   4 means S (Semifinal)
        ///   2 means F (Final)
        /// </remarks>
        public int Round { get; set; }

        public int WinnerRankingPoints { get; set; }
        public int LooserRankingPoints { get; set; }

        public TournamentMatch NextMatch { get; set; }

        public TournamentMatch PreviousMatch_A { get; set; }
        public TournamentMatch PreviousMatch_B { get; set; }
    }
}
