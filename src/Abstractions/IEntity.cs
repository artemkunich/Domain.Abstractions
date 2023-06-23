namespace Akunich.Abstractions.Domain;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}