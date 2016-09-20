using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.DTO.Common;

namespace YouTennis.Model.Common
{
    public class Comment: BaseAction
    {
        #region Ctor
        public Comment()
            :base()
        {
            Replies = new List<Comment>();
        }
        #endregion

        #region Properties

        public string Text { get; set; }


        public List<Comment> Replies { get; private set; }

        internal CommentDTO CreateDTO()
        {
            CommentDTO dto = new CommentDTO();
            dto.Author = this.Author.Id;
            
            dto.Text = this.Text;
            dto.Time = this.Time;
            
            foreach (var item in this.Replies)
            {
                dto.Replies.Add(item.CreateDTO());
            }
            return dto;
        }

        internal static Comment FromDTO(CommentDTO dto)
        {
            Comment item = new Comment();
            item.Author = dto.Author;
            item.Text = dto.Text;
            item.Time = dto.Time;
            foreach (var x in dto.Replies)
            {
                item.Replies.Add(Comment.FromDTO(x));
            }
           
            return item;
        }
        #endregion
    }
}
