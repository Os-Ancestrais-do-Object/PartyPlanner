using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl, ITabelaBase<Festa>
    {
        public TabelaFestaControl()
        {
            InitializeComponent();
            gridFesta.ConfigurarTabelaGrid("Número", "Endereço", "Tema", "Data", "Hora Início", "Hora Término", "Cliente");
        }

        public DataGridView DataGridView { get { return gridFesta; } }

        public void AtualizarLista(List<Festa> festas)
        {
            gridFesta.Rows.Clear();

            foreach (Festa item in festas)
            {
                DataGridViewRow row = new();

                //row.CreateCells(gridFesta, item.id, item.Endereco, item.Tema, item.Data, item.HoraInicio, item.HoraTermino, item.Cliente);

                row.Cells[0].Tag = item;

                gridFesta.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {festas.Count} Festas");
        }

        public Festa? ObterTarefaSelecionada()
        {
            return (Festa)gridFesta.SelectedRows[0].Cells[0].Tag;
        }
    }
}
