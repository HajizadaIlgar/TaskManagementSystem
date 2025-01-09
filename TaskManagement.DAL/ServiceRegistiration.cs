using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.BL.Repositories;
using TaskManagement.CORE.Repositories;
using TaskManagement.DAL.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL;

public static class ServiceRegistiration
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped < IGenericRepository<Assignment>,GenericRepository<Assignment>>();
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();

        return services;
    }
}
