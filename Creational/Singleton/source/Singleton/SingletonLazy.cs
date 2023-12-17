using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> instance = new(() => new SingletonLazy());

        private SingletonLazy() { }

        public static SingletonLazy Instance { get { return instance.Value; } }

        public string Data => "Singleton Data";
    }
}
