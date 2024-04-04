using DataAccess.DTO_s;
using MediatR;

namespace QueriesLayer.Queries.LessonQueries
{
    public class GetLessonByCodeQuery : IRequest<LessonViewModel>
    {
        public int LessonId;

        public GetLessonByCodeQuery(int lessonId)
        {
            this.LessonId = lessonId;
        }

    }
}
