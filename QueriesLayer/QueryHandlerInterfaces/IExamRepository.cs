using DataAccess.DTO_s;
using QueriesLayer.Queries.ExamQueries;

namespace QueriesLayer.QueryHandlerInterfaces
{
    public interface IExamRepository
    {
        Task<List<ExamViewModel>> GetAllExamsAsync();
        Task<ExamViewModel> GetExamByIdAsync(GetExamByIdQuery query);
    }
}
