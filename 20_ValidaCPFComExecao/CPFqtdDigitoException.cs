using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExecao
{
    public class CPFqtdDigitoException: Exception
    {
        public CPFqtdDigitoException() :base("O CPF deve ter 11 dígitos!") { }
    }
}
