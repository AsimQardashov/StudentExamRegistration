using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.StudentCommands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentExamRegistration.DataAccess;
using StudentExamRegistration.DataAccess.Entities;

namespace CommandsLayer.CommandHandlerRepository
{
    public class StudentCommandRepository : ICommandStudentRepository
    {
        private AppDbContext _context;
        public StudentCommandRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> CreateStudentAsync(CreateStudentCommand command)
        {
            if(await _context.Students.AnyAsync(l => l.StudentId == command.createdStudent.StudentNumber))
            {
                throw new Exception("A student with the same id already exists.");
            }
            var student = new Student
            {
                StudentNumber = command.createdStudent.StudentNumber,
                StudentName = command.createdStudent.StudentName,
                StudentSurname = command.createdStudent.StudentSurname,
                Class = command.createdStudent.Class
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        public async Task<Unit> DeleteStudentAsync(DeleteStudentCommand command)
        {
            var student =  await _context.Students.FirstOrDefaultAsync(s => s.StudentId == command.StudentId);
            if(student == null)
            {
                throw new Exception("Student not found.");
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
            
        }

        public async Task<Unit> UpdateStudentAsync(UpdateStudentCommand command)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == command.UpdatedStudent.StudentId);
            if (student == null)
            {
                throw new Exception("Student not found.");
            }

            student.StudentName = command.UpdatedStudent.StudentName;
            student.StudentSurname = command.UpdatedStudent.StudentSurname;
            student.Class = command.UpdatedStudent.Class;
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
