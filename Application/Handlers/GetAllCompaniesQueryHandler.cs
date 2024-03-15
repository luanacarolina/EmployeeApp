using System;
using Application.Queries;
using Domain.Entidades;
using Domain.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace Application.Handlers
{
	public class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, List<CompanyInformation>>
    {
        private readonly ICompanyInformationRepository _companyRepository;

        public GetAllCompaniesQueryHandler(ICompanyInformationRepository companyRepository)
		{
            _companyRepository = companyRepository;

        }

        public async Task<List<CompanyInformation>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetAllAsync();
        }
    }
}

