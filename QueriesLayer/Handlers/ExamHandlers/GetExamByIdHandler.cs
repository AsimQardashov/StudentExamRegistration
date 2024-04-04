using MediatR;
using DataAccess.DTO_s;
using QueriesLayer.Queries.ExamQueries;
using QueriesLayer.QueryHandlerInterfaces;

namespace QueriesLayer.Handlers.ExamHandlers
{
    public class GetExamByIdHandler : IRequestHandler<GetExamByIdQuery, ExamViewModel>
    {
        private readonly IExamRepository _examRepository;
        public GetExamByIdHandler(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        public async Task<ExamViewModel> Handle(GetExamByIdQuery request, CancellationToken cancellationToken)
        {
            return await _examRepository.GetExamByIdAsync(request);
        }
    }
}
