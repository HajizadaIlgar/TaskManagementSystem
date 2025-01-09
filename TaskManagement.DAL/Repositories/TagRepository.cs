using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.Repositories;
using TaskManagement.CORE.Repositories;
using TaskManagement.DAL.Contexts;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL.Repositories
{
    public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(TaskManagementSystemDbContext _context):base(_context)
        {
            
        }
    }
}
