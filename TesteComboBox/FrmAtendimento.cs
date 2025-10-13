namespace TesteComboBox
{
    public partial class FrmAtendimento : Form
    {
        private ClienteController _clienteController;
        public FrmAtendimento()
        {
            InitializeComponent();
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.txtCodigoCliente_SelectedIndexChanged);
            _clienteController = new ClienteController(this);
        }

        public void ListarClientesCombobox(List<Clientes> clientes)
        {
            cbxClientes.DataSource = clientes;
            cbxClientes.DisplayMember = "Nome";
            cbxClientes.ValueMember = "Id";
            cbxClientes.SelectedIndex = -1;
            cbxClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int clienteiD = Convert.ToInt32(cbxClientes.SelectedValue);
            string clienteNome = cbxClientes.Text;
            MessageBox.Show($"Cliente Selecionado: {clienteNome}\n ID: {clienteiD}");
        }

        private void txtCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedValue != null)
            {
                string clienteID = cbxClientes.SelectedValue.ToString();

                txtCodigoCliente.Text = clienteID;
            }
            else
            {
                txtCodigoCliente.Text = string.Empty;
            }
        }
    }
}