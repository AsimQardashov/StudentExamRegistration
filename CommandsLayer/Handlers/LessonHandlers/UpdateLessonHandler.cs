using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.LessonCommands;
using MediatR;

namespace CommandsLayer.Handlers.LessonHandlers
{
    public class UpdateLessonHandler : IRequestHandler<UpdateLessonCommand, Unit>
    {
        private ICommandLessonRepository _commandLessonRepository;
        public UpdateLessonHandler(ICommandLessonRepository commandLessonRepository)
        {
            _commandLessonRepository = commandLessonRepository;
        }

        public async Task<Unit> Handle(UpdateLessonCommand request, CancellationToken cancellationToken)
        {
            return await _commandLessonRepository.UpdateLessonAsync(request);
        }
    }
}
