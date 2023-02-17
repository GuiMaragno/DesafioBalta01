using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta01
{
    public static class TextView
    {
        public static void Options()
        {
            Console.WriteLine("0) Sair\n");
            Console.WriteLine("1) Calcular quantidade de palavras");
            Console.WriteLine("2) Calcular quantidade de caracteres");
            Console.WriteLine("3) Calcular quantidade de vogais");
            Console.WriteLine("4) Calcular quantidade de consoantes");
            Console.WriteLine("5) Calcular tudo!\n");
        }

        public static void Result(string result, string option)
        {
            Console.WriteLine($"O resultado da quantidade de {option} é: {result}");
        }

        public static string InputText()
        {
            string text = "";

            Console.Write("Digite o Texto: ");
            text = Console.ReadLine();

            return text;

        }
    }
}
