using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase<Cliente, RepositorioCliente, TabelaClienteControl, TelaClienteForm, NenhumRepositorio, NenhumRepositorio>
    {
        public ControladorCliente(RepositorioCliente _repositorio, TabelaClienteControl _tabela) : base(_repositorio, _tabela)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
