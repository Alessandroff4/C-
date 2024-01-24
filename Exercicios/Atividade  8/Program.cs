using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio da lata de óleo: ");
            double ra = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da lata de óleo: ");
            double al = double.Parse(Console.ReadLine());

            // Calcular o volume usando a fórmula V = 3.14159 * R * R * A
            double vol = (3.14159 * ra * ra * al);

            // utilizando o $ para mostar o que tem nas chaves e o :F2 pra mostrar
            // somente 2 casas decimais eu mudei os outros codigos
            Console.WriteLine($"O volume da lata de óleo é: {vol:F2} unidades cúbicas");

            Console.ReadKey();
        }
    }
}
