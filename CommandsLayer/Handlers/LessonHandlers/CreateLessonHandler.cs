using CommandsLayer.CommandHandlerInterface;
using CommandsLayer.Commands.LessonCommands;
using MediatR;

namespace CommandsLayer.Handlers.LessonHandlers
{
    public class CreateLessonHandler : IRequestHandler<CreateLessonCommand, Unit>
    {
        private ICommandLessonRepository _commandLessonRepository;

        public CreateLessonHandler(ICommandLessonRepository commandLessonRepository)
        {
            _commandLessonRepository = commandLessonRepository;
        }

        public async Task<Unit> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            return await _commandLessonRepository.CreateLessonAsnyc(request);
        }
    }
}
