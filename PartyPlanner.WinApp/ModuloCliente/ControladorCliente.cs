using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase<Cliente, RepositorioCliente, TabelaClienteControl, TelaClienteForm, NenhumRepositorio>
    {
        public ControladorCliente(RepositorioCliente _repositorio, TabelaClienteControl _listagem) : base(_repositorio, _listagem)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
