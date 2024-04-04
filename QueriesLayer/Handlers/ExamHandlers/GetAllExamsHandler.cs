using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.ExamQueries;
using QueriesLayer.QueryHandlerInterfaces;

namespace QueriesLayer.Handlers.ExamHandlers
{
    public class GetAllExamsHandler : IRequestHandler<GetAllExamsQuery, List<ExamViewModel>>
    {
        private readonly IExamRepository _examInterface;
        public GetAllExamsHandler(IExamRepository examInterface)
        {
            _examInterface = examInterface;
        }

        public Task<List<ExamViewModel>> Handle(GetAllExamsQuery request, CancellationToken cancellationToken)
        {
            return _examInterface.GetAllExamsAsync();
        }
    }
}
