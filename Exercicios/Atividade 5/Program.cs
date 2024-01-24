using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            double tempGasto = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média (em Km/h): ");
            double velMed = double.Parse(Console.ReadLine());
         
            // Calcular a distância percorrida
            double dist = tempGasto * velMed;

            // Calcular a quantidade de litros de combustível utilizada
            double litUsa = dist / 12;


            // Exibir os resultados
            Console.WriteLine($"Velocidade média: {velMed} Km/h");
            Console.WriteLine($"Tempo gasto na viagem: {tempGasto} horas");
            Console.WriteLine($"Distância percorrida: {dist} Km");
            Console.WriteLine($"Quantidade de litros utilizada: {litUsa} litros");
            Console.ReadKey();
        }
    }
}
