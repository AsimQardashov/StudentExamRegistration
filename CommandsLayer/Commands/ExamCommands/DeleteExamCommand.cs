using MediatR;

namespace CommandsLayer.Commands.ExamCommands
{
    public class DeleteExamCommand : IRequest<Unit>
    {
        public int ExamId { get; set; }
        public DeleteExamCommand(int examId)
        {
            ExamId = examId;
        }
    }
}
