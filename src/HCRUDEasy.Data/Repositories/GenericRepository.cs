using HCRUDEasy.Data.Contexts;
using HCRUDEasy.Domain;
using System.Collections.Generic;
using System.Linq;

namespace HCRUDEasy.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<TEntity> All()
        {
           return _context.Set<TEntity>().AsEnumerable();
        }

        public virtual TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);

            if (query.Any())
            {
                return query.First();
            }
            else
            {
                return null;
            }
        }

        public virtual void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }

}
