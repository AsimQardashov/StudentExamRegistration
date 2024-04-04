using DataAccess.DTO_s;
using MediatR;

namespace CommandsLayer.Commands.LessonCommands
{
    public class UpdateLessonCommand : IRequest<Unit>
    {
        public LessonViewModel UpdatedLesson { get; set; }
    }
}
