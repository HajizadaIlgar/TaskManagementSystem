using AutoMapper;
using TaskManagement.BL.DTOs.EmployeeDTOs;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeListItem, Employee>().ReverseMap();
        }
    }
}
