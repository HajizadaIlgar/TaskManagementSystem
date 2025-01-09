using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Entities;

namespace TaskManagement.BL.DTOs.EmployeeDTOs
{
    public class EmployeeCreateDTO
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public static implicit operator Employee(EmployeeCreateDTO dto)
        {
            Employee employee = new Employee
            {
                Name = dto.Name,
                Surname = dto.Surname,
                BirthDay = dto.BirthDay,
            };
            return employee;
        }
    }
}
