using SGFP.Domain.Interfaces.Commom;
using SGFP.Infra.DAO.DbContexto;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;

namespace SGFP.Infra.Repository.Commom
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : RepositoryPropriedades
    {
        protected readonly DbContexto db;

        public BaseRepository(DbContexto db)
        {
            this.db = db;
        }

        public void add(TEntity ob)
        {
            db.Add(ob);
        }

        public bool Update(TEntity ob)
        {
            db.Update(ob);
            return false;
        }

        public bool IdExist(Guid id) => db.Set<TEntity>().Any(p => p.Id.Equals(id));

        public bool delete(TEntity ob)
        {
            db.Set<TEntity>().Remove(ob);
            return false;
        }

        public ICollection<TEntity> GetAll() => db.Set<TEntity>().ToList();

        public TEntity getById(Guid id) => db.Set<TEntity>().Find(id);
            

        public void BeginTransition() { }

        public void RowlBack() => db.SaveChanges(); 

        public bool Commit() => Convert.ToBoolean(db.SaveChanges());



        public IQueryable<TEntity> ListarPor(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Listar(includeProperties).Where(where);
        }



        public TEntity ObterPor(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Listar(includeProperties).FirstOrDefault(where);
        }



        public IQueryable<TEntity> Listar(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = db.Set<TEntity>();

            if (includeProperties.Any())
            {
                return Include(db.Set<TEntity>(), includeProperties);
            }

            return query;
        }



        public IQueryable<TEntity> Include(IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query;
        }

    }
}
