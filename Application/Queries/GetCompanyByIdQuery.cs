using System;
using Domain.Entidades;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application.Queries
{
	public class GetCompanyByIdQuery : IRequest<CompanyInformation>
    {
        public int Id { get; set; }

        public GetCompanyByIdQuery(int id)
		{
            Id = id;
        }
	}
}

