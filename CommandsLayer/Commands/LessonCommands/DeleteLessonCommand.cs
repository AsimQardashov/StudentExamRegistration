using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CommandsLayer.Commands.LessonCommands
{
    public class DeleteLessonCommand : IRequest<Unit>
    {
        [Required]
        public int LessonId { get; set; }

        public DeleteLessonCommand(int lessonId)
        {
            LessonId = lessonId;
        }
    }
}
