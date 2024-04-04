using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.CommandHandlerRepository;
using CommandsLayer.Commands.LessonCommands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QueriesLayer.Queries.LessonQueries;
using QueriesLayer.QueryHandlerInterfaces;
using QueriesLayer.QueryHandlerRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentExamRegistration.DataAccess.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); ;


builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<ICommandLessonRepository, LessonCommandRepository>();
builder.Services.AddScoped<ICommandStudentRepository, StudentCommandRepository>();
builder.Services.AddScoped<ICommandExamRepository, ExamCommandRepository>();

//builder.Services.AddMediatR(typeof(GetAllLessonsQuery).Assembly);

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(GetAllLessonsQuery).Assembly));
builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(CreateLessonCommand).Assembly));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
