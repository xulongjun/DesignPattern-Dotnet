# C# Template Method Design Pattern
The Template Method design pattern defines the skeleton of an algorithm in a base class, letting subclasses override specific steps without changing the overall algorithm structure.<br>
>TemplateMethod : Defer the exact steps of an algorithm to a subclass.<br>

## Key idea
- The base class provides a **template** method (the algorithm).
- Subclasses customize steps (hooks/overrides) while the template remains stable.

