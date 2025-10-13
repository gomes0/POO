using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );
            IDocumento documento = new CPF(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");

            Console.Write("Digite o CNPJ: ");
            documento = new CNPJ(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
        }
    }
}