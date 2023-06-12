using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.Dados.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>
    {
        public RepositorioAluguel(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Alugueis.Count > 0)
                id = dataContext.Alugueis.Max(x => x.id) + 1;
        }

        protected override List<Aluguel> ListaRegistros => dataContext.Alugueis;
    }
}
