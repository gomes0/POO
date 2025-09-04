using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 28;
            obj2.ImprimeArea();

            Console.WriteLine("------------------");

            // Instancias e chamadas para a classe Retangulo
            Retangulo obj3 = new Retangulo();
            obj3.Largura = 5;
            obj3.Altura = 10;
            obj3.ImprimeArea();

            Retangulo obj4 = new Retangulo();
            obj4.Largura = 20;
            obj4.Altura = 15;
            obj4.ImprimeArea();

            Console.WriteLine("------------------");

            // Instancias e chamadas para a classe Circulo
            Circulo obj5 = new Circulo();
            obj5.Raio = 10;
            obj5.ImprimirArea();

            Circulo obj6 = new Circulo();
            obj6.Raio = 5.5;
            obj6.ImprimirArea();

            Console.WriteLine("------------------");

            // Instancias e chamadas para a classe Triangulo
            Triangulo obj7 = new Triangulo();
            obj7.Base = 8;
            obj7.Altura = 12;
            obj7.ImprimeArea();

            Triangulo obj8 = new Triangulo();
            obj8.Base = 15.5;
            obj8.Altura = 10.2;
            obj8.ImprimeArea();

            Console.ReadKey();
        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }

    }

    public class Retangulo
    {
        public int Largura, Altura;

        public int CalculaArea()
        {
            return Largura * Altura;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com base de {Largura} e altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        public double Raio;

        public double CalculaArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio:N2} possui uma área de {CalculaArea():N2}");
        }
    }
    public class Triangulo
    {
        public double Base, Altura;

        public double CalculaArea()
        {
            return (Base * Altura) / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2} e altura de {Altura:N2} possui uma área de {CalculaArea():N2}");
        }

    }
}