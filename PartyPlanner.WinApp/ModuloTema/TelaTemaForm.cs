using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form, ITelaBase<Tema>
    {
        public TelaTemaForm()
        {
            InitializeComponent();
        }

        public TextBox TtxtId => throw new NotImplementedException();

        public Tema? Entidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
