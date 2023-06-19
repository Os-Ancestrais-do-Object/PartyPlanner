using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase<Cliente, RepositorioCliente, TabelaClienteControl, TelaClienteForm, NenhumRepositorio, NenhumRepositorio>
    {
        private RepositorioCliente _repositorioCliente;
        private TabelaClienteControl _tabelaCliente;

        public ControladorCliente(RepositorioCliente _repositorio, TabelaClienteControl _tabela) : base(_repositorio, _tabela)
        {
            _repositorioCliente = _repositorio;
            _tabelaCliente = _tabela;
        }

        public override TabelaClienteControl ObterListagem()
        {
            return _tabela;
        }
    }
}
