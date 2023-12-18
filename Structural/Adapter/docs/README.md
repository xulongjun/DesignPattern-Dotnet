# C# Adapter Design Pattern
The Adapter design pattern converts the interface of a class into another interface clients expect. This design pattern lets classes work together that couldn‘t otherwise because of incompatible interfaces. <br>
>Adapter : Match interfaces of different classes .<br>

## UML class diagram with example
![UML or Class Diagram with example](AdapterFactoryExample_UML.webp)

* Client: The Client class can only see the ITarget interface, i.e., the class that implements the ITarget interface, i.e., the Adapter (in our example, it is the EmployeeAdapter). Using that Adapter (EmployeeAdapter) object, the client will communicate with the Adaptee, which is incompatible with the client.
* ITarget: This is going to be an interface that needs to be implemented by the Adapter. The client can only see this interface, i.e., the class which implements this interface.
* Adapter: This class makes two incompatible interfaces or systems work together. The Adapter class implements the ITrager interface and provides the implementation for the interface method. This class is also composed of the Adaptee, i.e., it has a reference to the Adaptee object as we are using the Object Adapter Design Pattern. In our example, the EmployeeAdapter class implements the ITarget Interface and provides implementations to the ProcessCompanySalary method of the ITarget Interface. This class also has a reference to the ThirdPartyBillingSystem object.
* Adaptee: This class contains the client’s required functionality but is incompatible with the existing client code. So, it requires some adaptation or transformation before the client can use it. It means the client will call the Adapter, and the Adapter will do the required conversions and then make a call to the Adaptee.