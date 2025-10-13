using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteComboBox
{
    public class ClienteController
    {
        private FrmAtendimento _frmAtendimento;
        private ClienteRepository _clienteRepository;
        public ClienteController(FrmAtendimento view)
        {
            _frmAtendimento = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes()
        {
            var listaClientes = _clienteRepository.Listar();
            _frmAtendimento.ListarClientesCombobox(listaClientes);
        }
    }
}
