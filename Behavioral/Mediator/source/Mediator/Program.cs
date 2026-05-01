using Mediator;

var mediator = new ConcreteMediator();
var componentA = new ComponentA(mediator);
var componentB = new ComponentB(mediator);

mediator.Register(componentA, componentB);

componentA.DoA();
componentB.DoB();

Console.WriteLine(string.Join(Environment.NewLine, mediator.Log));

