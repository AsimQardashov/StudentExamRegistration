using DataAccess.DTO_s;
using MediatR;

namespace CommandsLayer.Commands.ExamCommands
{
    public class UpdateExamCommand : IRequest<Unit>
    {
        public ExamModel updatedExam { get; set; }
    }
}
