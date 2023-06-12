using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form, ITelaBase<Festa>
    {
        public TelaFestaForm()
        {
            InitializeComponent();
        }
    }
}
