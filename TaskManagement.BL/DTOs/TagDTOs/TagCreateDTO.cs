using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.DTOs.TagDTOs
{
    public class TagCreateDTO
    {
        public string Name { get; set; }
        public string Urgent { get; set; }
        public string UntilTomorrow { get; set; }
        public string ItIsNotImportant { get; set; }
        public static implicit operator Tag(TagCreateDTO dto)
        {
            Tag tag = new Tag
            {
                Name = dto.Name,
                Urgent = dto.Urgent,
                UntilTomorrow = dto.UntilTomorrow,
                ItIsNotImportant=dto.ItIsNotImportant,
            };
            return tag;
        }

    }
}
