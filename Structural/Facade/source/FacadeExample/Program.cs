// Create an Instance of Customer Class
using FacadeExample.Facade;
using FacadeExample.Models;

Customer customer = new()
{
    Name = "Pranaya",
    Email = "info@dotnettutorials.net",
    MobileNumber = "1234567890",
    Address = "BBSR, Odisha, India"
};
//Using Facade Class
CustomerRegistration customerRegistration = new();
customerRegistration.RegisterCustomer(customer);