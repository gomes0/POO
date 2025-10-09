using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        string entrada = Console.ReadLine();

        while (true)
        {
            try
            {
                int numero = int.Parse(entrada);
                int dobro = numero * 2;
                Console.WriteLine($"O dobro do valor é: {dobro}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

            break;
        }
    }
}