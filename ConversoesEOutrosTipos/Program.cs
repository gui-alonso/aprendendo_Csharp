using System;

namespace ConversoesEOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // OUTROS TIPOS DE VARIÁVEIS
            /*
             * long => variável de 64 bits
             * short
             * float
             */
            double salario;
            salario = 8426.37;
            Console.WriteLine(salario);

            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            float altura = 1.85f;
            Console.WriteLine(altura);

            long x = 2000000000000000000;
            Console.WriteLine(x);

            short y = 15000;
            Console.WriteLine(y);

            Console.WriteLine("------------------");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
