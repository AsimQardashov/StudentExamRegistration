using DataAccess.DTO_s;
using MediatR;


namespace QueriesLayer.Queries.LessonQueries
{
    public class GetAllLessonsQuery : IRequest<List<LessonViewModel>>
    {
    }
}
