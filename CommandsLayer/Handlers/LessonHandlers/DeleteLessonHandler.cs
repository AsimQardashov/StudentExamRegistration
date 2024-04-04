using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.LessonCommands;
using MediatR;

namespace CommandsLayer.Handlers.LessonHandlers
{
    public class DeleteLessonHandler : IRequestHandler<DeleteLessonCommand, Unit>
    {
        private ICommandLessonRepository _commandLessonRepository;
        public DeleteLessonHandler(ICommandLessonRepository commandLessonRepository)
        {
            _commandLessonRepository = commandLessonRepository;
        }

        public async Task<Unit> Handle(DeleteLessonCommand request, CancellationToken cancellationToken)
        {
            return await _commandLessonRepository.DeleteLessonAsync(request);
        }
    }
}
