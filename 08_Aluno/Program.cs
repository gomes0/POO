using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            int idadeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota: ");
            double nota1Aluno = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2Aluno = double.Parse(Console.ReadLine());

            Aluno novoAluno = new Aluno(nomeAluno, idadeAluno);
            novoAluno.Nota1 = nota1Aluno;
            novoAluno.Nota2 = nota2Aluno;

            //Exibir a situação
            Console.WriteLine("\n----------------------");
            Console.WriteLine($"Nome: {novoAluno.Nome}");
            Console.WriteLine($"Idade: {novoAluno.Idade}");
            Console.WriteLine($"Nota 1: {novoAluno.Nota1}");
            Console.WriteLine($"Nota 2: {novoAluno.Nota2}");
            Console.WriteLine($"Média: {novoAluno.Media}");
            Console.WriteLine($"Situação: {novoAluno.Situacao}");
        }
    }
    public class Aluno
    {
        //Propriedades no private
        private string _nome;
        private int _idade;
        private double _nota1;
        private double _nota2;

        //Construtor
        public Aluno(string nome, int idade)
        {
            this._nome = nome;
            this.Idade = idade;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value >= 0)
                {
                    _idade = value;
                }
                else
                {
                    Console.WriteLine("Erro: o campo idade não pode ser valor negativo.");
                    _idade = 0;
                }
            }
        }
        //Notas 1 e 2 para calcular a média
        public double Nota1
        {
            get { return _nota1; }
            set { _nota1 = value; }
        }

        public double Nota2
        {
            get { return _nota2; }
            set { _nota2 = value; }
        }

        //Propriedade média
        public double Media
        {
            get
            {
                return (_nota1 + _nota2) / 2;
            }
        }

        //Propriedade situação
        public string Situacao
        {
            get
            {
                return (Media >= 6) ? "Aprovado" : "Reprovado";
            }
        }
    }
}