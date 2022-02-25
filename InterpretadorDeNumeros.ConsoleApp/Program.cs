using System;
using System.IO;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = "     __  __      __  __  __  __  __  __ " + Environment.NewLine +
                           "   | __| __||__||__ |__    ||__||__||  |" + Environment.NewLine +
                           "   ||__  __|   | __||__|   ||__| __||__|";

            System.IO.StringReader leitor = new System.IO.StringReader(dados);

            string primeiraLinha = leitor.ReadLine();
            char[] charLinhaUm = primeiraLinha.ToCharArray();
            string segundaLinha = leitor.ReadLine();
            char[] charLinhaDois = segundaLinha.ToCharArray();
            string terceiraLinha = leitor.ReadLine();
            char[] charLinhaTres = terceiraLinha.ToCharArray();

            string numeroFinal = "";
            string linhaUm = "";
            string linhaDois = "";
            string linhaTres = "";
            int contador = 0;

            for (int i = 0; i < 40; i++)
            {
                linhaUm = linhaUm + charLinhaUm[i];
                linhaDois += charLinhaDois[i];
                linhaTres += charLinhaTres[i];

                if (linhaUm == "    " && linhaDois == "   |" && linhaTres == "   |")
                {
                    numeroFinal = numeroFinal + "1";

                }
                else if (linhaUm == " __ " && linhaDois == " __|" && linhaTres == "|__ ")
                {
                    numeroFinal = numeroFinal + "2";
                }
                else if (linhaUm == " __ " && linhaDois == " __|" && linhaTres == " __|")
                {
                    numeroFinal = numeroFinal + "3";
                }
                else if (linhaUm == "    " && linhaDois == "|__|" && linhaTres == "   |")
                {
                    numeroFinal = numeroFinal + "4";
                }
                else if (linhaUm == " __ " && linhaDois == "|__ " && linhaTres == " __|")
                {
                    numeroFinal = numeroFinal + "5";
                }
                else if (linhaUm == " __ " && linhaDois == "|__ " && linhaTres == "|__|")
                {
                    numeroFinal = numeroFinal + "6";
                }
                else if (linhaUm == " __ " && linhaDois == "|__ " && linhaTres == "|__|")
                {
                    numeroFinal = numeroFinal + "6";
                }
                else if (linhaUm == " __ " && linhaDois == "   |" && linhaTres == "   |")
                {
                    numeroFinal = numeroFinal + "7";
                }
                else if (linhaUm == " __ " && linhaDois == "|__|" && linhaTres == "|__|")
                {
                    numeroFinal = numeroFinal + "8";
                }
                else if (linhaUm == " __ " && linhaDois == "|__|" && linhaTres == " __|")
                {
                    numeroFinal = numeroFinal + "9";
                }
                else if (linhaUm == " __ " && linhaDois == "|  |" && linhaTres == "|__|")
                {
                    numeroFinal = numeroFinal + "0";
                }

                contador++;
                if (contador == 4)
                {
                    linhaUm = "";
                    linhaDois = "";
                    linhaTres = "";
                    contador = 0;
                }

            }
            Console.WriteLine("===== Interpretador de Números =====");
            Console.WriteLine("");
            Console.WriteLine("Utilize esse programa para gerar a leitura dos números inseridos no programa e transformar em números comuns.");
            Console.WriteLine("");
            Console.WriteLine("===================================");
            Console.WriteLine("");

            Console.Write("Numero final: ");
            Console.WriteLine(numeroFinal);

            Console.WriteLine("");
            Console.Write("Aperte ENTER para fechar o programa.");
            Console.ReadLine();
        }
    }  
}
