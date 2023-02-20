using System;

namespace EstruturaCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA CONDICIONAL - IF/ELSE com OU(||)/E(&&)
            Console.WriteLine("ESTRUTURA CONDICIONAL - IF/ELSE com operadores lógicos \n");

            int idadeJoao = 15;
            int qtdPessoas = 0;

            if (idadeJoao >= 18 || qtdPessoas > 0)
            {
                Console.WriteLine("Pode entrar na festa!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");  
            }


            Console.WriteLine("--------------------------------- \n");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}