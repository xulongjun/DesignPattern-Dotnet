using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Leaf : IComponent
    {
        public string Name { get; set; }

        public Leaf(string name)
        {
            Name = name;
        }

        public void Add(IComponent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public void Remove(IComponent c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
