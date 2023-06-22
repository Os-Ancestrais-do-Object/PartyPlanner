using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.Dados.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBaseSql<Aluguel>
    {
        protected override string AddCommand => throw new NotImplementedException();

        protected override string EditCommand => throw new NotImplementedException();

        protected override string DeleteCommand => throw new NotImplementedException();

        protected override string SelectCommand => throw new NotImplementedException();

        protected override string SelectAllCommand => throw new NotImplementedException();

        public void AtualizarStatusAluguel(Aluguel aluguelSelecionado, StatusAluguel statusSelecionado, DateTime? dataQuitacao)
        {
            aluguelSelecionado.StatusAluguel = statusSelecionado;

            aluguelSelecionado.DataQuitacao = dataQuitacao.HasValue ? dataQuitacao.Value : null;
        }

        protected override void ConfigurarParametros(Aluguel registro)
        {
            throw new NotImplementedException();
        }
    }
}
