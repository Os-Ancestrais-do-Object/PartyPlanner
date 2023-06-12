using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form, ITelaBase<Festa>
    {
        private Festa _festa;

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
                //txtEndereco.Text = value.Endereco;
                //cbTema.Text = value.Tema.Descricao;
                //txtData.Text = value.Data;
                //txtInicio.Text = value.Inicio;
                //txtFinal.Text = value.Final;
                //cbCliente.Text = value.Cliente.Nome;
            }
            get
            {
                return _festa;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tema tema = cbTema.SelectedItem as Tema;
            Cliente cliente = cbCliente.SelectedItem as Cliente;

            //_festa = new Festa(festa, txtEndereco.Text, tema, txtData.Text, txtInicio.Text, txtFinal.Text, cliente);

            if (_festa.id == 0)
                _festa.id = int.Parse(txtId.Text);
        }
    }
}
