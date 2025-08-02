using MediatRPattern.Models;

namespace MediatRPattern.Data
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeDto employeeDto);

        List<EmployeeDto> GetEmployees();

        EmployeeDto? GetEmployeeById(Guid id);
    }
}
