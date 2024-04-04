using DataAccess.DTO_s;
using QueriesLayer.Queries.StudentQueries;

namespace QueriesLayer.QueryHandlerInterfaces
{
    public interface IStudentRepository
    {
        Task<List<StudentViewModel>> GetAllStudentsAsync();
        Task<StudentViewModel> GetStudentByIdAsync(GetStudentByIdQuery query);
    }
}
