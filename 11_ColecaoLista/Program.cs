using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Lista ---");

            List<string> listaDeNomes = ColetarNomes();

            ExibirNomes(listaDeNomes);

            Console.WriteLine("--- Fim do Programa ---");
        }

    private static List<string> ColetarNomes()
        {
            List<string> nomes = new List<string>();
            bool continuar = true;

            while (continuar)
            {
                Console.Write($"\nDigite o {nomes.Count + 1}º nome (mínimo 3 caracteres): ");

                string nomeDigitado = Console.ReadLine();
                string nomeLimpo = nomeDigitado?.Replace(" ", "");

                if (!string.IsNullOrEmpty(nomeLimpo) && nomeLimpo.Length >= 3)
                {
                    nomes.Add(nomeLimpo);
                    Console.WriteLine($"Nome '{nomeLimpo}' adicionado. Total: {nomes.Count}");

                    continuar = PerguntarSeContinua();
                }
                else
                {
                    Console.WriteLine("ERRO: O nome deve ter no mínimo 3 caracteres.");
                    continuar = PerguntarSeContinua();
                }
            }
            return nomes;
        }

        private static bool PerguntarSeContinua()
        {
            Console.Write("Deseja continuar a adicionar nomes? (S/N): ");
            string resposta = Console.ReadLine()?.Replace(" ", "").ToUpper();
            return resposta == "S";
        }

        private static void ExibirNomes(List<string> nomes)
        {
            Console.WriteLine("\n--- Relatório Final ---");

            if (nomes.Any())
            {
                Console.WriteLine($"Total de nomes digitados: {nomes.Count}\n");

                for (int i = 0; i < nomes.Count; i++)
                {
                    Console.WriteLine($"Nome {i + 1}: {nomes[i]}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum nome foi adicionado à lista para exibição.");
            }
        }
    }
}
