using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.StudentCommands;
using MediatR;

namespace CommandsLayer.Handlers.StudentHandlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Unit>
    {
        private ICommandStudentRepository _commandStudentRepository;
        public CreateStudentHandler(ICommandStudentRepository commandStudentRepository)
        {
            _commandStudentRepository = commandStudentRepository;
        }
        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
           return await _commandStudentRepository.CreateStudentAsync(request);
        }
    }
}
