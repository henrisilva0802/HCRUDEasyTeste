using Microsoft.EntityFrameworkCore;

using HCRUDEasy.Domain.Person.Candidate;
using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain;

namespace HCRUDEasy.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Candidate>().Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidate>().Property(c => c.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidate>().Property(c => c.Phone).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Candidate>().Property(c => c.City).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Candidate>().Property(c => c.State).HasMaxLength(20).IsRequired();

            modelBuilder.Entity<BankInformation>().Property(c => c.PersonName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BankInformation>().Property(c => c.Cpf).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BankInformation>().Property(c => c.BankName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BankInformation>().Property(c => c.Agency).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BankInformation>().Property(c => c.AccountType).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BankInformation>().Property(c => c.AccountNumber).HasMaxLength(100).IsRequired();

        }

        DbSet<Candidate> Candidate { set; get; }
        DbSet<BankInformation> BankInformation { set; get; }

    }

}