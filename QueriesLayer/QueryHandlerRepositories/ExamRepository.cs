using DataAccess.DTO_s;
using Microsoft.EntityFrameworkCore;
using QueriesLayer.Queries.ExamQueries;
using QueriesLayer.QueryHandlerInterfaces;
using StudentExamRegistration.DataAccess;

namespace QueriesLayer.QueryHandlerRepositories
{
    public class ExamRepository : IExamRepository
    {
        private readonly AppDbContext _context;
        public ExamRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ExamViewModel>> GetAllExamsAsync()
        {
            return await _context.Exams
                .Include(e => e.Student)
                .Include(e => e.Lesson)
                .Select(e => new ExamViewModel
                {
                    ExamId = e.ExamId,
                    LessonCode = e.Lesson.LessonCode,
                    ExamDate = e.ExamDate,
                    StudentId = e.StudentId,
                    Score = e.Score,
                    StudentName = e.Student.StudentName,
                    StudentSurname = e.Student.StudentSurname,
                    LessonTitle = e.Lesson.LessonTitle
                })
                .ToListAsync();
        }

        public async Task<ExamViewModel?> GetExamByIdAsync(GetExamByIdQuery query)
        {
            if (!await _context.Exams.AnyAsync(l => l.ExamId == query.examId))
            {
                throw new Exception("Exam not found");
            }

            return await _context.Exams
                .Include(e => e.Student)
                .Include(e => e.Lesson)
                .Where(x => x.ExamId == query.examId)
                .Select(e => new ExamViewModel
                {
                    ExamId = e.ExamId,
                    LessonCode = e.Lesson.LessonCode,
                    ExamDate = e.ExamDate,
                    StudentId = e.StudentId,
                    Score = e.Score,
                    StudentName = e.Student.StudentName,
                    StudentSurname = e.Student.StudentSurname,
                    LessonTitle = e.Lesson.LessonTitle
                })
                .FirstOrDefaultAsync();
        }
    }
}
