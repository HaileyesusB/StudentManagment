using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Seeds
{
  public interface IAsyncRepository <T> where T:BaseAuditableModels
    {
        Task<T>  AddAsync(T entity);
        bool Update(T entity);
        bool Delete(int Id);
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryAsync(Expression<Func<T, bool>> predicate);
    }
}
