using MediatR;
using MediatRPattern.Commands;
using MediatRPattern.Data;
using MediatRPattern.Models;
using MediatRPattern.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(mediator.Send(new GetAllEmployeeQuery()));
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(Guid id)
        //{
        //    var employee = employeeService.GetEmployeeById(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(employee);
        //}

        [HttpPost("")]
        public IActionResult Post([FromBody] EmployeeDto employeeDto)
        {
            var command = new AddEmployeeCommand
            {
                Name = employeeDto.Name,
                Role = employeeDto.Role,
                Email = employeeDto.Email
            };

            mediator.Send(command);
            return Ok();
        }
    }
}
