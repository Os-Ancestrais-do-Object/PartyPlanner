using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl, ITabelaBase<Aluguel>
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            gridAluguel.ConfigurarTabelaGrid("Número", "Festa de", "Tema", "Horas Alugadas", "Sinal (40%)", "Valor Total", "Data Quitação", "Status");
        }

        public DataGridView DataGridView { get { return gridAluguel; } }

        public void AtualizarLista(List<Aluguel> alugueis)
        {
            gridAluguel.Rows.Clear();

            foreach (Aluguel item in alugueis)
            {
                gridAluguel.Rows.Add(item.id, item.Festa.Cliente.Nome, item.Festa.Tema.Nome, $"{Math.Round((decimal)(item.Festa.HoraFinal - item.Festa.HoraInicio).TotalHours)} hora(s)", $"R${item.Sinal}", $"R${item.ValorTotal}", item.DataQuitacao.HasValue ? item.DataQuitacao.Value.ToString("d") : "", item.StatusAluguel);

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
