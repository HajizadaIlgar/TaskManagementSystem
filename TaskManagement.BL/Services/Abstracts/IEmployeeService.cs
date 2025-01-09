using TaskManagement.BL.DTOs.EmployeeDTOs;

namespace TaskManagement.BL.Services.Abstracts
{
    public interface IEmployeeService
    {
        Task<List<EmployeeListItem>> GetAllAsync();
        Task<int> CreateAsync(EmployeeCreateDTO dto);
        Task Delete(int id);
    }
}
