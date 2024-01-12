using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // The base Component class declares the common operations for both simple and complex objects.
    public interface IComponent
    {
        public void Add(IComponent c);
        public void Remove(IComponent c);
        public void Display(int depth);
    }
}
