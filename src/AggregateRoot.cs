using System.Collections.Generic;

namespace Akunich.Domain.Abstractions;

public class AggregateRoot<TKey> : Entity<TKey>
{
    private readonly List<IDomainEvent> _domainEvents;

    protected AggregateRoot()
    {
        _domainEvents = new List<IDomainEvent>();
    }
    
    public void RaiseDomainEvent(IDomainEvent @event) => _domainEvents.Add(@event);

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void ClearDomainEvents() => _domainEvents.Clear();
}