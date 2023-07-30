using StockProject;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                p[i] = new Produto(name, preco);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += p[i].Preco;
            }
            Console.WriteLine(sum/n);

        }
    }
}