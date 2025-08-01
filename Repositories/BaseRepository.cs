using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Y2S1_INC_Compliance_proj.Data;

namespace Finals.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public virtual void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} cannot be null.");

            _dbSet.Add(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dbSet.Remove(entity);
        }
        public virtual T GetById(string id)
        {
            var t = _dbSet.Find(id);
            if (t == null) return null!;
            return t;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }
        public IEnumerable<T> GetPagitized(int page, int pageSize, Func<T, bool> filter = null!)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) throw new ArgumentException("Page size must be 1 or greater", nameof(pageSize));

            var query = _dbSet.AsNoTracking().AsQueryable();
            if (filter != null) query = query.Where(filter).AsQueryable();

            int totalRecords = query.Count();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            if (page > totalPages && totalPages > 0)
                page = totalPages;

            return query.Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} cannot be null.");

            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
