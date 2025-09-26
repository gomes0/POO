using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> minhaPilha = new Stack<int>();

            Console.WriteLine("--- Pilha ---");
            Console.WriteLine("A ORDEM DA PILHA É POR INSERÇÃO! (do ultimo número que voce inseriu, até o primeiro.)");

            ColetarNumeros(minhaPilha, 5);

            Console.WriteLine("\n" + new string('=', 40));

            ExibirUltimoInserido(minhaPilha);

            Console.WriteLine("\n--- Números na ordem que você inseriu ---");
            ExibirTodosElementos(minhaPilha);

            Console.WriteLine("\nFim.");
        }

        public static void ColetarNumeros(Stack<int> pilha, int total)
        {
            for (int slaa = 1; slaa <= total; slaa++)
            {
                Console.Write($"\nDigite o {slaa}º número para a pilha: ");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    pilha.Push(numero);
                    Console.WriteLine($"Número {numero} inserido (Topo da Pilha).");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    slaa--;
                }
            }
        }

        public static void ExibirUltimoInserido(Stack<int> pilha)
        {
            Console.WriteLine("     --- INFORMAÇÃO DA PILHA ---");
            Console.WriteLine(new string('=', 40));

            if (pilha.Count > 0)
            {
                int ultimoInserido = pilha.Peek();
                Console.WriteLine($"O último número inserido (Topo da Pilha) foi: {ultimoInserido}");
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }
        }

        public static void ExibirTodosElementos(Stack<int> pilha)
        {
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}

