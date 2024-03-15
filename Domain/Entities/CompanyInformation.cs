using System;
namespace Domain.Entidades
{
	public class CompanyInformation
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public CompanyInformation(string name ="", string address="", string phoneNumber="")
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void Update(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}";
        }
    }
}

