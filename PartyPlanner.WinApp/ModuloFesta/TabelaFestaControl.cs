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
                gridFesta.Rows.Add(item.id, item.Endereco, item.Tema.Nome, item.Data.ToString("d"), item.HoraInicio.ToString("HH:mm"), item.HoraFinal.ToString("HH:mm"), item.Cliente.Nome);

                gridFesta.Rows[gridFesta.Rows.Count - 1].Cells[0].Tag = item;
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {festas.Count} Festas");
        }

        public Festa? ObterRegistroSelecionado()
        {
            return (Festa)gridFesta.SelectedRows[0].Cells[0].Tag;
        }
    }
}
