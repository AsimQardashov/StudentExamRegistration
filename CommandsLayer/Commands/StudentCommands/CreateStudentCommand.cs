using DataAccess.DTO_s;
using MediatR;

namespace CommandsLayer.Commands.StudentCommands
{
    public class CreateStudentCommand : IRequest<Unit>
    {
        public StudentViewModel createdStudent { get; set; }
    }
}
