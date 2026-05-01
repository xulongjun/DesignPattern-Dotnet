# C# Visitor Design Pattern
The Visitor design pattern lets you define a new operation without changing the classes of the elements on which it operates. You add behavior by creating a visitor that implements that operation.<br>
>Visitor : Defines a new operation to a class without change.<br>

## Key idea
- **Elements** expose an `Accept(visitor)` method.
- **Visitors** implement operations for each concrete element type.

