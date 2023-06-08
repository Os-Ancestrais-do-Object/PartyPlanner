using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form, ITelaBase<Aluguel>
    {
        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        public TextBox TtxtId => throw new NotImplementedException();

        public Aluguel? Entidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
