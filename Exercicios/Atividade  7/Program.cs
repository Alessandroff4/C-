using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de graus Fahrenheit pra graus Celsius.");
            Console.WriteLine("Informe quantos graus Fahrenheit: ");
            float fah = float.Parse(Console.ReadLine());

            // Calcular quantos graus usando a fórmula c = f - 32 * 5 / 9
            float cel = ((fah - 32) * 5) / 9;

            Console.WriteLine($"A temperatura é de {cel:F2} º Celsius.");
            Console.ReadKey();
        }
    }
}
