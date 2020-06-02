using System;

namespace Aula_08_Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito card = new CartaoCredito();

            System.Console.WriteLine("Digite a data do pagamento:");
            card.data = DateTime.Parse( Console.ReadLine() );
            System.Console.WriteLine("Data digitada: "+card.data);
            
        }
    }
}
