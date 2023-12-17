# C# Factory Method Design Pattern
The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses. <br>
>Factory : Creates an instance of several derived classes

## UML class diagram
![UML or Class Diagram ](Factory_UML.png)

* Product: This is the interface or abstract class defining the product the factory method will create.
* ConcreteProduct: These are the specific implementations of the Product interface or abstract class.
* Creator: This abstract class or interface declares the FactoryMethod().
* ConcreteCreator: Subclasses of Creator that implement the FactoryMethod() to produce ConcreteProduct instances.