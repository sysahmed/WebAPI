using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public interface IRepository<T> where T : class
    {
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> predicate);
        IDataResult<T>GetById(int id);
        IDataResult<T> Get(Expression<Func<T, bool>> predicate);
        IDataResult<T> Add(T entity);
        IDataResult<T> Update(T entity);
        IResults Delete(T entity);
        IResults Delete(int id);
    }
}
