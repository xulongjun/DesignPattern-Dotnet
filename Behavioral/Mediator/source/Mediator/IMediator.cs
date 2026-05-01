namespace Mediator;

public interface IMediator
{
    void Register(ComponentA componentA, ComponentB componentB);
    void Notify(Colleague sender, string @event);
}

