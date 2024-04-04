using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.ExamCommands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentExamRegistration.DataAccess;
using StudentExamRegistration.DataAccess.Entities;

namespace CommandsLayer.CommandHandlerRepository
{
    public class ExamCommandRepository : ICommandExamRepository
    {
        private AppDbContext _context;
        public ExamCommandRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> CreateExamAsync(CreateExamCommand command)
        {
            if (await _context.Exams.AnyAsync(l => l.ExamId == command.createdExam.ExamId))
            {
                throw new Exception("An exam with the same id already exists.");
            }

            var exam = new Exam
            {
                LessonId = command.createdExam.LessonId,
                ExamDate = command.createdExam.ExamDate,
                StudentId = command.createdExam.StudentId,
                Score = command.createdExam.Score
            };

            _context.Exams.Add(exam);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        public async Task<Unit> DeleteExamAsync(DeleteExamCommand command)
        {
            var exam = await _context.Exams.FirstOrDefaultAsync(e => e.ExamId == command.ExamId);
            if (exam == null)
            {
                throw new Exception("Exam not found.");
            }

            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        public async Task<Unit> UpdateExamAsync(UpdateExamCommand command)
        {
            var exam = await _context.Exams.FirstOrDefaultAsync(e => e.ExamId == command.updatedExam.ExamId);
            if (exam == null)
            {
                throw new Exception("Exam not found.");
            }
            exam.LessonId = command.updatedExam.LessonId;
            //exam.LessonCode = command.updatedExam.LessonCode;
            exam.ExamDate = command.updatedExam.ExamDate;
            exam.StudentId = command.updatedExam.StudentId;
            exam.Score = command.updatedExam.Score;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
