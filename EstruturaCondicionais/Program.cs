using System;

namespace EstruturaCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA CONDICIONAL - IF/ELSE
            Console.WriteLine("ESTRUTURA CONDICIONAL - IF/ELSE \n");

            int idadeJoao = 16;
            int qtdPessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Pode entrar na festa!");
            } else
            {
                if (qtdPessoas > 0)
                {
                    Console.WriteLine("Você está acompanhado.. Pode entrar!");
                } else
                {
                    Console.WriteLine("Não pode entrar sem acompanhante!");
                }
            }


            Console.WriteLine("---------------------------- \n");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}