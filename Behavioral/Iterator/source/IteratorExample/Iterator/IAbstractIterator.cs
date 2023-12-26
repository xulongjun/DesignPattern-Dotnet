using IteratorExample.Models;

namespace IteratorExample.Iterator
{
    // Iterator Interface
    // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
    internal interface IAbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}
