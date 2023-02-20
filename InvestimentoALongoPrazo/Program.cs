using System;

namespace EstruturaCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAÇOS DE REPETIÇÃO - FOR
            Console.WriteLine("INVESTINDO A LONGO PRAZO \n");

            double fatorRendimento = 1.005;
            double investimento = 1000;

            for (int anos = 1; anos <= 5; anos++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    investimento *= fatorRendimento;
                }
                fatorRendimento = fatorRendimento + 0.001;
            }

            Console.WriteLine("Depois de 5 anos você terá: R$ " + investimento);

            Console.WriteLine("--------------------------------- \n");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}