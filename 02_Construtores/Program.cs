using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.ImprimirArea();

            Quadrado quadrado1 = new Quadrado(10);
            quadrado1.ImprimirArea();

            Console.WriteLine("--------------------------------------------");

            Retangulo retangulo = new Retangulo(5,5);
            retangulo.ImprimirArea();

            Console.WriteLine("--------------------------------------------");

            Circulo circulo = new Circulo(5);
            circulo.ImprimirArea();

            Console.WriteLine("--------------------------------------------");

            Triangulo triangulo = new Triangulo(5,5);
            triangulo.ImprimirArea();
        }
    }
    public class Quadrado
    {
        //Modificador de acesso Private
        //pode ser acessado apenas dentro da Classe
        private int Lado;

        //Overloadm(Sobrecarga) de Construtor
        public Quadrado()
        {
            this.Lado = 5;
        }

        //O Construtor serve para instanciar o objeto e Inicializar os atributos
        public Quadrado(int lado)
        {
            //this: acessa o membro da classe
            this.Lado = lado;
        }

        public int CalculaArea()
        {
            return Lado * Lado;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }
    public class Retangulo
    {
        private int Largura, Altura;

        public Retangulo(int largura, int altura)
        { 
            this .Largura = largura;
            this .Altura = altura;
        }

        public int CalculaArea()
        { 
            return Largura * Altura;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Retângulo com altura de {Altura} e {Largura} possui uma área de {CalculaArea()}");
        }
    }
    public class Circulo
    {
        private double Raio;

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public double CalculaArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Circulo com raio de {Raio:N2} possui uma área de {CalculaArea():N2}");
        }
    }
    public class Triangulo
    {
        private double Base, Altura;

        public Triangulo(double baze, double altura)
        {
            this .Base = baze;
            this .Altura = altura;
        }

        public double CalculaArea()
        {
            return (Base * Altura) / 2;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Triangulo com base de {Base:N2} e altura de {Altura:N2} possui uma área de {CalculaArea():N2}");
        }
    }
}
