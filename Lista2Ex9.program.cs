using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            double b, c, d;

            Console.WriteLine("Calculo de IMC:");
            Console.Write("Sexo (mascolino (1) ou feminino (2):");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor do peso:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura:");
            c = double.Parse(Console.ReadLine());

            d = b / Math.Pow(c, 2);

            Console.Write($"Com o valor do IMC igual a {d}:");

            if (a == 1)
            {
                if (d < 19) { Console.WriteLine("Esta abaixo do peso."); }
                if (19 <= d && d < 24) { Console.WriteLine("Esta no peso ideal."); }
                if (d >= 24) { Console.WriteLine("Esta acima do Peso"); }
            }
            else if (a == 2)
            {
                if (d < 20) { Console.WriteLine("Esta abaixo do peso."); }
                if (20 <= d && d < 25) { Console.WriteLine("Esta no peso ideal."); }
                if (d >= 25) { Console.WriteLine("Esta acima do Peso"); }
            }
        }
    }
}
