using System;
using TrabalhoDesignPatterns.Interfaces;

namespace TrabalhoDesignPatterns.Payments_Methods
{
    class DebitCard : IDebitCardPayment
    {
        private double _Price { get; set; }
        public void PaymentsScreen()
        {
            Console.WriteLine("\n Pagamento via cartão de débito.");
        }

        public void setPrice(double price)
        {
            _Price = price;
            Console.WriteLine($"Valor a pagar: R$ {_Price}");
        }
    }
}
