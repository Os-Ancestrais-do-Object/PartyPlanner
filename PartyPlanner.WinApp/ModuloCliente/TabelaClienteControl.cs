using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl, ITabelaBase<Cliente>
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView => throw new NotImplementedException();

        public void AtualizarLista(List<Cliente> contatos)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterRegistroSelecionado()
        {
            throw new NotImplementedException();
        }
    }
}
