using System;
using Application.Queries;
using Domain.Entidades;
using Domain.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace Application.Handlers
{
	public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyInformation?>
    {
        private readonly ICompanyInformationRepository _companyRepository;

        public GetCompanyByIdQueryHandler(ICompanyInformationRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<CompanyInformation?> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetByIdAsync(request.Id);
        }

       
    }
}

