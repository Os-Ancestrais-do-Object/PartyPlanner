using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.Dados.ModuloCliente
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Clientes.Count > 0)
                id = dataContext.Clientes.Max(x => x.id) + 1;
        }

        protected override List<Cliente> ListaRegistros => dataContext.Clientes;
    }
}
