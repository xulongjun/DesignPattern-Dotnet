C# Singleton Design Pattern
The Singleton design pattern ensures a class has only one instance and provide a global point of access to it. <br>
>Singleton : A class in which only a single instance can exist

## Lazy method
This Singleton implementation is thread-safe without the need for explicit locks due to the use of Lazy<T>. The Lazy<T> type handles the thread safety of object creation and ensures that the Singleton instance is created only once.

## Static method
Static constructors in C# are specified to execute only once per Application Domain, and they are thread-safe. This is a simpler approach but with a slight difference in behavior compared to Lazy<T>: the instance is created when the class is first loaded, not the first time it is accessed.In this implementation, the static constructor doesn't actually do anything, but it's presence ensures the static fields are initialized in a thread-safe manner.