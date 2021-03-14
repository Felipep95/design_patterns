using System;
using System.Collections.Generic;
using System.Text;
using TrabalhoDesignPatterns.Payments_Methods;
using TrabalhoDesignPatterns.Payments_Screens;

namespace TrabalhoDesignPatterns
{
    class Screen
    {
        public double _Price { get; set; } = 200;

        public Screen()
        {
            
        }

        public void CreditCard()
        {
            CreditCard creditCard = new CreditCard();
            creditCard.PaymentsScreen();
            creditCard.setPrice(500);
        }

        public void DebitCard()
        {
            DebitCard debitCard = new DebitCard();
            debitCard.PaymentsScreen();
            debitCard.setPrice(200);
        }

        public void Ticket()
        {
            Ticket ticket = new Ticket();
            ticket.PaymentsScreen();
            ticket.setPrice(50);
        }
    }
}
