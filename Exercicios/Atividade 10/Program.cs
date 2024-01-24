using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int al = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int ra = int.Parse(Console.ReadLine());

            // Verificar e exibir os relacionamentos de ordem
            if (al == ra)
            {
                Console.WriteLine($"{al} é igual a {ra}");
            }
            else
            {
                Console.WriteLine($"{al} não é igual a {ra}");
            }

            if (al != ra)
            {
                Console.WriteLine($"{al} é diferente de {ra}");
            }

            if (al > ra)
            {
                Console.WriteLine($"{al}  é maior do que  {ra}");
            }

            if (al < ra)
            {
                Console.WriteLine($"{al}  é menor do que  {ra}");
            }

            if (al >= ra)
            {
                Console.WriteLine($"{al}  é maior ou igual a  {ra}");
            }

            if (al <= ra)
            {
                Console.WriteLine($"{al} é menor ou igual a {ra}");
                Console.ReadKey();
            }
        }
    }
}
