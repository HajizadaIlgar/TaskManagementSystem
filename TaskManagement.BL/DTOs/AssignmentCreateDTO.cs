using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.DTOs
{
    public class AssignmentCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int EmployeeId {  get; set; }
        public int TopicId {  get; set; }
        public static implicit operator Assignment(AssignmentCreateDTO dto)
        {
            Assignment assignment = new Assignment
            {
                Title = dto.Title,
                Description = dto.Description,
                EmployeeId=dto.EmployeeId,
                TopicId=dto.TopicId
            };
            return assignment;
        }
    }
}
