namespace State.TrafficLight;

public sealed class RedState : ITrafficLightState
{
    public string Name => "Red";
    public ITrafficLightState Next() => new GreenState();
}

public sealed class GreenState : ITrafficLightState
{
    public string Name => "Green";
    public ITrafficLightState Next() => new YellowState();
}

public sealed class YellowState : ITrafficLightState
{
    public string Name => "Yellow";
    public ITrafficLightState Next() => new RedState();
}

