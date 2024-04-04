using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.LessonQueries;
using QueriesLayer.QueryHandlerInterfaces;
using StudentExamRegistration.DataAccess.Entities;

namespace QueriesLayer.Handlers.LessonHandlers
{
    public class GetLessonByCodeHandler : IRequestHandler<GetLessonByCodeQuery, LessonViewModel>
    {
        private readonly ILessonRepository _lessonRepository;

        public GetLessonByCodeHandler(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<LessonViewModel> Handle(GetLessonByCodeQuery request, CancellationToken cancellationToken)
        {
            return await _lessonRepository.GetLessonByCodeAsync(request);
        }
    }

}
