using System;
using Domain.Entidades;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Application.Queries
{
	public class GetAllCompaniesQuery : IRequest<List<CompanyInformation>>
    {
	
		public GetAllCompaniesQuery()
		{
		}
	}
}

