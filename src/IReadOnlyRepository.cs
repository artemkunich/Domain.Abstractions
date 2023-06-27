using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Akunich.Domain.Abstractions;

public interface IReadOnlyRepository<TEntity, in TKey>
{
    Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellation);

    Task<IEnumerable<TEntity>> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellation);
}