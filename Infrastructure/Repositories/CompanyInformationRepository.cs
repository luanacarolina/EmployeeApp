using System;
using Domain.Entidades;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Repositories
{
    public class CompanyInformationRepository : ICompanyInformationRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyInformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompanyInformation>> GetAllAsync()
        {
            return await _context.CompanyInformations.ToListAsync();
        }

        public async Task<CompanyInformation?> GetByIdAsync(int id)
        {
            return await _context.CompanyInformations.FindAsync(id);
        }

        public async Task<int> AddAsync(CompanyInformation company)
        {
            await _context.CompanyInformations.AddAsync(company);
            await _context.SaveChangesAsync();
            return company.Id;
        }

        public async Task UpdateAsync(CompanyInformation company)
        {
            _context.CompanyInformations.Update(company);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var company = await _context.CompanyInformations.FindAsync(id);
            if (company != null)
            {
                _context.CompanyInformations.Remove(company);
                await _context.SaveChangesAsync();
            }
        }
    }
}

