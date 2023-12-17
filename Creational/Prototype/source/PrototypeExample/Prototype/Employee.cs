using PrototypeExample.Models;

namespace PrototypeExample.Prototype
{
    public abstract class Employee
    {
        public required string Name { get; set; }
        public required Address EmpAddress { get; set; }
        public abstract Employee GetClone();
    }
}
