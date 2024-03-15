using System;
using Domain.Entidades;

namespace Domain.Services
{
	public interface IEmployeeService
	{
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<bool> DeactivateEmployeeAsync(int id);
    }
}

