using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CommandsLayer.Commands.StudentCommands
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        [Required]
        public int StudentId { get; set; }
        public DeleteStudentCommand(int studentId)
        {
            StudentId = studentId;
        }
    }
}
