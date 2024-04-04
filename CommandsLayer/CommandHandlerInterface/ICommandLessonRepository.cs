using CommandsLayer.Commands.LessonCommands;
using DataAccess.DTO_s;
using MediatR;

namespace CommandsLayer.CommandHandlerInterface
{
    public interface ICommandLessonRepository
    {
        Task<Unit> CreateLessonAsnyc(CreateLessonCommand command);
        Task<Unit> UpdateLessonAsync(UpdateLessonCommand command);
        Task<Unit> DeleteLessonAsync(DeleteLessonCommand command);
    }
}
