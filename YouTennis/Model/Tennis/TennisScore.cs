using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.Tennis
{
    public class TennisScore:Score
    {
        #region Ctor
        public TennisScore()
           : base()
        {

        }
        #endregion

        public List<TennisSet> Sets { get; set; }


    }

    public class TennisSet : Score
    {
        #region Ctor
        public TennisSet()
           : base()
        {

        }
        #endregion

        public List<Score> PlayerPoints { get; set; }
        


    }
}
