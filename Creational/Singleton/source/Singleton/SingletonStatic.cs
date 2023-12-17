using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //SingletonStatic
    public sealed class SingletonStatic
    {
        private static readonly SingletonStatic instance = new();

        // Static constructors in C# are specified to execute only once per Application Domain, and they are thread-safe. This is a simpler approach but with a slight difference in behavior compared to Lazy<T>: the instance is created when the class is first loaded, not the first time it is accessed.
        // In this implementation, the static constructor doesn't actually do anything, but it's presence ensures the static fields are initialized in a thread-safe manner.
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        static SingletonStatic() { }
        private SingletonStatic() { }

        public static SingletonStatic Instance { get { return instance; } }

        public string Data => "Singleton Data";
    }
}
