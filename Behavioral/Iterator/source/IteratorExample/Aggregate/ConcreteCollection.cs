﻿using IteratorExample.Models;

namespace IteratorExample.Aggregate
{
    // ConcreteAggregate Class
    // The following class going to implement the Iterator interface to return an instance of the proper ConcreteIterator
    public class ConcreteCollection : IAbstractCollection
    {
        //The following collection object is going to hold a list of items or elements
        private readonly List<Elempoyee> listEmployees = [];
        //Implementing the CreateIterator method of the IAbstractCollection interface
        //The following method is going to Create and return the Iterator Object
        //Later we will implement the Iterator
        public Iterator.Iterator CreateIterator()
        {
            return new Iterator.Iterator(this);
        }

        // The following method is going to return the count of the elements present in the collection
        public int Count => listEmployees.Count;
        //Add items to the collection
        public void AddEmployee(Elempoyee employee)
        {
            listEmployees.Add(employee);
        }
        //Get items from the collection based on the Index Position
        //Index is started from 0
        public Elempoyee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
