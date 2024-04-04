using MediatR;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DTO_s;
using QueriesLayer.Queries.LessonQueries;
using StudentExamRegistration.DataAccess.Entities;
using CommandsLayer.Commands.LessonCommands;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LessonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<LessonViewModel>>> GetAllLessonsAsnyc()
        {
            return Ok(await _mediator.Send(new GetAllLessonsQuery()));
        }

        [HttpGet]
        [Route("{lessonId}")]
        public async Task<ActionResult<Lesson>> GetLessonByCodeAsync(int lessonId)
        {
            return Ok(await _mediator.Send(new GetLessonByCodeQuery(lessonId)));
        }

        [HttpPost]
        public async Task<ActionResult> CreateLessonAsnyc(CreateLessonCommand createLessonCommand)
        {
            return Ok(await _mediator.Send(createLessonCommand));
        }

        [HttpPut]
        [Route("{lessonId}")]
        public async Task<ActionResult> UpdateLessonAsync(int lessonId, UpdateLessonCommand updateLessonCommand)
        {
            updateLessonCommand.UpdatedLesson.LessonId = lessonId;
            return Ok(await _mediator.Send(updateLessonCommand));
        }

        [HttpDelete]
        [Route("{lessonId}")]
        public async Task<ActionResult> DeleteLessonAsync(int lessonId)
        {
            return Ok(await _mediator.Send(new DeleteLessonCommand(lessonId)));
        }
    }
}
