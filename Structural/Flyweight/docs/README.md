
# C# Flyweight Design Pattern
The Flyweight design pattern is used to reduce memory usage by sharing as much data as possible with similar objects. It separates **intrinsic state** (shared) from **extrinsic state** (provided by the client at runtime).<br>
>Flyweight : A fine-grained instance used for efficient sharing.<br>

## Key idea
- Store **intrinsic state** (heavy, reusable) inside the flyweight object.
- Provide **extrinsic state** (context-specific) at call time.
- Use a **factory** to reuse existing flyweights instead of creating new ones.

## Where it helps
- Many objects with shared data (e.g., characters/glyphs, tiles, icons).
- Memory pressure due to large numbers of similar instances.

