using HCRUDEasy.Data;
using HCRUDEasy.Data.Contexts;
using HCRUDEasy.Data.Repositories;
using HCRUDEasy.Domain;
using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person.Candidate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HCRUDEasy.DI
{
    public class Injector
    {
      public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericRepository<Candidate>), typeof(CandidateRepository));
            services.AddScoped(typeof(BankInformationStorer));
            services.AddScoped(typeof(CandidateStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
