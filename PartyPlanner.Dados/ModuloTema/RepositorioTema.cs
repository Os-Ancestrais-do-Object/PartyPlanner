using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;

namespace PartyPlanner.Dados.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>
    {
        public RepositorioTema(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Temas.Count > 0)
                id = dataContext.Temas.Max(x => x.id) + 1;
        }

        protected override List<Tema> ListaRegistros => dataContext.Temas;

        public void AdicionarItemTema(Tema temaSelecionado, List<TemaItem> itens)
        {
            //temaSelecionado.itens.AddRange(itens);

            dataContext.GravarRegistrosEmArquivoBIN();
        }
    }
}
