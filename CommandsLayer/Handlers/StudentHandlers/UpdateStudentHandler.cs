using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.StudentCommands;
using MediatR;

namespace CommandsLayer.Handlers.StudentHandlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Unit>
    {
        private ICommandStudentRepository _commandStudentRepository;
        public UpdateStudentHandler(ICommandStudentRepository commandStudentRepository)
        {
            _commandStudentRepository = commandStudentRepository;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            return await _commandStudentRepository.UpdateStudentAsync(request);
        }
    }
}
