using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qua;
            int qub;
            
            Console.WriteLine("Insira a quantidade minima de produtos?");
            qua = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade máxima de produtos?");
            qub = int.Parse(Console.ReadLine());

            double med = (qua + qub) / 2;

            Console.WriteLine("A média de produtos no estoque é " + med);
            
            Console.ReadLine();

        }
    }
}
