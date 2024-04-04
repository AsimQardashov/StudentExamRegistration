using DataAccess.DTO_s;
using MediatR;

namespace QueriesLayer.Queries.ExamQueries
{
    public class GetAllExamsQuery : IRequest<List<ExamViewModel>>
    {
    }
}
