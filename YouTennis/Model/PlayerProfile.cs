using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.DTO;
using YouTennis.Model.Common;

namespace YouTennis.Model
{
    public class PlayerProfile
    {
        #region Properties
        public DateTime DateOfBirth { get; set; }

        public EntityAddress Address { get; set; }

        public Picture Picture { get; set; }

        internal PlayerProfileDTO CreateDTO()
        {
            PlayerProfileDTO dto = new PlayerProfileDTO();
            dto.Address = this.Address;
            dto.DateOfBirth = this.DateOfBirth;
            dto.Picture = this.Picture!=null?this.Picture.CreateDTO():null;
            return dto;
        }

        internal static PlayerProfile FromDTO(PlayerProfileDTO x)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
