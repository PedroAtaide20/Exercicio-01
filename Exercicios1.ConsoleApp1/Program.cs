using System;

namespace Exercicios1.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terrenos Retangulares!");
            Console.WriteLine("Qual a altura do Terreno");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a largura do terreno ?");
            float largura = float.Parse(Console.ReadLine());
            float area = altura * largura;
            Console.WriteLine($" A area do seu terreno é de {area}");
            Console.WriteLine();







        }
    }    
