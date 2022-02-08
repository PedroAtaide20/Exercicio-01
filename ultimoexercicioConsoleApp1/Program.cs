using System;

namespace ultimoexercicioConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HotPao, o melhor da Região");
            Console.WriteLine("numeros de paos vendidos:");
            double pao = double.Parse(Console.ReadLine());
            Console.WriteLine("numeros de broas vendidas:");
            double broas = double.Parse(Console.ReadLine());
            double totalpao = pao * 0.12;
            double totalbroas = broas * 1.5;
            double total = totalpao + totalbroas;
            Console.WriteLine($"valor adquirido hoje: {total} reais");
            Console.WriteLine("Pressioner ~enter~ para saber o quando guarda na poupança");
            Console.WriteLine();
            double poupança = total * 0.10;
            Console.WriteLine($"deve-se guardar:{poupança} reais");
            Console.WriteLine();

        }
    }
}
