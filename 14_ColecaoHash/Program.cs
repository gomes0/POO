using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numerosUnicos = new HashSet<int>();

            Console.WriteLine("--- SIMULAÇÃO DE HASHSET ---");
            Console.WriteLine("Um HashSet armazena apenas elementos únicos.");

            ColetarEAdicionarNumeros(numerosUnicos, 10);

            ExibirResultado(numerosUnicos);

            Console.WriteLine("\nFim.");
        }
        public static void ColetarEAdicionarNumeros(HashSet<int> hashSet, int total)
        {
            int repetidos = 0;

            for (int sla = 1; sla <= total; sla++)
            {
                Console.Write($"\nDigite o {sla}º número (de 10): ");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (hashSet.Add(numero))
                    {
                        Console.WriteLine($"Número {numero} adicionado com sucesso.");
                    }
                    else
                    {
                        repetidos++;
                        Console.WriteLine($"Número {numero} é uma duplicata e foi ignorado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    sla--;
                }
            }
            Console.WriteLine($"\nTotal de duplicatas ignoradas: {repetidos}");
        }

        public static void ExibirResultado(HashSet<int> hashSet)
        {
            Console.WriteLine("\n" + new string('=', 47));
            Console.WriteLine("--- LISTA FINAL DE NÚMEROS (SEM DUPLICATAS) ---");
            Console.WriteLine(new string('=', 47));

            foreach (int item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
