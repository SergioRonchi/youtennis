using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.Common
{
    public abstract class BaseAction
    {
        public DateTime Time { get; set; }      
        public User Author { get; set; }
    }
}
