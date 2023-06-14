using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dados.ModuloFesta
{
    public class RepositorioFesta : RepositorioBase<Festa>
    {
        public RepositorioFesta(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Festas.Count > 0)
                id = dataContext.Festas.Max(x => x.id) + 1;
        }

        protected override List<Festa> ListaRegistros => dataContext.Festas;
    }
}
