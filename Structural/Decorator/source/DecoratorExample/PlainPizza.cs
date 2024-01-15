using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    // Concrete Components provide default implementations of the operations.
    public class PlainPizza : IPizza
    {
        public string MessageTest { get; set; }
        //The following MakePizza method returns the default Pizza
        public string MakePizza()
        {
            MessageTest = "Plain Pizza";
            return MessageTest;
        }
    }
}
