using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro de 0 a 99:");
        string tex = Console.ReadLine();
        
        // comando para so poder ser inserido numeros de 0 a 99
        if (int.TryParse(tex, out int num) && num >= 0 && num <= 99)
        {
            string numtex = ConvertNumberToWords(num);
            Console.WriteLine($"Por extenso fica: {numtex}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
        }

        Console.ReadKey();
    }

    static string ConvertNumberToWords(int nume)
    {
        // Se o numero for 0, a função retorna "zero", como zero é um caso especial
        if (nume == 0)
        {
            return "zero";
        }

        //  se o numero for negativo, ela adiciona menos. 
        if (nume < 0)
        {
            return "menos " + ConvertNumberToWords(Math.Abs(nume));
        }

        string words = "";

        if (nume > 0)
        {
            if (words != "")
            {
                words += "e ";
            }
            // se numero for corespondente vai add a palavra correspondente
            string[] units = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] teens = { "dez", "onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] tens = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

            if (nume < 10)
            {
                words += units[nume];
            }
            else if (nume < 20)
            {
                words += teens[nume - 10];
            }
            else
            {
                words += tens[nume / 10];
                if ((nume % 10) > 0)
                {
                    words += " e " + units[nume % 10];
                }
            }
        }

        return words.Trim();
    }
}