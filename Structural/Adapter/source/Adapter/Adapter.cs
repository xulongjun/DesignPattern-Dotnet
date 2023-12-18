using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : ITarget
    {
        private Adaptee adaptee = new();
        public void Request()
        {
            // Possibly do some other work
            Console.WriteLine("Called some requests for the client");
            // and then call SpecificRequest
            adaptee.SpecificRequest();
        }
    }
}
