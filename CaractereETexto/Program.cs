using System;

namespace CaractereETexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            Console.WriteLine("------------------");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
