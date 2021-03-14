using TrabalhoDesignPatterns.Interfaces;
using TrabalhoDesignPatterns.Payments_Methods;

namespace TrabalhoDesignPatterns.Payments_Screens
{
    class PaymentScreen : IAbstractPaymentsType
    {
        public CreditCard GetCreditCardPaymentScreen()
        {
            return new CreditCard();
        }

        public DebitCard GetDebitCardPaymentScreen()
        {
            return new DebitCard();
        }

        public Ticket GetTicketPaymentScreen()
        {
            return new Ticket();
        }
    }
}
