using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl, ITabelaBase<Cliente>
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
        }
    }
}
