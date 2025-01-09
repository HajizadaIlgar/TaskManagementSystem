using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using TaskManagement.CORE.Repositories;
using TaskManagement.DAL.Contexts;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL.Repositories
{
    public class TopicRepository:GenericRepository<Topic>,ITopicRepository
    {
        public TopicRepository(TaskManagementSystemDbContext _context):base(_context) 
        {
            
        }
    }
}
