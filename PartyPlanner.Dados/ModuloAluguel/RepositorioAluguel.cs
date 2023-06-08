using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.Dados.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>
    {
        public RepositorioAluguel(DataContext dataContext) : base(dataContext)
        {
        }

        protected override List<Aluguel> ListaRegistros => throw new NotImplementedException();
    }
}
