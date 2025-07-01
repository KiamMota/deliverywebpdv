namespace Domain.Core.Entities.Interfaces;
public interface IAggregate<TName>
{
    public TName Name { get; }
}

public interface IAggregateRoot { }

public interface IMyAggregate { }
