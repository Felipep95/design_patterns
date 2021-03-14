using TrabalhoDesignPatterns.Payments_Methods;

namespace TrabalhoDesignPatterns.Interfaces
{
    interface IAbstractPaymentsType
    {
        public CreditCard GetCreditCardPaymentScreen();
        public DebitCard GetDebitCardPaymentScreen();
        public Ticket GetTicketPaymentScreen();

    }
}
