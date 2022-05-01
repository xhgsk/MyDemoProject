using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Demo.Repository.Interface
{
    public interface IBaseRepository<T>
        where T : class
    {
        T GetById(string id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        Task Commit();
    }
}
