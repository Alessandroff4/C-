using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Jogadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");

            // Lê e converte para int
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                // Verifica a categoria
                if (idade <= 18)
                {
                    Console.WriteLine("Você jogará na categoria Juvenil.");
                }
                else if (idade >= 23)
                {
                    Console.WriteLine("Você pode jogar na categoria Profissional.");
                }
                else
                {
                    Console.WriteLine("Você não está na categoria Juvenil, mas também não está na Profissional.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira uma idade válida.");
            }
                Console.ReadKey();
        }
    }
}
