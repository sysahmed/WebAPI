using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    //public class EfEntityRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    //{
    //    public TEntity Add(TEntity entity)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            var add = con.Entry(entity);
    //            add.State = EntityState.Added;
    //            con.SaveChanges();
    //            return add.Entity;
    //        }
    //    }

    //    public bool Delete(TEntity entity)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            var del = con.Entry(entity);
    //            del.State = EntityState.Deleted;
    //            con.SaveChanges();
    //            return true;
    //        }
    //    }

    //    public bool Delete(int id)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            var del = con.Set<TEntity>().Find(id);
    //            var delete = con.Entry(del);
    //            delete.State = EntityState.Deleted;
    //            con.SaveChanges();
    //            return true;
    //        }
    //    }

    //    public TEntity Get(Expression<Func<TEntity, bool>> predicate)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            return con.Set<TEntity>().SingleOrDefault(predicate);
    //        }
    //    }
    //    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            return predicate == null ? con.Set<TEntity>().ToList() :
    //                con.Set<TEntity>().Where(predicate).ToList();
    //        }
    //    }
    //    public List<TEntity> GetAll()
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            return con.Set<TEntity>().ToList();
    //        }
    //    }

    //    public TEntity GetById(int id)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            return con.Set<TEntity>().Find(id);
    //        }
    //    }

    //    public TEntity Update(TEntity entity)
    //    {
    //        using (TContext con = new TContext())
    //        {
    //            var update = con.Entry(entity);
    //            update.State = EntityState.Modified;
    //            con.SaveChanges();
    //            return update.Entity;
    //        }
    //    }

    //    IResults IRepository<TEntity>.Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
