using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskManagement.BL.DTOs.EmployeeDTOs;
using TaskManagement.BL.Services.Abstracts;
using TaskManagement.CORE.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Services.Implements
{
    public class EmployeeService(IEmployeeRepository _repo, IMapper _mapper) : IEmployeeService
    {
        public async Task<int> CreateAsync(EmployeeCreateDTO dto)
        {
            Employee employee = dto;
            await _repo.AddAsync(dto);
            await _repo.SaveAsync();
            return employee.Id;
        }
        public async Task Delete(int id)
        {
            var data = await _repo.GetAll().Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null)
                throw new Exception();
            _repo.Delete(data);
            await _repo.SaveAsync();
        }
        public async Task<List<EmployeeListItem>> GetAllAsync()
        {
            return await _repo.GetAll().Select(y => new EmployeeListItem
            {
                Id = y.Id,
                Name = y.Name,
                Surname = y.Surname,
                BirthDay = y.BirthDay,
            }).ToListAsync();
        }
    }
}
