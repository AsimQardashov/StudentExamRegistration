using MediatR;
using DataAccess.DTO_s;

namespace QueriesLayer.Queries.StudentQueries
{
    public class GetAllStudientsQuery : IRequest<List<StudentViewModel>>
    {
    }
}
