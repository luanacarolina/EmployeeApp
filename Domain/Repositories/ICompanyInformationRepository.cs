using System;
using Domain.Entidades;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Domain.Repositories
{
	public interface ICompanyInformationRepository
	{
        Task<List<CompanyInformation>> GetAllAsync();
        Task<CompanyInformation?> GetByIdAsync(int id);
        Task<int> AddAsync(CompanyInformation company);
        Task UpdateAsync(CompanyInformation company);
        Task DeleteAsync(int id);
    }
}

