using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaAtendimento = new Queue<string>();

            Console.WriteLine("--- FILA DE ATENDIMENTO ---");

            ColetarNomes(filaAtendimento);

            if (filaAtendimento.Count < 3)
            {
                Console.WriteLine("\nNão há 3 pessoas na fila.");

                ExibirFilaRestante(filaAtendimento);
                return;
            }

            ProcessarAtendimentos(filaAtendimento);

            ExibirFilaRestante(filaAtendimento);

            Console.WriteLine("\nFim.");
        }

    public static void ColetarNomes(Queue<string> fila)
        {
            string nome;
            Console.WriteLine("Digite 'sair' para finalizar.");

            while (true)
            {
                Console.Write("\nDigite o nome para entrar na fila (mínimo 3 caracteres): ");
                nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                {
                    Console.WriteLine("ERRO: O nome não pode ser vazio e deve ter no mínimo 3 caracteres.");
                    continue;
                }

                if (nome.Any(char.IsDigit))
                {
                    Console.WriteLine("ERRO: O nome não pode conter números. Tente novamente.");
                    continue;
                }

                fila.Enqueue(nome);
                Console.WriteLine($"'{nome}' entrou na fila. Total na fila: {fila.Count}");
            }
        }

        public static void ProcessarAtendimentos(Queue<string> fila)
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("--- ATENDIMENTO DOS 3 PRIMEIROS ---");
            Console.WriteLine("-----------------------------------");

            for (int sla = 1; sla <= 3; sla++)
            {
                string atendido = fila.Dequeue();
                Console.WriteLine($"{sla}º Atendido: {atendido}");
            }
        }

        public static void ExibirFilaRestante(Queue<string> fila)
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--- PESSOAS AINDA NA FILA ---");
            Console.WriteLine("-----------------------------");
            if (fila.Count > 0)
            {
                Console.WriteLine($"Total de pessoas aguardando: {fila.Count}");
                Console.WriteLine($"Ainda aguardam na fila: {string.Join(", ", fila)}");
            }
            else
            {
                Console.WriteLine("Não há mais ninguém aguardando na fila.");
            }
        }
    }
}
