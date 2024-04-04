using MediatR;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DTO_s;
using QueriesLayer.Queries.StudentQueries;
using CommandsLayer.Commands.StudentCommands;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentViewModel>>> GetAllStudentsAsync()
        {
            return Ok(await _mediator.Send(new GetAllStudientsQuery()));
        }

        [HttpGet]
        [Route("{studentId}")]
        public async Task<ActionResult<StudentViewModel>> GetStudentByIdAsync(int studentId)
        {
            return Ok(await _mediator.Send(new GetStudentByIdQuery(studentId)));
        }

        [HttpPost]
        public async Task<ActionResult> CreateStudentAsync(CreateStudentCommand createStudentCommand)
        {
            return Ok(await _mediator.Send(createStudentCommand));
        }

        [HttpPut]
        [Route("{studentId}")]
        public async Task<ActionResult> UpdateStudentAsync(int studentId, UpdateStudentCommand updateStudentCommand)
        {
            updateStudentCommand.UpdatedStudent.StudentId = studentId;
            return Ok(await _mediator.Send(updateStudentCommand));
        }

        [HttpDelete]
        [Route("{studentId}")]  
        public async Task<ActionResult> DeleteStudentAsync(int studentId)
        {
            return Ok(await _mediator.Send(new DeleteStudentCommand(studentId)));
        }
    }
}
