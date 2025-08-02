using MediatR;
using MediatRPattern.Data;
using MediatRPattern.Models;

namespace MediatRPattern.Commands
{
    public class AddEmployeeCommand : IRequest
    {
        public string Name { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Email { get; set; } = null!;
    }

    public class AddEmployeeCommandHandler(IEmployeeService employeeService) : IRequestHandler<AddEmployeeCommand>
    {
        public Task Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            employeeService.AddEmployee(new EmployeeDto
            {
                Name = request.Name,
                Role = request.Role,
                Email = request.Email
            });

            return Task.CompletedTask;
        }
    }
}
