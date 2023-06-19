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
                cbCliente.Text = value.Cliente.Nome;
                _festa = value;
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

            AtualizarDataTema(tema);

            _festa = new Festa(txtEndereco.Text, tema, txtData.Value, txtInicio.Value, txtFinal.Value, cliente);

            if (_festa.id == 0)
                _festa.id = int.Parse(txtId.Text);
        }

        private void AtualizarDataTema(Tema? tema)
        {
            if (_festa == null)
                tema.Reservas.Add(txtData.Value);
            else
            {
                tema.Reservas.Remove(_festa.Data);
                _festa.Tema.Reservas.Remove(_festa.Data);
                tema.Reservas.Add(txtData.Value);
            }
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

            Tema temaSelecionado = (Tema)cbTema.SelectedItem;

            if (_festa != null && _festa.Tema.Reservas.Contains(txtData.Value) && _festa.Tema == temaSelecionado)
            {
                lbErroTema.Visible = false;
            }
            else if (ValidarTemaReservado(temaSelecionado))
            {
                lbErroTema.Visible = true;
                lbErroTema.Text = "Tema já reservado nessa Data";
            }
            else if (festa.ValidarCampoVazio(cbTema.Text))
            {
                lbErroTema.Visible = true;
                lbErroTema.Text = "Campo obrigatório";
            }
            else
                lbErroTema.Visible = false;

            lbErroEndereco.Visible = festa.ValidarCampoVazio(txtEndereco.Text);
            lbErroCliente.Visible = festa.ValidarCampoVazio(cbCliente.Text);
            lbErroData.Visible = ValidarData(txtData.Value);
            lbErroHora.Visible = ValidarHora(txtInicio.Value, txtFinal.Value);

            if (lbErroEndereco.Visible || lbErroTema.Visible || lbErroCliente.Visible || lbErroData.Visible || lbErroHora.Visible)
                isValid = false;
            else
                isValid = true;
        }

        private bool ValidarTemaReservado(Tema temaSelecionado)
        {
            return temaSelecionado.Reservas.Any(data => data.ToString("d") == txtData.Value.ToString("d"));
        }

        private bool ValidarData(DateTime data)
        {
            return data < DateTime.Now;
        }

        private bool ValidarHora(DateTime horaInicial, DateTime horaFinal)
        {
            return horaInicial >= horaFinal;
        }
    }
}