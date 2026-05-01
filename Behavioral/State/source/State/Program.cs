using State.TrafficLight;

var light = new TrafficLightContext(new RedState());
Console.WriteLine(light.State.Name);

light.Tick();
Console.WriteLine(light.State.Name);

light.Tick();
Console.WriteLine(light.State.Name);

