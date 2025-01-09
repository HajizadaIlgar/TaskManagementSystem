using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.CORE.Repositories;
using TaskManagement.DAL.Contexts;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL.Repositories
{
    public class AssignmentRepository:GenericRepository<Assignment>,IAssignmentRepository
    {
        public AssignmentRepository(TaskManagementSystemDbContext _context):base(_context)
        {
            
        }
    }
}
