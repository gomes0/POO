using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sem utilizar (Enum) ---\n");

            /*List<int> diaDaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            foreach (var item in diaDaSemanaSemEnum)
            {
                if (item == 0) Console.WriteLine("Domingo");
                if (item == 1) Console.WriteLine("Segumda");
                if (item == 2) Console.WriteLine("Terça");
                if (item == 3) Console.WriteLine("Quarta");
                if (item == 4) Console.WriteLine("Quinta");
                if (item == 5) Console.WriteLine("Sexta");
                if (item == 6) Console.WriteLine("Sábado");
            }*/

            List<int> diaDaSemanaSemEnum = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in diaDaSemanaSemEnum)
            {
                if (item == 0) Console.WriteLine("Domingo - Número: 1");
                if (item == 1) Console.WriteLine("Segunda - Número: 2");
                if (item == 2) Console.WriteLine("Terça - Número: 3");
                if (item == 3) Console.WriteLine("Quarta - Número: 4");
                if (item == 4) Console.WriteLine("Quinta - Número: 5");
                if (item == 5) Console.WriteLine("Sexta - Número: 6");
                if (item == 6) Console.WriteLine("Sábado - Número: 7");
            }
            Console.WriteLine("\n\n--- Com a utilização de (Enum) ---\n");
            List<DiaDaSemana> diaDaSemanaComEnum = new List<DiaDaSemana>()
            {
                DiaDaSemana.Domingo, DiaDaSemana.Segunda, DiaDaSemana.Terca, DiaDaSemana.Quarta, DiaDaSemana.Quinta, DiaDaSemana.Sexta, DiaDaSemana.Sabado
            };
            
            foreach(var item in diaDaSemanaComEnum)
            {
                //{item} - Chama o método toString()
                //{ (int)item } - faz um Cast, conversão de texto para o número equivalente
                Console.WriteLine($"{item} Número: {(int)item}");
            }
        }
    }

    public enum DiaDaSemana
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7
    }
}
