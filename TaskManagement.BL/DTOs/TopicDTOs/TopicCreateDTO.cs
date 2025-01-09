using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.DTOs.TopicDTOs
{
    public class TopicCreateDTO
    {
        public string Name { get; set; }
        public int AssignmentId { get; set; }
        public static implicit operator Topic(TopicCreateDTO dto)
        {
            Topic topic = new Topic
            {
                Name = dto.Name,
                AssignmentId = dto.AssignmentId
            };
            return topic;
        }
    }
}
