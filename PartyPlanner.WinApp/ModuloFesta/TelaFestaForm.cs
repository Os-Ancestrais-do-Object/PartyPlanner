using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form, ITelaBase<Festa>
    {
        public TelaFestaForm()
        {
            InitializeComponent();
        }

        public TextBox TtxtId => throw new NotImplementedException();

        public Festa? Entidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
