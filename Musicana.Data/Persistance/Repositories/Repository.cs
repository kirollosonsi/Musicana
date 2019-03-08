using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core.Repositories;

namespace Musicana.Data.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T:class
    {
        MusicanaEntities _ctx;

        public Repository(DbContext ctx)
        {
            _ctx = ctx as MusicanaEntities;
        }
        public T Add(T entity)
        {
           return _ctx.Set<T>().Add(entity);
        }

        public bool Delete(params object[] id)
        {
            T entity = _ctx.Set<T>().Find(id);
            if (entity == null)
                return false;

            _ctx.Set<T>().Remove(entity);
            return true;
        }

        public IEnumerable<T> GetAll()
        {
           return _ctx.Set<T>();
        }

        public T GetById(params object[] id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
