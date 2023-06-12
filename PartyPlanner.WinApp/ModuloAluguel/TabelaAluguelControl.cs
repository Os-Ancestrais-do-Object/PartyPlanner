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
                DataGridViewRow row = new();

                //row.CreateCells(gridAluguel, item.id, item.Festa, item.ValorTotal, item.Desconto, item.ValorCobrado, item.DataQuitacao, item.Sinal);

                row.Cells[0].Tag = item;

                gridAluguel.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {alugueis.Count} Aluguéis");
        }

        public Aluguel? ObterTarefaSelecionada()
        {
            return (Aluguel)gridAluguel.SelectedRows[0].Cells[0].Tag;
        }
    }
}
