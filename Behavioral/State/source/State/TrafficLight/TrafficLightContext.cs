namespace State.TrafficLight;

public sealed class TrafficLightContext
{
    public TrafficLightContext(ITrafficLightState initialState)
    {
        State = initialState;
    }

    public ITrafficLightState State { get; private set; }

    public void Tick()
    {
        State = State.Next();
    }
}

