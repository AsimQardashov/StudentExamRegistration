using Microsoft.EntityFrameworkCore;
using DataAccess.DTO_s;
using QueriesLayer.QueryHandlerInterfaces;
using StudentExamRegistration.DataAccess;
using QueriesLayer.Queries.StudentQueries;

namespace QueriesLayer.QueryHandlerRepositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<StudentViewModel>> GetAllStudentsAsync()
        {
            return await _context.Students.Select(s => new StudentViewModel
            {
                StudentId = s.StudentId,
                StudentNumber = s.StudentNumber,
                StudentName = s.StudentName,
                StudentSurname = s.StudentSurname,
                Class = s.Class
            }).ToListAsync();
        }

        public async Task<StudentViewModel> GetStudentByIdAsync(GetStudentByIdQuery query)
        {
            if(!await _context.Students.AnyAsync(l => l.StudentId == query.StudentId))
            {
                throw new Exception("Student not found");
            }

            return await _context.Students
                .Where(x => x.StudentId == query.StudentId)
                .Select(s => new StudentViewModel
                {
                    StudentId = s.StudentId,
                    StudentNumber = s.StudentNumber,
                    StudentName = s.StudentName,
                    StudentSurname = s.StudentSurname,
                    Class = s.Class
                })
                .FirstOrDefaultAsync();
        }
    }
}
