using System;
using TrabalhoDesignPatterns.Interfaces;

namespace TrabalhoDesignPatterns.Payments_Methods
{
    class CreditCard : ICreditCardPayment
    {
        private double _Price;
        public void PaymentsScreen()
        {
            Console.WriteLine("\n Pagamento via cartão de crédito.");
        }

        public void setPrice(double price)
        {
            _Price = price;
            Console.WriteLine($"Valor a pagar: R$ {_Price}");
        }
    }
}
