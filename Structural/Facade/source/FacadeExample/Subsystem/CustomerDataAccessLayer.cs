using FacadeExample.Models;

namespace FacadeExample.Subsystem
{
    public class CustomerDataAccessLayer
    {
        public bool SaveCustomer(Customer customer)
        {
            //Save the Customer in the Database
            Console.WriteLine("\nCustomer Saved into the Database...");
            return true;
        }
    }
}
