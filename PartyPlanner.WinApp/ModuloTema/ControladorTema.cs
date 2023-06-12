using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase<Tema, RepositorioTema, TabelaTemaControl, TelaTemaForm, NenhumRepositorio, NenhumRepositorio>
    {
        private RepositorioTema _repositorioTema;
        private TabelaTemaControl _tabelaTema;

        public ControladorTema(RepositorioTema _repositorio, TabelaTemaControl _tabela) : base(_repositorio, _tabela)
        {
            _repositorioTema = _repositorio;
            _tabelaTema = _tabela;
        }

        public override TabelaTemaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
