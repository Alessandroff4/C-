using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    
    { // Ativadide pra o uso de variaveis, cauculo de media de idade
        static void Main(string[] args)
        {
        int idadeJoao = 10;
        int idadeMaria = 25;
        int idadeCarlos = 30;
        // Calcule a média das idades.
        double mediaIdades = (idadeJoao + idadeMaria + idadeCarlos) / 3.0;
        // Exiba o resultado em um MessageBox.
        Console.WriteLine("A média das idades é: " + mediaIdades);
        Console.ReadLine();
    }
    }
}
