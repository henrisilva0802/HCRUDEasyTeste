using System;
using System.Collections.Generic;
using System.Text;

namespace HCRUDEasy.Domain
{
    public interface IGenericRepository<TEntity>
    {
        TEntity GetById(int id);
        void Save(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> All();
    }
}
