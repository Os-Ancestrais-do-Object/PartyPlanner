using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl, ITabelaBase<Aluguel>
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView => throw new NotImplementedException();

        public void AtualizarLista(List<Aluguel> contatos)
        {
            throw new NotImplementedException();
        }

        public Aluguel ObterTarefaSelecionada()
        {
            throw new NotImplementedException();
        }
    }
}
