using System;
using Application.Queries;
using Domain.Entidades;
using Domain.Services;
using MediatR;

namespace Application.Handlers
{
	public class GetCompanyInformationQueryHandler : IRequestHandler<GetCompanyInformationQuery, CompanyInformation>
    {
        private readonly ICompanyInformationService _companyInformationService;

        public GetCompanyInformationQueryHandler(ICompanyInformationService companyInformationService)
		{
            _companyInformationService = companyInformationService;
        }
        public async Task<CompanyInformation> Handle(GetCompanyInformationQuery request, CancellationToken cancellationToken)
        {
            return await _companyInformationService.GetCompanyInformationAsync();
        }
    }
}

