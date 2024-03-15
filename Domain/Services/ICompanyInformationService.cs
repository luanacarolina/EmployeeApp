using System;
using Domain.Entidades;

namespace Domain.Services
{
	public interface ICompanyInformationService
	{
        Task<CompanyInformation> GetCompanyInformationAsync();
        Task<CompanyInformation> UpdateCompanyInformationAsync(CompanyInformation companyInformation);
    }
}

