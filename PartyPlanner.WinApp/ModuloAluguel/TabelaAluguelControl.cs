using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl, ITabelaBase<Aluguel>
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            gridAluguel.ConfigurarTabelaGrid("Número", "Festa", "Valor Total", "Desconto", "Valor Cobrado", "Data Quitação", "Sinal");
        }

        public DataGridView DataGridView { get { return gridAluguel; } }

        public void AtualizarLista(List<Aluguel> alugueis)
        {
            gridAluguel.Rows.Clear();

            foreach (Aluguel item in alugueis)
            {
                gridAluguel.Rows.Add(item.id, item.Festa.Cliente, $"R${item.ValorTotal}", $"{item.Desconto}%", $"R${item.ValorCobrado}", item.DataQuitacao.ToString("d"), $"R${item.Sinal}");

                gridAluguel.Rows[gridAluguel.Rows.Count - 1].Cells[0].Tag = item;
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {alugueis.Count} Aluguéis");
        }

        public Aluguel? ObterRegistroSelecionado()
        {
            return (Aluguel)gridAluguel.SelectedRows[0].Cells[0].Tag;
        }
    }
}
