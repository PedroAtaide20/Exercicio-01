using System;

namespace exercicio4ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario bom e salario alto");
            Console.WriteLine("Qual seu salario atual ? ");
            double inicial = double.Parse(Console.ReadLine());
            double final = inicial * 1.15;
            double final2 = final * 0.92;
            Console.WriteLine($"Seu novo salario ficou R${final: F2}, porem com os impostos, ficou R${final2: F2}");
            Console.WriteLine();

        }
    }
}
