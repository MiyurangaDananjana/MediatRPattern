using MediatRPattern.Models;

namespace MediatRPattern.Data
{
    public class EmployeeService : IEmployeeService
    {

        private List<EmployeeDto> employees = [];

        public void AddEmployee(EmployeeDto employeeDto)
        {
            employeeDto.Id = Guid.NewGuid();
            employees.Add(employeeDto);
        }

        public List<EmployeeDto> GetEmployees()
        {
            return employees;
        }

        public EmployeeDto? GetEmployeeById(Guid id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
