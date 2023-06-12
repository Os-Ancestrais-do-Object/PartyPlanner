using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form, ITelaBase<Cliente>
    {
        private Cliente _cliente;

        public TelaClienteForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Cliente? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                //txtNome.Text = value.Nome;
                //txtTelefone.Text = value.telefone;
            }
            get
            {
                return _cliente;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_cliente = new Cliente(txtNome.Text, txtTelefone.Text);

            if (_cliente.id == 0)
                _cliente.id = int.Parse(txtId.Text);
        }
    }
}
