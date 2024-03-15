using System;
using System.Configuration;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
		}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CompanyInformation> CompanyInformations { get; set; }

    }
}

