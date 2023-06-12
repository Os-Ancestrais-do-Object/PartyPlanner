using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase<Festa, RepositorioFesta, TabelaFestaControl, TelaFestaForm, RepositorioCliente, RepositorioTema>
    {
        private RepositorioFesta _repositorioFesta;
        private TabelaFestaControl _tabelaFesta;

        private RepositorioCliente _repositorioCliente;
        private RepositorioTema _repositorioTema;

        public ControladorFesta(RepositorioFesta _repositorio, TabelaFestaControl _tabela, RepositorioCliente _repositorio2, RepositorioTema _repositorio3) : base(_repositorio, _tabela, _repositorio2, _repositorio3)
        {
            _repositorioFesta = _repositorio;
            _tabelaFesta = _tabela;
            _repositorioCliente = _repositorio2;
            _repositorioTema = _repositorio3;
        }

        public override TabelaFestaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
