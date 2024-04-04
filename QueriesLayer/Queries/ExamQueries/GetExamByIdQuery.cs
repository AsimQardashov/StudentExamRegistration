using MediatR;
using DataAccess.DTO_s;

namespace QueriesLayer.Queries.ExamQueries
{
    public class GetExamByIdQuery : IRequest<ExamViewModel>
    {
        public int examId;

        public GetExamByIdQuery(int id)
        {
            this.examId = id;
        }
    }
}
