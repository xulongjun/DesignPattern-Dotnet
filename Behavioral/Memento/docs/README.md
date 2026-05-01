# C# Memento Design Pattern
The Memento design pattern captures and externalizes an object's internal state so that the object can be restored to this state later, without violating encapsulation.<br>
>Memento : Capture and restore an object's internal state.<br>

## Key idea
- **Originator** creates a **Memento** that stores its state.
- **Caretaker** keeps mementos (history) but does not inspect their content.

