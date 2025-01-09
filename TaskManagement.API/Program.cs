using Microsoft.EntityFrameworkCore;
using TaskManagement.BL.Services.Abstracts;
using TaskManagement.BL.Services.Implements;
using TaskManagement.DAL;
using TaskManagement.DAL.Contexts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddService();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ITagService, TagService>();
builder.Services.AddScoped<IAssignmentService, AssignmentService>();
builder.Services.AddScoped<ITopicService, TopicService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<TaskManagementSystemDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MYSql"));
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
