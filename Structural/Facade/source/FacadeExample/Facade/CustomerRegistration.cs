using FacadeExample.Models;
using FacadeExample.Subsystem;

namespace FacadeExample.Facade
{
    public class CustomerRegistration
    {
        public bool RegisterCustomer(Customer customer)
        {
            //Step1: Validate the Customer
            Validator validator = new();
            _ = validator.ValidateCustomer(customer);
            //Step1: Save the Customer Object into the database
            CustomerDataAccessLayer customerDataAccessLayer = new();
            _ = customerDataAccessLayer.SaveCustomer(customer);
            //Step3: Send the Registration Email to the Customer
            Email email = new();
            _ = email.SendRegistrationEmail(customer);
            return true;
        }
    }
}
