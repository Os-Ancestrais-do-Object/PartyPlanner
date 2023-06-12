using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;

namespace PartyPlanner.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form, ITelaBase<Tema>
    {
        private Tema _tema;

        public TelaTemaForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Tema? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                //txtNome.Text = value.Nome;
            }
            get
            {
                return _tema;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_tema = new Tema(txtNome.Text, "", "R$0");

            if (_tema.id == 0)
                _tema.id = int.Parse(txtId.Text);
        }
    }
}
