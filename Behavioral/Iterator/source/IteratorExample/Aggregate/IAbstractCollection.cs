namespace IteratorExample.Aggregate
{
    internal interface IAbstractCollection
    {
        // The following Method is going to Return an Iterator object.
        // Later, we will Implement the Iterator class
        Iterator.Iterator CreateIterator();
    }
}
