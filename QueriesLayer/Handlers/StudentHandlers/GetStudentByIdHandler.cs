using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.StudentQueries;
using QueriesLayer.QueryHandlerInterfaces;

namespace QueriesLayer.Handlers.StudentHandlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentViewModel>
    {
        private readonly IStudentRepository _studentInterface;
        public GetStudentByIdHandler(IStudentRepository studentInterface)
        {
            _studentInterface = studentInterface;
        }

        public async Task<StudentViewModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _studentInterface.GetStudentByIdAsync(request);
        }
    }
}
