using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.DTOs.AssignmentDTOs;

namespace TaskManagement.BL.Services.Abstracts
{
    public interface IAssignmentService
    {
        Task<List<AssignmentListItem>> GetAllAsync();
        Task<int> CreateAsync(AssignmentCreateDTO dto);
        Task Delete(int id);
    }
}
