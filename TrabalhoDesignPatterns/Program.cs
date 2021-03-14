using System;

namespace TrabalhoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            
            Console.Write("\n 1 - Cartão de crédito \n 2 - Cartão de débito \n 3 - Boleto \n");
            
            Console.Write("\n Insira a forma de pagamento: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    screen.CreditCard();
                    break;
                case 2:
                    screen.DebitCard();
                    break;
                case 3:
                    screen.Ticket();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
