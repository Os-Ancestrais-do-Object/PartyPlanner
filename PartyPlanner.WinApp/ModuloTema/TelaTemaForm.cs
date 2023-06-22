using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;
using System.Xml.Linq;

namespace PartyPlanner.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form, ITelaBase<Tema>
    {
        private Tema _tema;

        private bool isValid;

        public TelaTemaForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Tema? Entidade
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get => _tema;
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

            _tema = new Tema(txtNome.Text, 0);

            if (_tema.Id == 0)
                _tema.Id = int.Parse(txtId.Text);
        }

        private void ImplementarMetodos()
        {
            txtNome.TextChanged += ValidarCampos;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            Tema tema = new();

            lbErroNome.Visible = tema.ValidarCampoVazio(txtNome.Text);

            if (lbErroNome.Visible)
                isValid = false;
            else
                isValid = true;
        }
    }
}
