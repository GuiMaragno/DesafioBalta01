using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "100";
            string text = "";

            do
            {
                Console.Clear();

                Console.WriteLine("\tDesafio do Balta!\n");

                Console.WriteLine("Escolha uma das opções abaixo:");

                TextView.Options();

                Console.Write("Opção: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        text = TextView.InputText();
                        TextView.Result(Counter.Words(text).ToString(), "palavras");
                        break;

                    case "2":
                        text = TextView.InputText();
                        TextView.Result(Counter.Characters(text).ToString(), "caracteres");
                        break;

                    case "3":
                        text = TextView.InputText();
                        TextView.Result(Counter.Vowels(text).ToString(), "vogais");
                        break;

                    case "4":
                        text = TextView.InputText();
                        TextView.Result(Counter.Consonant(text).ToString(), "consoantes");
                        break;

                    case "5":
                        text = TextView.InputText();
                        TextView.Result(Counter.Words(text).ToString(), "palavras");
                        TextView.Result(Counter.Characters(text).ToString(), "caracteres");
                        TextView.Result(Counter.Vowels(text).ToString(), "vogais");
                        TextView.Result(Counter.Consonant(text).ToString(), "consoantes");
                        break;

                }

                Console.WriteLine("\nAperte ENTER para continuar...");
                Console.ReadKey();
            } while (!option.Equals("0"));

            Console.WriteLine("Programa encerrado! Obrigado por usar!");
            Console.ReadKey();
        }
    }
}
