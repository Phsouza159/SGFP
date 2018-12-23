using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGFP.Domain.Interfaces.Commom
{
    public interface IBaseRepository<T> where T : class
    {
       void add(T ob);

       bool Update(T ob);

       bool IdExist(Guid id);

       bool delete(T ob);

       ICollection<T> GetAll();

       T getById(Guid id);

        void BeginTransition();

        void RowlBack();

        bool Commit();

        T ObterPor(Func<T, bool> where, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> Listar(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> Include(IQueryable<T> query, params Expression<Func<T, object>>[] includeProperties);
    }
}
