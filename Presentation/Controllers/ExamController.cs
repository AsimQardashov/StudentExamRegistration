using CommandsLayer.Commands.ExamCommands;
using DataAccess.DTO_s;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using QueriesLayer.Queries.ExamQueries;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<ExamViewModel>>> GetAllExamsAsync()
        {
            return Ok(await _mediator.Send(new GetAllExamsQuery()));
        }

        [HttpGet]
        [Route("{examId}")]
        public async Task<ActionResult<ExamViewModel>> GetExamByIdAsync(int examId)
        {
            return Ok(await _mediator.Send(new GetExamByIdQuery(examId)));
        }

        [HttpPost]
        public async Task<ActionResult> CreateExamAsync(CreateExamCommand createExamCommand)
        {
            return Ok(await _mediator.Send(createExamCommand));
        }

        [HttpDelete]
        [Route("{examId}")]
        public async Task<ActionResult> DeleteExamAsync(int examId)
        {
            return Ok(await _mediator.Send(new DeleteExamCommand(examId)));
        }

        [HttpPut]
        [Route("{examId}")]
        public async Task<ActionResult> UpdateExamAsync(int examId, UpdateExamCommand updateExamCommand)
        {
            updateExamCommand.updatedExam.ExamId = examId;
            return Ok(await _mediator.Send(updateExamCommand));
        }
    }
}
