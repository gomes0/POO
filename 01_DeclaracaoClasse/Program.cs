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

            Retangulo obj3 = new Retangulo();
            obj3.Largura = 5;
            obj3.Altura = 10;
            obj3.ImprimeArea();

            Retangulo obj4 = new Retangulo();
            obj4.Largura = 20;
            obj4.Altura = 15;
            obj4.ImprimeArea();

            Console.WriteLine("------------------");

            Circulo obj5 = new Circulo();
            obj5.Raio = 10;
            obj5.ImprimirArea();

            Circulo obj6 = new Circulo();
            obj6.Raio = 5.5;
            obj6.ImprimirArea();

            Console.WriteLine("------------------");

            Triangulo obj7 = new Triangulo();
            obj7.Base = 8;
            obj7.Altura = 12;
            obj7.ImprimeArea();

            Triangulo obj8 = new Triangulo();
            obj8.Base = 15.5;
            obj8.Altura = 10.2;
            obj8.ImprimeArea();

            Console.WriteLine("------------------");

            Conta contaElias = new Conta();
            contaElias.Banco = 237;
            contaElias.Agencia = "003-7";
            contaElias.Numero = "999520-7";
            contaElias.Saldo = 0.00;
            contaElias.Limite = 500.00;

            contaElias.Depositar(1050.55);
            Console.WriteLine($"Saldo Atual: {contaElias.ConsultaSaldo()}");

            contaElias.Sacar(200.00);
            Console.WriteLine($"Saldo Atual: {contaElias.ConsultaSaldo()}");

            Console.WriteLine("------------------");

            

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
    public class Conta
    {
        public int Banco;
        public string Agencia, Numero;
        public double Saldo, Limite;
        public void Depositar(double valor) 
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0) ;
            else if (valor > Saldo) ;
            else
            Saldo -= valor;
        }

        public double ConsultaSaldo() 
        {
            return Saldo;
        }
    }
    public class Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas;

        public void LancarNota(int trimestre,double nota)
        {
            Notas[trimestre - 1] = nota;
        }

        public double CalcularMedia()
        {
            double media = 0;

            foreach (double nota in Notas)
            {
                media += nota;
            }
            return media / 4.0;
        }

        public string Mencao()
        {
            if (CalcularMedia() >= 5.0)
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}