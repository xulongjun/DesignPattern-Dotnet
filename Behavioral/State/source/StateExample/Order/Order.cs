namespace StateExample.Order;

public sealed class Order
{
    private IOrderState _state = new DraftState();

    public string Status => _state.Name;

    public void Pay() => _state = _state.Pay();
    public void Ship() => _state = _state.Ship();
    public void Cancel() => _state = _state.Cancel();

    private interface IOrderState
    {
        string Name { get; }
        IOrderState Pay();
        IOrderState Ship();
        IOrderState Cancel();
    }

    private sealed class DraftState : IOrderState
    {
        public string Name => "Draft";
        public IOrderState Pay() => new PaidState();
        public IOrderState Ship() => throw new InvalidOperationException("Cannot ship a draft order.");
        public IOrderState Cancel() => new CancelledState();
    }

    private sealed class PaidState : IOrderState
    {
        public string Name => "Paid";
        public IOrderState Pay() => this;
        public IOrderState Ship() => new ShippedState();
        public IOrderState Cancel() => new CancelledState();
    }

    private sealed class ShippedState : IOrderState
    {
        public string Name => "Shipped";
        public IOrderState Pay() => this;
        public IOrderState Ship() => this;
        public IOrderState Cancel() => throw new InvalidOperationException("Cannot cancel a shipped order.");
    }

    private sealed class CancelledState : IOrderState
    {
        public string Name => "Cancelled";
        public IOrderState Pay() => this;
        public IOrderState Ship() => this;
        public IOrderState Cancel() => this;
    }
}

