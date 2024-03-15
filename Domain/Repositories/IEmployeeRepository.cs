using System;
using Domain.Entidades;

namespace Domain.Repositories
{
	public interface IEmployeeRepository
	{
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}

