using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.Dados.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>
    {
        public RepositorioTema(DataContext dataContext) : base(dataContext)
        {
        }

        protected override List<Tema> ListaRegistros => throw new NotImplementedException();
    }
}
