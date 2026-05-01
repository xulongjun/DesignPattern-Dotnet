# C# Mediator Design Pattern
The Mediator design pattern defines an object that encapsulates how a set of objects interact. It promotes loose coupling by preventing objects from referring to each other explicitly, and it lets you vary their interaction independently.<br>
>Mediator : Defines simplified communication between classes.<br>

## Key idea
- **Colleagues** communicate through a **Mediator** instead of calling each other directly.
- This reduces dependencies between colleagues and centralizes interaction logic.

## Where it helps
- Many-to-many communication becomes hard to maintain (lots of direct references).
- You want to keep colleagues simpler, and move orchestration rules into one place.

