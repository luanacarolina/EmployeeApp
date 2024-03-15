using System;
namespace Domain.Entidades
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public bool IsDeleted { get; set; }

        public Employee(string name, string position, string department)
        {
            Name = name;
            Position = position;
            Department = department;
            IsDeleted = true;
        }

        public void Update(string name, string position, string department)
        {
            Name = name;
            Position = position;
            Department = department;
        }

        public void Deactivate()
        {
            IsDeleted = false;
        }
    }
}

