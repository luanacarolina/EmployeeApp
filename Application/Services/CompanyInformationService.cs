using System;
using Domain.Entidades;
using Domain.Repositories;

namespace Application.Services
{
	public class CompanyInformationService
	{
        private readonly ICompanyInformationRepository _companyInformationRepository;

        public CompanyInformationService(ICompanyInformationRepository companyInformationRepository)
		{
            _companyInformationRepository = companyInformationRepository;
        }
        
        public void UpdateCompanyInformation(CompanyInformation companyInformation)
        {
            _companyInformationRepository.UpdateAsync(companyInformation);
        }
    }
}

