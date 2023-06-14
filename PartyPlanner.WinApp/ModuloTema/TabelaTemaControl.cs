using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl, ITabelaBase<Tema>
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            gridTema.ConfigurarTabelaGrid("Número", "Nome", "Número de Itens", "Valor Total");
        }

        public DataGridView DataGridView => gridTema;

        public void AtualizarLista(List<Tema> temas)
        {
            gridTema.Rows.Clear();

            foreach (Tema item in temas)
            {
                gridTema.Rows.Add(item.id, item.Nome, item.QtdItens, $"R${item.ValorTotal}");

                gridTema.Rows[gridTema.Rows.Count - 1].Cells[0].Tag = item;
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {temas.Count} Temas");
        }

        public Tema? ObterRegistroSelecionado()
        {
            return (Tema)gridTema.SelectedRows[0].Cells[0].Tag;
        }
    }
}
