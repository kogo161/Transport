using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Transport.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> All();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);

        // IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
        //     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //     string includeProperties = "");
    }
}