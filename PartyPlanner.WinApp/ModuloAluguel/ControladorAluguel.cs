using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase<Aluguel, RepositorioAluguel, TabelaAluguelControl, TelaAluguelForm, RepositorioFesta>
    {
        public ControladorAluguel(RepositorioAluguel _repositorio, TabelaAluguelControl _listagem, RepositorioFesta _repositorio2) : base(_repositorio, _listagem, _repositorio2)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
