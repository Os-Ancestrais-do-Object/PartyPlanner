using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dados.ModuloFesta
{
    public class RepositorioFesta : RepositorioBase<Festa>
    {
        public RepositorioFesta(DataContext dataContext) : base(dataContext)
        {
        }

        protected override List<Festa> ListaRegistros => throw new NotImplementedException();
    }
}
