using System;
using MediatR;

namespace Application.Commands
{
	public class CreateCompanyCommand : IRequest<int>
    {
        public string? Name { get; set; }
        public string ?Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}

