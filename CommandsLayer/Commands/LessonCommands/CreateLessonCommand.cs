using MediatR;
using DataAccess.DTO_s;

namespace CommandsLayer.Commands.LessonCommands
{
    public class CreateLessonCommand : IRequest<Unit>
    {
        public LessonViewModel ViewModel { get; set; }
        
    }
}
