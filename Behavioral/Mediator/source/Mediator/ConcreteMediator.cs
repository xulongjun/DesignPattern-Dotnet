namespace Mediator;

public sealed class ConcreteMediator : IMediator
{
    private ComponentA? _componentA;
    private ComponentB? _componentB;
    private readonly List<string> _log = [];

    public void Register(ComponentA componentA, ComponentB componentB)
    {
        _componentA = componentA;
        _componentB = componentB;
    }

    public void Notify(Colleague sender, string @event)
    {
        if (_componentA is null || _componentB is null)
        {
            throw new InvalidOperationException("Mediator components are not registered.");
        }

        if (@event == "A")
        {
            _log.Add(_componentB.ReactToA());
            return;
        }

        if (@event == "B")
        {
            _log.Add(_componentA.ReactToB());
        }
    }

    public IReadOnlyList<string> Log => _log;
}

