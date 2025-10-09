using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Divisão de Números Inteiros ---");

            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número (numerador): ");
                    string entradaNum1 = Console.ReadLine();
                    int num1 = int.Parse(entradaNum1);

                    Console.Write("Digite o segundo número (denominador): ");
                    string entradaNum2 = Console.ReadLine();
                    int num2 = int.Parse(entradaNum2);

                    int resultado = num1 / num2;

                    Console.WriteLine($"\nResultado da divisão de {num1} por {num2} é: {resultado}");

                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("\nErro: Divisão por zero não é permitida. Tente novamente com um denominador diferente de zero.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nErro: Valor inválido. Certifique-se de digitar apenas números inteiros.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("\nOperação finalizada. Obrigado por utilizar o programa!");
                }

                Console.ReadKey();
            }
        }
    }
}
