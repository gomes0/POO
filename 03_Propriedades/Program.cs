using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("999-99", "Elias Gomes");

            //conta.nome = "Elias Gomes";

            //Não é possivel atribuir o valor em um atributo privado
            //conta.numero = "999-99"

            //conta.Saldo = -1000.00m
            conta.Depositar(-1000.00m);

            //Utilizando o método acessador
            conta.setSaldo(1000.00m);
            //Console.WriteLine($"Saldo Atual: {conta.getSaldo():C2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a operção : [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.Write($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }
    public class Conta
    {
        private string nome;
        private string numero;

        public Conta(string numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }


        //Transformar a conta Saldo com acesso privado
        //public decimal Saldo;
        private decimal saldo;

        //Métodos acessadores
        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public string getNumero()
        {
            return numero;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:C2}");
        }
    }
}
 
