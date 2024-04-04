using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.LessonCommands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentExamRegistration.DataAccess;
using StudentExamRegistration.DataAccess.Entities;

namespace CommandsLayer.CommandHandlerRepository
{
    public class LessonCommandRepository : ICommandLessonRepository
    {
        private AppDbContext _context;

        public LessonCommandRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> CreateLessonAsnyc(CreateLessonCommand command)
        {
            if (await _context.Lessons.AnyAsync(l => l.LessonCode == command.ViewModel.LessonCode))
            {
                throw new Exception("A lesson with the same code already exists.");
            }

            var lesson = new Lesson
            {
                LessonCode = command.ViewModel.LessonCode,
                LessonTitle = command.ViewModel.LessonTitle,
                Class = command.ViewModel.Class,
                TeacherName = command.ViewModel.TeacherName,
                TeacherSurname = command.ViewModel.TeacherSurname

            };

            _context.Lessons.Add(lesson);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }

        public async Task<Unit> DeleteLessonAsync(DeleteLessonCommand command)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.LessonId == command.LessonId);

            if (lesson == null)
            {
                throw new Exception("Lesson not found.");
            }

            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }

        public async Task<Unit> UpdateLessonAsync(UpdateLessonCommand command)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.LessonId == command.UpdatedLesson.LessonId);

            if (lesson == null)
            {
                throw new Exception("Lesson not found.");
            }

            lesson.LessonTitle = command.UpdatedLesson.LessonTitle;
            lesson.Class = command.UpdatedLesson.Class;
            lesson.TeacherName = command.UpdatedLesson.TeacherName;
            lesson.TeacherSurname = command.UpdatedLesson.TeacherSurname;

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
