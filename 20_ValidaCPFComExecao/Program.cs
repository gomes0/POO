using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_ValidaCPFComExecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );
            IDocumento documento;
            while (true)
            {
                Console.Write("Digite o CPF: ");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFqtdDigitoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF inválido; {ex.Message}");
                }
            }

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