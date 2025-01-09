using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.CORE.Repositories
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
    }
}
