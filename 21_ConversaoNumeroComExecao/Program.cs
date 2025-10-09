using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        string entrada = Console.ReadLine();

        try
        {
            int numero = int.Parse(entrada);
            int dobro = numero * 2;
            Console.WriteLine($"O dobro do valor é: {dobro}");
        }
        catch (Exception)
        {
            Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
        }
        Console.WriteLine("\nFim do programa.");
    }
}