using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl, ITabelaBase<Tema>
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView => throw new NotImplementedException();

        public void AtualizarLista(List<Tema> contatos)
        {
            throw new NotImplementedException();
        }

        public Tema ObterTarefaSelecionada()
        {
            throw new NotImplementedException();
        }
    }
}
