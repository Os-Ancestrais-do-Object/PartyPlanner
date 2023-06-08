using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.Dados.ModuloCliente
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(DataContext dataContext) : base(dataContext)
        {
        }

        protected override List<Cliente> ListaRegistros => throw new NotImplementedException();
    }
}
