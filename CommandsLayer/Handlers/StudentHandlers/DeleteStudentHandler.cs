using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.StudentCommands;
using MediatR;

namespace CommandsLayer.Handlers.StudentHandlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private ICommandStudentRepository _commandStudentRepository;
        public DeleteStudentHandler(ICommandStudentRepository commandStudentRepository)
        {
            _commandStudentRepository = commandStudentRepository;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return await _commandStudentRepository.DeleteStudentAsync(request);
        }
    }
}
