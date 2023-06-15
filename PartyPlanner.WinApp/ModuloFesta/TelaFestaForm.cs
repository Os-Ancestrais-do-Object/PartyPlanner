using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form, ITelaBase<Festa>
    {
        private Festa _festa;

        private bool isValid;

        public TelaFestaForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Festa? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtEndereco.Text = value.Endereco;
                cbTema.Text = value.Tema.Nome;
                txtData.Value = value.Data;
                txtInicio.Value = value.HoraInicio;
                txtFinal.Value = value.HoraFinal;
                //cbCliente.Text = value.Cliente.Nome;
            }
            get
            {
                return _festa;
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

            Tema? tema = cbTema.SelectedItem as Tema;
            Cliente? cliente = cbCliente.SelectedItem as Cliente;

            _festa = new Festa(txtEndereco.Text, tema, txtData.Value, txtInicio.Value, txtFinal.Value, cliente);

            if (_festa.id == 0)
                _festa.id = int.Parse(txtId.Text);
        }

        private void ImplementarMetodos()
        {
            txtEndereco.TextChanged += ValidarCampos;
            cbTema.TextChanged += ValidarCampos;
            cbCliente.TextChanged += ValidarCampos;
            txtData.ValueChanged += ValidarCampos;
            txtInicio.ValueChanged += ValidarCampos;
            txtFinal.ValueChanged += ValidarCampos;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            Festa festa = new();

            lbErroEndereco.Visible = festa.ValidarCampoVazio(txtEndereco.Text);
            lbErroTema.Visible = festa.ValidarCampoVazio(cbTema.Text);
            //lbErroCliente.Visible = festa.ValidarCampoVazio(cbCliente.Text);
            lbErroData.Visible = ValidarData(txtData.Value);
            lbErroHora.Visible = ValidarHora(txtInicio.Value, txtFinal.Value);

            if (lbErroEndereco.Visible || lbErroTema.Visible || lbErroCliente.Visible || lbErroData.Visible || lbErroHora.Visible)
                isValid = false;
            else
                isValid = true;
        }

        private bool ValidarData(DateTime data)
        {
            return data <= DateTime.Now;
        }

        private bool ValidarHora(DateTime horaInicial, DateTime horaFinal)
        {
            return horaInicial >= horaFinal;
        }
    }
}