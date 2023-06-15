using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.Compartilhado;
using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.WinApp.ModuloFesta;
using PartyPlanner.WinApp.ModuloTema.ModuloItem;
using System.Xml.Linq;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase<Aluguel, RepositorioAluguel, TabelaAluguelControl, TelaAluguelForm, RepositorioFesta, NenhumRepositorio>
    {
        private RepositorioAluguel _repositorioAluguel;
        private TabelaAluguelControl _tabelaAluguel;

        private RepositorioFesta _repositorioFesta;

        public ControladorAluguel(RepositorioAluguel _repositorio, TabelaAluguelControl _tabela, RepositorioFesta _repositorio2) : base(_repositorio, _tabela, _repositorio2)
        {
            _repositorioAluguel = _repositorio;
            _tabelaAluguel = _tabela;
            _repositorioFesta = _repositorio2;

            onCarregarArquivosEComandos += CarregarComboBox;
        }

        public void CarregarComboBox(TelaAluguelForm telaAluguel)
        {
            telaAluguel.cbFesta.DisplayMember = "Tema.Nome";
            telaAluguel.cbFesta.ValueMember = "Tema.Nome";
            telaAluguel.cbFesta.DataSource = _repositorioFesta.ObterListaRegistros();
        }

        public override void AtualizarStatus()
        {
            TelaStatusForm telaStatus = new();

            Aluguel aluguelSelecionado = _tabelaAluguel.ObterRegistroSelecionado();

            telaStatus.Entidade = aluguelSelecionado;

            TelaPrincipalForm.AtualizarStatus($"Atualizando Status");

            if (telaStatus.ShowDialog() == DialogResult.OK)
            {
                _repositorioAluguel.AtualizarStatusAluguel(aluguelSelecionado, (StatusAluguel)telaStatus.cbStatus.SelectedItem, telaStatus.txtData.Enabled ? telaStatus.txtData.Value : null);
            }

            CarregarRegistros();
        }

        public override TabelaAluguelControl ObterListagem()
        {
            return _tabela;
        }
    }
}
