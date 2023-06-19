using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dominio.ModuloAluguel;

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
            onAtualizarItensReferentes += AtualizarAluguelAtivo;
        }

        private void AtualizarAluguelAtivo(Aluguel aluguel)
        {
            aluguel.Festa.AluguelAtivo = false;
        }

        public void CarregarComboBox(TelaAluguelForm telaAluguel)
        {
            telaAluguel.cbFesta.DisplayMember = "Tema.Nome";
            telaAluguel.cbFesta.ValueMember = "Tema.Nome";
            telaAluguel.cbFesta.DataSource = _repositorioFesta.ObterFestasSemAlguel();
            telaAluguel.cbFesta.SelectedIndex = -1;
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
