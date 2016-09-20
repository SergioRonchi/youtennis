using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.DTO.Common;

namespace YouTennis.Model.Common
{
    public class Picture
    {
        #region DTO Methods
        internal PictureDTO CreateDTO()
        {
            PictureDTO dto = new PictureDTO();

            dto.Content = this.Content;
            dto.Description = this.Description;
            foreach (var item in this.Comments)
            {
                dto.Comments.Add(item.CreateDTO());
            }
            foreach (var item in this.Tags)
            {
                dto.Tags.Add(item.Id);
            }
            return dto;

        }

        internal static Picture FromDTO(PictureDTO dto)
        {
            Picture item = new Picture();
            item.Content = dto.Content;
            item.Description = dto.Description;
            foreach (var x in dto.Comments)
            {
                item.Comments.Add(Comment.FromDTO(x));
            }
            foreach (var x in dto.Tags)
            {
                item.Tags.Add(item.Id);
            }
            return item;

        }
        #endregion

        #region Ctor
        public Picture()
        {
            Tags = new List<Player>();
            Comments = new List<Comment>();
        }
        #endregion

        #region Properties
        public Image Content { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; private set; }
        public List<Player> Tags { get; private set; }

       
        #endregion

    }
}
