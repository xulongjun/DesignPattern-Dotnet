﻿using IteratorExample.Aggregate;
using IteratorExample.Models;

namespace IteratorExample.Iterator
{
    // ConcreteIterator Class
    public class Iterator : IAbstractIterator
    {
        //ConcreteAggregate variable to hold the collection elements
        private readonly ConcreteCollection Collection;
        //The following variable is used as the Index Position 
        //to access the elements of the collection
        private int Current = 0;
        //The following variable is used to move to the next element from the current element
        private readonly int Step = 1;
        // Constructor
        public Iterator(ConcreteCollection Collection)
        {
            //Initializing the ConcreteAggregate variable using Constructor
            this.Collection = Collection;
        }
        // Gets First Item from the Collection
        public Elempoyee First()
        {
            //Setting Current as 0 to access the First Element of the Sequence
            Current = 0;
            return Collection.GetEmployee(Current);
        }
        // Gets Next Item from the Collection
        public Elempoyee? Next()
        {
            //Increase the Current Index Position by step (Step = 1), 
            //to access the Next Element from the collection
            Current += Step;
            return !IsCompleted ? Collection.GetEmployee(Current) : null;
        }
        // Check whether the iteration is complete
        public bool IsCompleted
            //When Current >= Collection.Count, means we have accessed all the elements
            => Current >= Collection.Count;
    }
}
