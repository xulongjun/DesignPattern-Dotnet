using PrototypeExample.Models;

namespace PrototypeExample.Prototype
{
    public class DeepCloneEmployee
    {
        //Value type Property
        public required string Name { get; set; }
        //Reference type Property
        public required DeepAddress EmpAddress { get; set; }
        //Creating a Cloned Object of the Current Object
        public DeepCloneEmployee GetClone()
        {
            DeepCloneEmployee employee = (DeepCloneEmployee)MemberwiseClone();
            //The following Statement will make this a Deep Copy
            //Now, Cloned and Existing Object have different Memory Locations for the Address Object
            employee.EmpAddress = EmpAddress.GetClone();
            return employee;
        }
    }
}
