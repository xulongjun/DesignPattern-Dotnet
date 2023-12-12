using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExample.Product;

namespace FactoryExample.Creator
{
    //Factory Class to Produce the Products
    public static class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName)
            {
                case "PayPal":
                    return new PayPalGateway();
                case "Stripe":
                    return new StripeGateway();
                case "Credit Card":
                    return new CreditCardGateway();
                default:
                    throw new ArgumentException($"Invalid payment gateway specified : {gatewayName}");
            }
        }
    }
}
