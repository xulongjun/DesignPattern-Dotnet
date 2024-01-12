using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    // The Composite class represents the complex components that have children. 
    // The Composite objects delegate the actual work to their children and then combine the result.
    public class Composite : IComponent
    {
        List<IComponent> children = new List<IComponent>();
        // Constructor
        public string Name { get; set; }

        public Composite(string name)
        {
            Name = name;
        }

        public void Add(IComponent component)
        {
            children.Add(component);
        }
        public void Remove(IComponent component)
        {
            children.Remove(component);
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            // Recursively display child nodes
            foreach (IComponent component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
