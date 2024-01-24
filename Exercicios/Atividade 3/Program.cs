using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usei string por que o id e o codigo da peça podem conter
            // numero e letra por causa da quantidade
            Console.Write("Informe o ID do vendedor: ");
            string idvendedor = Console.ReadLine();

            Console.Write("Informe o código da peça: ");
            string codigoPeca = Console.ReadLine();

            Console.Write("Informe o preço unitário da peça: ");
            double precopeca = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade vendida: ");
            int quantdevendas = int.Parse(Console.ReadLine());

            // Calcular o total de vendas
            double total = precopeca * quantdevendas;

            // 5% do total de vendas
            double comissao = total * 0.05;

            // Exibir os resultados
            Console.WriteLine("\nResumo da venda:");
            Console.WriteLine($"ID do vendedor: {idvendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Preço unitário da peça: {precopeca:C}");
            Console.WriteLine($"Quantidade vendida: {quantdevendas}");
            Console.WriteLine($"Total de vendas: {total:C}");
            Console.WriteLine($"Comissão (5%): {comissao:C}");

            // Aguardar o usuário pressionar uma tecla antes de fechar o programa
            Console.ReadKey();
        }
    }
}
