using CommandsLayer.Commands.StudentCommands;
using MediatR;

namespace CommandsLayer.CommandHandlerInterface
{
    public interface ICommandStudentRepository
    {
        Task<Unit> CreateStudentAsync(CreateStudentCommand command);
        Task<Unit> UpdateStudentAsync(UpdateStudentCommand command);
        Task<Unit> DeleteStudentAsync(DeleteStudentCommand command);

    }
}
