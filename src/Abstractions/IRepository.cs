using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Akunich.Abstractions.Domain;

public interface IRepository<TAggregateRoot, in TKey>
{
    Task<TAggregateRoot> GetByIdAsync(TKey id, CancellationToken cancellation);

    Task<IEnumerable<TAggregateRoot>> GetByExpressionAsync(Expression<Func<TAggregateRoot, bool>> expression, CancellationToken cancellation);

    Task UpdateAsync(TAggregateRoot entity, CancellationToken cancellation);

    Task AddAsync(TAggregateRoot entity, CancellationToken cancellation);

    Task RemoveAsync(TAggregateRoot entity, CancellationToken cancellation);
}