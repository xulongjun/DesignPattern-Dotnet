// Create a tree structure
using Composite;

Composite.Composite root = new Composite.Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));
Composite.Composite comp = new Composite.Composite("Composite X");
comp.Add(new Leaf("Leaf XA"));
comp.Add(new Leaf("Leaf XB"));
root.Add(comp);
root.Add(new Leaf("Leaf C"));
// Add and remove a leaf
Leaf leaf = new Leaf("Leaf D");
root.Add(leaf);
root.Remove(leaf);
// Recursively display tree
root.Display(1);