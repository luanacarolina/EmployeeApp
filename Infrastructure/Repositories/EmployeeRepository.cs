using System;
using Domain.Entidades;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
	public class EmployeeRepository: IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();


        public void Add(Employee employee)
        {
            employee.Id = _employees.Count + 1;
            _employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employeeToDelete = _employees.FirstOrDefault(e => e.Id == id && !e.IsDeleted);
            if (employeeToDelete != null)
            {
                employeeToDelete.IsDeleted = true;
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees.Where(e => !e.IsDeleted);

        }

        public Employee GetById(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id && e.IsDeleted);
            if (employee == null)
            {
                throw new ArgumentException("Employee not found");
            }
            return employee;


        }

        public void Update(Employee employee)
        {
            var existingEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id && !e.IsDeleted);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Position = employee.Position;
                existingEmployee.Department = employee.Department;
            }
        }
    }
}

