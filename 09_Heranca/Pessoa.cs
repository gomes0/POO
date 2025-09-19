using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;
        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }
    public override string ToString()
        {
            return $"<toString()> Nome: {this.Nome} Documento: {GetDocumento()} Telefone: {this.Telefone}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
                return false;

            //Cast=> Conversão de objetos
            //((Pessoa)obj)=> converte obj que é do tipo Object para o tipo Pessoa
            return this.Id == ((Pessoa)obj).Id ;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
