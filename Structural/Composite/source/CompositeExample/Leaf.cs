using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeExample
{
    // The Leaf class represents the end objects. 
    // A leaf can't have any children.
    // The Leaf object is the Object which does the actual work
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string DisplayMessage { get; set;}

        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }
        public void DisplayPrice()
        {
            DisplayMessage = $"\tComponent Name: {Name} and Price: {Price}";
            Console.WriteLine(DisplayMessage);
        }
    }
}
