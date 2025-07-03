namespace Domain.Core.Entities.Interfaces
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
