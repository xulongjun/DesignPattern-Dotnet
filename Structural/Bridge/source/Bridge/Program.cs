using Bridge;

Abstraction a = new RefinedAbstraction(new ConcreteImplementorA());
// Set implementation and call
a.Operation();
// Change implemention and call
Abstraction b = new RefinedAbstraction(new ConcreteImplementorB());
b.Operation();