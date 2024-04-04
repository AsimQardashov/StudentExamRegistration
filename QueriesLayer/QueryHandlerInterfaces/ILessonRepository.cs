using DataAccess.DTO_s;
using QueriesLayer.Queries.LessonQueries;

namespace QueriesLayer.QueryHandlerInterfaces
{
    public interface ILessonRepository
    {
        Task<List<LessonViewModel>> GetAllLessonsAsync();
        Task<LessonViewModel> GetLessonByCodeAsync(GetLessonByCodeQuery query);
    }
}
