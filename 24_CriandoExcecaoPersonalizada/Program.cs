using System;

public class NotaInvalidaException : Exception
{
    public NotaInvalidaException(string mensagem) : base(mensagem)
    {
    }

    public NotaInvalidaException() : base("A nota informada está fora do intervalo permitido (0 a 10).")
    {
    }
}

public class CriandoExcecaoPersonalizada
{
    private const double NOTA_MINIMA_APROVACAO = 7.0;

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Verificação de Nota com Exceção Personalizada ---");

        try
        {
            Console.Write("Por favor, digite a nota do aluno (entre 0 e 10): ");
            string entrada = Console.ReadLine();

            double nota = double.Parse(entrada);

            if (nota < 0 || nota > 10)
            {
                throw new NotaInvalidaException();
            }

            if (nota >= NOTA_MINIMA_APROVACAO)
            {
                Console.WriteLine($"\nNota: {nota}. Parabéns, Aluno APROVADO!");
            }
            else
            {
                Console.WriteLine($"\nNota: {nota}. Aluno REPROVADO.");
            }
        }
        catch (NotaInvalidaException)
        {
            Console.WriteLine("\nErro: valor de nota inválido! A nota deve estar entre 0 e 10.");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nErro de formato! Digite a nota utilizando apenas números.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}