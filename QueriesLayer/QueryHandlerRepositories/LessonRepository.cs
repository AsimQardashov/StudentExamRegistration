using DataAccess.DTO_s;
using Microsoft.EntityFrameworkCore;
using QueriesLayer.Queries.LessonQueries;
using QueriesLayer.QueryHandlerInterfaces;
using StudentExamRegistration.DataAccess;

namespace QueriesLayer.QueryHandlerRepositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly AppDbContext _context;

        public LessonRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<LessonViewModel>> GetAllLessonsAsync()
        {
            return await _context.Lessons.Select(l => new LessonViewModel
            {
                LessonId = l.LessonId,
                LessonCode = l.LessonCode,
                LessonTitle = l.LessonTitle,
                Class = l.Class,
                TeacherName = l.TeacherName,
                TeacherSurname = l.TeacherSurname
            })
        .ToListAsync();
        }

        public async Task<LessonViewModel> GetLessonByCodeAsync(GetLessonByCodeQuery query)
        {
            if (!await _context.Lessons.AnyAsync(l => l.LessonId == query.LessonId))
            {
                throw new Exception("Lesson not found");
            }

            return await _context.Lessons
                .Where(x => x.LessonId == query.LessonId)
                .Select(l => new LessonViewModel
                {
                    LessonId = l.LessonId,
                    LessonCode = l.LessonCode,
                    LessonTitle = l.LessonTitle,
                    Class = l.Class,
                    TeacherName = l.TeacherName,
                    TeacherSurname = l.TeacherSurname
                })
                .FirstOrDefaultAsync();
        }
    }
}
