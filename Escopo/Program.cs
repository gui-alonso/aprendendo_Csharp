using System;

namespace EstruturaCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA CONDICIONAL - IF/ELSE com OU(||)/E(&&)
            Console.WriteLine("ESTRUTURA CONDICIONAL - IF/ELSE com operadores lógicos \n");

            int idadeJoao = 19;
            int qtdPessoas = 0;

            bool acompanhado = qtdPessoas > 1;

            string textoAdicional;

            if (acompanhado == true)
            {
                textoAdicional = "João está acompanhado!";
            } else
            {
                textoAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine(textoAdicional);
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