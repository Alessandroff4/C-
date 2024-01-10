using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_de_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;
            Console.WriteLine("Digite um número de 0 a 10 que você deseja saber a tabuada. ");
            // comando para a entrada do numero
            numero = int.Parse(Console.ReadLine());
            // comando para verificar se o numero digitado e de 1 a 10
            if (numero < 0 || numero > 10)
            {
                Console.WriteLine("Por fazor digite um número de 0 a 10");
            }
            // o comando so vai executar se o if for falso
            else
            {

                // usei o comando while pro programa rodar codigo entre as chaves
                // ate que a condição seja falsa
                while (contador < 11)
                {
                    Console.WriteLine(numero + " X " + contador + " = " + numero * contador);

                    contador = contador + 1;
                }

                Console.ReadLine();
            }
        }
    }
}
