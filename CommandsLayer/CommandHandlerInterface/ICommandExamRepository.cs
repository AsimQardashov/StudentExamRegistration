using CommandsLayer.Commands.ExamCommands;
using MediatR;

namespace CommandsLayer.CommandHandlerInterface
{
    public interface ICommandExamRepository
    {
        Task<Unit> CreateExamAsync(CreateExamCommand command);
        Task<Unit> UpdateExamAsync(UpdateExamCommand command);
        Task<Unit> DeleteExamAsync(DeleteExamCommand command);
    }
}
