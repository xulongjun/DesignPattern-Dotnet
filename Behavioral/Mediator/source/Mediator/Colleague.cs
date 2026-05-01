namespace Mediator;

public abstract class Colleague
{
    protected readonly IMediator Mediator;

    protected Colleague(IMediator mediator)
    {
        Mediator = mediator;
    }
}

