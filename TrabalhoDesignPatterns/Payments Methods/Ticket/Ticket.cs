using System;
using TrabalhoDesignPatterns.Interfaces;

namespace TrabalhoDesignPatterns.Payments_Methods
{
    class Ticket : ITicketPayment
    {

        private double _Price { get; set; }
        public void PaymentsScreen()
        {
            Console.Write("\n Pagamento via Boleto bancário");
        }

        public void setPrice(double price)
        {
            _Price = price;
            Console.WriteLine($"Valor a pagar: R$ {_Price}");
        }
    }
}
