using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicana.Data.Core.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(params object[] id);
        T Add(T entity);
        T Update(T entity);
        bool Delete(params object[] id);
    }
}
