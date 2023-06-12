using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form, ITelaBase<Cliente>
    {
        public TelaClienteForm()
        {
            InitializeComponent();
        }
    }
}
