using HCRUDEasy.Data.Contexts;
using HCRUDEasy.Domain;
using System.Threading.Tasks;

namespace HCRUDEasy.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
