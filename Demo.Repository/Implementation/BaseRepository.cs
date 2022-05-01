using Demo.Domain.Data;
using Demo.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Demo.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity) => _context.Set<T>().Add(entity);
        public IQueryable<T> Find(Expression<Func<T, bool>> expression) => _context.Set<T>().AsNoTracking().Where(expression);
        public IQueryable<T> GetAll() => _context.Set<T>().AsNoTracking();
        public T GetById(string id) => _context.Set<T>().Find(Guid.Parse(id));
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public async Task Commit() => await _context.SaveChangesAsync();
    }
}
