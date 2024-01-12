using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    // The base Component class declares the common operations for both simple and complex objects.
    public interface IComponent
    {
        void DisplayPrice();
    }
}
