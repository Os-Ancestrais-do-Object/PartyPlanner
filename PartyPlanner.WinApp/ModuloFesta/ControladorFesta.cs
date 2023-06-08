using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.WinApp.Compartilhado;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase<Festa, RepositorioFesta, TabelaFestaControl, TelaFestaForm, RepositorioCliente>
    {
        public ControladorFesta(RepositorioFesta _repositorio, TabelaFestaControl _listagem, RepositorioCliente _repositorio2) : base(_repositorio, _listagem, _repositorio2)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
