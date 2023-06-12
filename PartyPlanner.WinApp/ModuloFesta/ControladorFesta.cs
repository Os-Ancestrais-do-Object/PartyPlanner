using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase<Festa, RepositorioFesta, TabelaFestaControl, TelaFestaForm, RepositorioCliente, RepositorioTema>
    {
        public ControladorFesta(RepositorioFesta _repositorio, TabelaFestaControl _tabela, RepositorioCliente _repositorio2, RepositorioTema _repositorio3) : base(_repositorio, _tabela, _repositorio2, _repositorio3)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
