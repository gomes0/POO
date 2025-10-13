using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteComboBox
{
    public class ClienteRepository
    {
        public List<Clientes> Listar()
        {
            //Consulta no Banco de dados...

            List<Clientes> clientes = new List<Clientes>
            {
                new Clientes{
                    Id= 1,
                    Nome= "Elias Gomes",
                    Email="eliasgomesduraes2008@gmail.com"
                },
                new Clientes{
                    Id= 2,
                    Nome= "Paulo Souza",
                    Email="paulinsouzx@gmail.com"
                },
                new Clientes{
                    Id= 3,
                    Nome= "Miguel Nascimento Gomes",
                    Email="miguelitossilva08@gmail.com"
                },
                new Clientes
                    {Id= 4,
                    Nome= "Giovana Teixeira",
                    Email="giocut2008xd@gmail.com"
                },
                new Clientes{
                    Id= 5,
                    Nome= "Gabriel Pereira Profeta",
                    Email="grabrel900@gmail.com"
                },
            };
            return clientes;
        }
    }
}
