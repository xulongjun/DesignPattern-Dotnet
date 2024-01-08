using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample.Subject
{
    // The RealSubject contains some core business logic. 
    // Usually, RealSubjects are capable of doing some useful work which may be very slow or sensitive 
    // A Proxy can solve these issues without any changes to the RealSubject's code.
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
