using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.ExamCommands;
using MediatR;

namespace CommandsLayer.Handlers.ExamHandlers
{
    public class CreateExamHandler : IRequestHandler<CreateExamCommand, Unit>
    {
        private ICommandExamRepository _commandExamRepository;

        public CreateExamHandler(ICommandExamRepository commandExamRepository)
        {
            _commandExamRepository = commandExamRepository;
        }

        public async Task<Unit> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            return await _commandExamRepository.CreateExamAsync(request);
        }
    }
}
