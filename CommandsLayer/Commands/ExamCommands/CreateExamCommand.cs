using DataAccess.DTO_s;
using MediatR;

namespace CommandsLayer.Commands.ExamCommands
{
    public class CreateExamCommand : IRequest<Unit>
    {
        public ExamModel createdExam { get; set; }
       
    }
}
