using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não é possivel instanciar uma classe abstrata
            //Pessoa obj = new Pessoa()
            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "999-999-999-99";
            pessoaFisica.Telefone = "(14) 99999-9999";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Senac Marília";
            pessoaJuridica.CNPJ = "999-999-999-99";
            pessoaJuridica.Telefone = "(14) 99999-9999";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine("È a mesma pessoa.");
            else
                Console.WriteLine("Não é a mesma pessoa.");

            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
