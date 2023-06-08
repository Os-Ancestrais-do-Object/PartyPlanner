using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl, ITabelaBase<Festa>
    {
        public TabelaFestaControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView => throw new NotImplementedException();

        public void AtualizarLista(List<Festa> contatos)
        {
            throw new NotImplementedException();
        }

        public Festa ObterTarefaSelecionada()
        {
            throw new NotImplementedException();
        }
    }
}
