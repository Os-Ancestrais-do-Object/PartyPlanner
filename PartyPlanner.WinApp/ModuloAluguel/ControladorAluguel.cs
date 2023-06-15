using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.WinApp.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase<Aluguel, RepositorioAluguel, TabelaAluguelControl, TelaAluguelForm, RepositorioFesta, NenhumRepositorio>
    {
        private RepositorioAluguel _repositorioAluguel;
        private TabelaAluguelControl _tabelaAluguel;

        private RepositorioFesta _repositorioFesta;

        public ControladorAluguel(RepositorioAluguel _repositorio, TabelaAluguelControl _tabela, RepositorioFesta _repositorio2) : base(_repositorio, _tabela, _repositorio2)
        {
            _repositorioAluguel = _repositorio;
            _tabelaAluguel = _tabela;
            _repositorioFesta = _repositorio2;

            onCarregarArquivosEComandos += CarregarComboBox;
        }

        public void CarregarComboBox(TelaAluguelForm telaAluguel)
        {
            telaAluguel.cbFesta.DisplayMember = "Tema.Nome";
            telaAluguel.cbFesta.ValueMember = "Tema.Nome";
            telaAluguel.cbFesta.DataSource = _repositorioFesta.ObterListaRegistros();
        }

        public override TabelaAluguelControl ObterListagem()
        {
            return _tabela;
        }
    }
}
