using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Digite um número ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número ");
            d = int.Parse(Console.ReadLine());

            int al = (a + b);
            int ab = (a + c);
            int ac = (a + d);
            int ad = (b + c);
            int ae = (b + d);
            int ak = (c + d);

            int ar = (a * b);
            int at = (a * c);
            int av = (a * d);
            int ay = (b * c);
            int ai = (b * d);
            int af = (c * d);

            Console.WriteLine("A soma de A  + B é " + al);
            Console.WriteLine("A soma de A  + C é " + ab);
            Console.WriteLine("A soma de A  + D é " + ac);
            Console.WriteLine("A soma de B  + C é " + ad);
            Console.WriteLine("A soma de B  + D é " + ae);
            Console.WriteLine("A soma de C  + D é " + ak);
            Console.WriteLine("A multiplicação de A x B é " + ar);
            Console.WriteLine("A multiplicação de A x C é " + at);
            Console.WriteLine("A multiplicação de A x D é " + av);
            Console.WriteLine("A multiplicação de B x C é " + ay);
            Console.WriteLine("A multiplicação de B x D é " + ai);
            Console.WriteLine("A multiplicação de C x D é " + af);

            Console.ReadKey();
        }
    }
}
