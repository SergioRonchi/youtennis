using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.ClubHouse
{
    public class TournamentPlayer
    {
        #region Properties
        /// <summary>
        /// Gets/Sets the seeding number: -1 means no Seeded
        /// </summary>
        public int Seed { get; set; }
        public Player Player { get; set; } 
        #endregion
    }
}
