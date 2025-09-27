using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cadastroAlunos = new Dictionary<int, string>();

            Console.WriteLine("--- CADASTRO DE ALUNOS (RA e Nome) ---");

            ColetarAlunos(cadastroAlunos);

            ExibirCadastro(cadastroAlunos);

            Console.WriteLine("\nFim.");
        }
        public static void ColetarAlunos(Dictionary<int, string> dicionario)
        {
            string nome;
            int ra;
            string continuar;
            int contador = 1;

            Console.WriteLine("Digite 'n' a qualquer momento para finalizar a inclusão.");

            while (true)
            {
                Console.WriteLine("\n--- Aluno " + contador + " ---");

                Console.Write("Digite o RA (número inteiro): ");
                if (!int.TryParse(Console.ReadLine(), out ra))
                {
                    Console.WriteLine("ERRO: O RA deve ser um número inteiro válido.");
                    continue;
                }

                if (dicionario.ContainsKey(ra))
                {
                    Console.WriteLine("ERRO: Este RA já foi cadastrado. Use um RA único.");
                    continue;
                }

                Console.Write("Digite o Nome do aluno (mínimo 3 caracteres): ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                {
                    Console.WriteLine("ERRO: O nome não pode ser vazio e deve ter no mínimo 3 caracteres.");
                    continue;
                }

                dicionario.Add(ra, nome);
                Console.WriteLine($"Aluno '{nome}' (RA: {ra}) cadastrado com sucesso!");
                contador++;

                Console.Write("\nDeseja cadastrar outro aluno? (s/n): ");
                continuar = Console.ReadLine();
                if (continuar.ToLower() == "n")
                {
                    break;
                }
            }
        }

        public static void ExibirCadastro(Dictionary<int, string> dicionario)
        {
            Console.WriteLine("\n" + new string('=', 36));
            Console.WriteLine("--- DADOS DOS ALUNOS CADASTRADOS ---");
            Console.WriteLine(new string('=', 36));

            if (dicionario.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            foreach (KeyValuePair<int, string> aluno in dicionario)
            {
                Console.WriteLine($"RA: {aluno.Key} | Nome: {aluno.Value}");
            }

            Console.WriteLine("\nTotal de alunos cadastrados: " + dicionario.Count);
        }
    }
}