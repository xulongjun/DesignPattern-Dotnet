namespace State.TrafficLight;

public interface ITrafficLightState
{
    string Name { get; }
    ITrafficLightState Next();
}

