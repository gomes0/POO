﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidaCPF
{
    internal class CPF : IDocumento
    {
        public string Numero { get; }

        public CPF(string numero)
        {
            // 1 - Eliminar caractres não numéricos
            this.Numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            // 2 - Validar se tem 11 digitos
            if (this.Numero.Length != 11)
                return false;

            // 3- Validas CPFs com todos os números iguais
            if (this.Numero.Distinct().Count() == 1)
                return false;

            //4 - Cálculo do 1º Digito verificador            
            int digX = CalculaDV(this.Numero, 9, 10);

            //5 - Cálculo do 2º Digito Verificador            
            int digY = CalculaDV(this.Numero, 10, 11);

            //6 - Comparar os dígitos
            if (
                int.Parse(this.Numero[9].ToString()) == digX &&
                int.Parse(this.Numero[10].ToString()) == digY
               )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
            }
            int resto = soma % 11;

            int digito = 0;
            if (resto >= 2)
            {
                digito = 11 - resto;
            }
            return digito;
        }
    }
}