using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.StudentQueries;
using QueriesLayer.QueryHandlerInterfaces;

namespace QueriesLayer.Handlers.StudentHandlers
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudientsQuery, List<StudentViewModel>>
    {
        private readonly IStudentRepository _studentInterface;
        public GetAllStudentsHandler(IStudentRepository studentInterface)
        {
            _studentInterface = studentInterface;
        }

        public Task<List<StudentViewModel>> Handle(GetAllStudientsQuery request, CancellationToken cancellationToken)
        {
            return _studentInterface.GetAllStudentsAsync();
        }
    }
}
