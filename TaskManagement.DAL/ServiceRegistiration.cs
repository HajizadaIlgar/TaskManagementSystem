using Microsoft.Extensions.DependencyInjection;
using TaskManagement.BL.Repositories;
using TaskManagement.CORE.Repositories;
using TaskManagement.DAL.Repositories;
using TaskManagementSystem.Entities;

namespace TaskManagement.DAL;

public static class ServiceRegistiration
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Assignment>, GenericRepository<Assignment>>();
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();

        services.AddScoped<IGenericRepository<Topic>, GenericRepository<Topic>>();
        services.AddScoped<ITopicRepository, TopicRepository>();

        services.AddScoped<IGenericRepository<Tag>, GenericRepository<Tag>>();
        services.AddScoped<ITagRepository, TagRepository>();

        services.AddScoped<IGenericRepository<Employee>, GenericRepository<Employee>>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
}
