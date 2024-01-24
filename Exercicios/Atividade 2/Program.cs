using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorreal, valordolar,  convertidoreal;

            Console.WriteLine("Conversor de moedas");
            Console.WriteLine("Quanto esta valendo o dolar");
            valordolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual Quantia em Real voce deseja Converter?");
            valorreal = double.Parse(Console.ReadLine());

            convertidoreal = valorreal / valordolar;

            Console.WriteLine("A Conversão de R$" + valorreal + " é: " + "$" + convertidoreal);

            Console.ReadKey();
        }
    }
}
