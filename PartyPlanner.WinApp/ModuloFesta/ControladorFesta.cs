using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase<Festa, RepositorioFesta, TabelaFestaControl, TelaFestaForm, RepositorioCliente, RepositorioTema>
    {
        private RepositorioFesta _repositorioFesta;
        private TabelaFestaControl _tabelaFesta;

        private RepositorioTema _repositorioTema;
        private RepositorioCliente _repositorioCliente;

        public ControladorFesta(RepositorioFesta _repositorio, TabelaFestaControl _tabela, RepositorioCliente _repositorio2, RepositorioTema _repositorio3) : base(_repositorio, _tabela, _repositorio2, _repositorio3)
        {
            _repositorioFesta = _repositorio;
            _tabelaFesta = _tabela;
            _repositorioCliente = _repositorio2;
            _repositorioTema = _repositorio3;

            onCarregarArquivosEComandos += CarregarComboBox;
            onAtualizarItensReferentes += AtualizarReservasTema;
        }

        public void CarregarComboBox(TelaFestaForm telaFesta)
        {
            telaFesta.cbTema.DisplayMember = "Nome";
            telaFesta.cbTema.ValueMember = "Nome";
            telaFesta.cbTema.DataSource = _repositorioTema.ObterListaRegistros();

            telaFesta.cbCliente.DisplayMember = "Nome";
            telaFesta.cbCliente.ValueMember = "Nome";
            telaFesta.cbCliente.DataSource = _repositorioCliente.ObterListaRegistros();
        }

        public void AtualizarReservasTema(Festa festa)
        {
            festa.Tema.Reservas.Remove(festa.Data);
        }

        public override TabelaFestaControl ObterListagem()
        {
            return _tabela;
        }
    }
}
