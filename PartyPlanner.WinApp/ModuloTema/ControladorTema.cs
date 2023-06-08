using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase<Tema, RepositorioTema, TabelaTemaControl, TelaTemaForm, NenhumRepositorio>
    {
        public ControladorTema(RepositorioTema _repositorio, TabelaTemaControl _listagem) : base(_repositorio, _listagem)
        {
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
