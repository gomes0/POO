using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Leitura de Arquivo com Exceção ---");

            Console.Write("Digite o caminho completo do arquivo (ex: C:\\temp\\arquivo.txt): ");
            string caminhoArquivo = Console.ReadLine();

            try
            {
                string conteudo = File.ReadAllText(caminhoArquivo);

                Console.WriteLine("\nConteúdo do Arquivo:");
                Console.WriteLine("---------------------");
                Console.WriteLine(conteudo);
                Console.WriteLine("---------------------");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nArquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro inesperado durante a leitura do arquivo: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
