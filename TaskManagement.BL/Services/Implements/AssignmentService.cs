using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.DTOs.AssignmentDTOs;
using TaskManagement.BL.Services.Abstracts;
using TaskManagement.CORE.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Services.Implements
{
    public class AssignmentService(IAssignmentRepository _repo) : IAssignmentService
    {
        public async Task<int> CreateAsync(AssignmentCreateDTO dto)
        {
            Assignment assignment = dto;
            await _repo.AddAsync(assignment);
            await _repo.SaveAsync();
            return assignment.Id;
        }

        public async Task Delete(int id)
        {
            var data=await _repo.GetAll().Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null)
                throw new Exception();
            _repo.Delete(data);
            await _repo.SaveAsync();
        }

        public async Task<List<AssignmentListItem>> GetAllAsync()
        {
            return await _repo.GetAll().Select(x => new AssignmentListItem
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
            }).ToListAsync();
        }
    }
}
