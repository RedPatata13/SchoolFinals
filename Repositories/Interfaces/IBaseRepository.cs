using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Repositories.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
    {
        T GetById(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPagitized(int page, int pageSize, Func<T, bool> filter = null!);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
    }
}
