using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using System.Text.RegularExpressions;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form, ITelaBase<Cliente>
    {
        private Cliente _cliente;

        private bool isValid;

        public TelaClienteForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Cliente? Entidade
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
            }
            get
            {
                return _cliente;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);

            if (isValid == false)
            {
                this.DialogResult = DialogResult.None;
                ImplementarMetodos();
                return;
            }

            _cliente = new Cliente(txtNome.Text, txtTelefone.Text);

            if (_cliente.Id == 0)
                _cliente.Id = int.Parse(txtId.Text);
        }

        private void ImplementarMetodos()
        {
            txtNome.TextChanged += ValidarCampos;
            txtTelefone.TextChanged += ValidarCampos;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            Cliente cliente = new();

            lbErroNome.Visible = cliente.ValidarCampoVazio(txtNome.Text);
            lbErroTelefone.Visible = cliente.ValidarTelefone(txtTelefone.Text);

            if (lbErroNome.Visible || lbErroTelefone.Visible)
                isValid = false;
            else
                isValid = true;
        }
    }
}
