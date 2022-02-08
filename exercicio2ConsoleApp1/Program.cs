using System;

namespace exercicio2ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("continue para saber quantos dias voce esta na terra!");
            Console.WriteLine("qual seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade ?");
            String idade = Console.ReadLine();
            int idades = Convert.ToInt32(idade);
            int dias = 365;
            Console.WriteLine($" ola{nome}, voce esta ha {dias} ocupando lugar na terra");
            Console.WriteLine();

        }
    }
}
