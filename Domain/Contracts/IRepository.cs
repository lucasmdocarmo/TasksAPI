using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
