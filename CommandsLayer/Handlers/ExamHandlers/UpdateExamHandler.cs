using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.ExamCommands;
using MediatR;

namespace CommandsLayer.Handlers.ExamHandlers
{
    public class UpdateExamHandler : IRequestHandler<UpdateExamCommand, Unit>
    {
        private ICommandExamRepository _commandExamRepository;
        public UpdateExamHandler(ICommandExamRepository commandExamRepository)
        {
            _commandExamRepository = commandExamRepository;
        }

        public async Task<Unit> Handle(UpdateExamCommand request, CancellationToken cancellationToken)
        {
            return await _commandExamRepository.UpdateExamAsync(request);
        }
    }
}
