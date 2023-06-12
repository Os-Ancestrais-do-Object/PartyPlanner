using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dominio.ModuloAluguel;

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
        }

        public override TabelaAluguelControl ObterListagem()
        {
            return _tabela;
        }
    }
}
