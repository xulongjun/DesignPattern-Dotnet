namespace FactoryExample.Product
{
    //Define the Product Interface
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
