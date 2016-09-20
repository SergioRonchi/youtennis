using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.DTO.Common;

namespace YouTennis.Model.Common
{
    public class Rank
    {
        public int Value { get; set; }
        public Player Author { get; set; }
        public DateTime Time { get; set; }

        public string Description { get; set; }

        internal RankDTO CreateDTO()
        {
            RankDTO dto = new RankDTO();
            dto.Author = this.Author.Id;
            dto.Description = this.Description;
            dto.Time = this.Time;
            dto.Value = this.Value;
            return dto;
        }

        internal static Rank FromDTO(RankDTO x)
        {
            throw new NotImplementedException();
        }
    }
}
