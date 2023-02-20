using System;

namespace EstruturaCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAÇOS DE REPETIÇÃO - WHILE
            Console.WriteLine("CALCULA POUPANÇA \n");

            double investimento = 1000;
            // rendimento de  0.5% (0.005) ao mês

            //Console.WriteLine("Informe o valor do investimento");
            //investimento = float.Parse(Console.ReadLine());

            int mes = 1;
            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
                
                //mes = mes + 1;
                mes++;
            }

            Console.WriteLine("--------------------------------- \n");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}