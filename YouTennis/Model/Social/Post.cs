using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;

namespace YouTennis.Model.Social
{
    public class Post: Comment
    {
        public Post()
            :base()
        {
            Pictures = new List<Picture>();
        }
        public List<Picture> Pictures { get; set; }

        public List<Reaction> Reactions { get; set; }
    }
}
