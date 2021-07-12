using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractModule1.Models.Context
{
    public class ModuleDbContext : DbContext
    {
        public ModuleDbContext(DbContextOptions<ModuleDbContext> options) : base(options)
        { }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyServices> CompanyServices { get; set; }
        public DbSet<ContractCompany> ContractCompany { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServicesType { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractCompany>()
                .HasMany<Company>(c => c.Company)
                .WithRequired()
                .HasForeignKey(o => o.IDCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyServices>()
                .HasMany<ContractCompany>(c => c.Contract)
                .WithRequired()
                .HasForeignKey(o => o.IDContract)
                .WillCascadeOnDelete(false);
        }*/
    }
 }