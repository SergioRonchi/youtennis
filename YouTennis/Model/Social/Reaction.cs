using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;

namespace YouTennis.Model.Social
{
    public class Reaction: BaseAction
    {
        public Reaction()
            :base()
        {

        }
        public ReactionType MyProperty { get; set; }
    }
}
