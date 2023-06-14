using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.WinApp.ModuloTema.ModuloItem;

namespace PartyPlanner.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase<Tema, RepositorioTema, TabelaTemaControl, TelaTemaForm, NenhumRepositorio, NenhumRepositorio>
    {
        private RepositorioTema _repositorioTema;
        private TabelaTemaControl _tabelaTema;

        public ControladorTema(RepositorioTema _repositorio, TabelaTemaControl _tabela) : base(_repositorio, _tabela)
        {
            _repositorioTema = _repositorio;
            _tabelaTema = _tabela;
        }

        public override void AdicionarItens()
        {
            TelaItemForm telaItem = new();

            Tema temaSelecionado = _tabelaTema.ObterRegistroSelecionado();

            telaItem.lbTema.Text = temaSelecionado.Nome;

            telaItem.Entidade = temaSelecionado.Itens;

            TelaPrincipalForm.AtualizarStatus($"Cadastrando Itens");

            if (telaItem.ShowDialog() == DialogResult.OK)
            {
                _repositorioTema.AdicionarItemTema(temaSelecionado, telaItem.Entidade);
            }

            CarregarRegistros();
        }

        public override TabelaTemaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
