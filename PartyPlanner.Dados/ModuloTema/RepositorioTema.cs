using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.Compartilhado;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;

namespace PartyPlanner.Dados.ModuloTema
{
    public class RepositorioTema : RepositorioBaseSql<Tema>
    {
        protected override string AddCommand => throw new NotImplementedException();

        protected override string EditCommand => throw new NotImplementedException();

        protected override string DeleteCommand => throw new NotImplementedException();

        protected override string SelectCommand => throw new NotImplementedException();

        protected override string SelectAllCommand => throw new NotImplementedException();

        public void AdicionarItemTema(Tema temaSelecionado, List<ItemTema> itens)
        {
            temaSelecionado.Itens = itens;
        }

        protected override void ConfigurarParametros(Tema registro)
        {
            throw new NotImplementedException();
        }
    }
}
