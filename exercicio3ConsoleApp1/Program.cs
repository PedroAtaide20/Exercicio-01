using System;

namespace exercicio3ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Celcius? Nao obigado, quero em Fahrenhiet");
            Console.WriteLine("graus em celsius: ");
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;
            Console.WriteLine($"°{C} Graus Celsius, é igual a °{F} Fihrenhiet");
            Console.WriteLine();
        }
    }
}
