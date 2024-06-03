using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HotPotToYou.Domain.Common.Interfaces;

namespace HotPotToYou.Domain.Repositories
{
    public interface IEFRepository<TDomain, TPersistence> : IRepository<TDomain>
    {
        IUnitOfWork UnitOfWork { get; }
        Task<TDomain?> FindAsync(Expression<Func<TPersistence, bool>> filterExpression, CancellationToken cancellationToken = default);
        Task<List<TDomain>> FindAllAsync(Expression<Func<TPersistence, bool>> filterExpression, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(Expression<Func<TPersistence, bool>> filterExpression, CancellationToken cancellationToken = default);
        Task<IPagedResult<TDomain>> FindAllAsync(Expression<Func<TPersistence, bool>> filterExpression, int pageNo, int pageSize, CancellationToken cancellationToken = default);
        Task<Dictionary<TKey, TValue>> FindAllToDictionaryAsync<TKey, TValue>(
        Expression<Func<TPersistence, bool>> filterExpression,
        Expression<Func<TPersistence, TKey>> keySelector,
        Expression<Func<TPersistence, TValue>> valueSelector,
        CancellationToken cancellationToken = default);
    }
}
