using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de graus Celsius pra graus Fahrenheit.");
            Console.WriteLine("Informe quantos graus Celsius: ");
            float cel = float.Parse(Console.ReadLine());

            // Calcular quantos graus usando a fórmula f = (9 * c + 160) / 5
            float fah = (9 * cel + 160) / 5;

            Console.WriteLine($"A temperatura é de {fah:F2} º Fahrenheit.");
            Console.ReadKey();
        }
    }
}
