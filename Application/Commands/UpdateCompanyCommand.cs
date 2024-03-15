using System;
using MediatR;

namespace Application.Commands
{
	public class UpdateCompanyCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public UpdateCompanyCommand(string name, string addresss , string phoneNumber)
        {
            Name = name;
            Address = addresss;
            PhoneNumber = phoneNumber;
        }
    }
}

