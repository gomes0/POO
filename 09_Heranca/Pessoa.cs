using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public string Nome;
        public string Telefone;

        public abstract string GetDocument();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocument()} Telefone: {this.Telefone}");
        }
    }
}
