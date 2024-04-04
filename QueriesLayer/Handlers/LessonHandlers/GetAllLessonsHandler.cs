using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.LessonQueries;
using QueriesLayer.QueryHandlerInterfaces;

namespace QueriesLayer.Handlers.LessonHandlers
{
    public class GetAllLessonsHandler : IRequestHandler<GetAllLessonsQuery, List<LessonViewModel>>
    {
        private readonly ILessonRepository _lessonRepository;

        public GetAllLessonsHandler(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<List<LessonViewModel>> Handle(GetAllLessonsQuery request, CancellationToken cancellationToken)
        {
            return await _lessonRepository.GetAllLessonsAsync();
        }
    }

}
