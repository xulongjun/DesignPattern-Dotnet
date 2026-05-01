namespace Mediator;

public sealed class ComponentA(IMediator mediator) : Colleague(mediator)
{
    public void DoA()
    {
        Mediator.Notify(this, "A");
    }

    public string ReactToB()
    {
        return "A reacted to B";
    }
}

public sealed class ComponentB(IMediator mediator) : Colleague(mediator)
{
    public void DoB()
    {
        Mediator.Notify(this, "B");
    }

    public string ReactToA()
    {
        return "B reacted to A";
    }
}

