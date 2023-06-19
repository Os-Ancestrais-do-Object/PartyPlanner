using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl, ITabelaBase<Cliente>
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            gridCliente.ConfigurarTabelaGrid("Número", "Nome", "Telefone");
        }

        public DataGridView DataGridView { get { return gridCliente; } }

        public void AtualizarLista(List<Cliente> clientes)
        {
            gridCliente.Rows.Clear();

            foreach (Cliente item in clientes)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridCliente, item.id, item.Nome, item.Telefone);

                row.Cells[0].Tag = item;

                gridCliente.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {clientes.Count} Clientes");
        }

        public Cliente? ObterRegistroSelecionado()
        {
            return (Cliente)gridCliente.SelectedRows[0].Cells[0].Tag;
        }
    }
}
