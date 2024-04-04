using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.ExamCommands;
using MediatR;

namespace CommandsLayer.Handlers.ExamHandlers
{
    public class DeleteExamHandler : IRequestHandler<DeleteExamCommand, Unit>
    {
        private ICommandExamRepository _commandExamRepository;

        public DeleteExamHandler(ICommandExamRepository commandExamRepository)
        {
            _commandExamRepository = commandExamRepository;
        }

        public async Task<Unit> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
        {
            return await _commandExamRepository.DeleteExamAsync(request);
        }
    }
}
