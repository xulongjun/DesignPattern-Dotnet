C# Prototype Design Pattern
The Prototype design pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.<br>
>Prototype : A fully initialized instance to be copied or cloned

## UML class diagram
![UML or Class Diagram ](Prototype_UML.png)

* Prototype: declares an interface for cloning itself
* ConcretePrototype: implements an operation for cloning itself
* Client: creates a new object by asking a prototype to clone itself