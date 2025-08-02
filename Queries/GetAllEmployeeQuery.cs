using MediatR;
using MediatRPattern.Data;
using MediatRPattern.Models;

namespace MediatRPattern.Queries
{
    public class GetAllEmployeeQuery : IRequest<IEnumerable<EmployeeDto>>
    {
    }

    public class GetAllEmployeeQueryHandler(IEmployeeService employeeService) 
        : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeDto>>
    {
        public Task<IEnumerable<EmployeeDto>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employees = employeeService.GetEmployees();
            return Task.FromResult(employees.AsEnumerable());
        }
    }

}
