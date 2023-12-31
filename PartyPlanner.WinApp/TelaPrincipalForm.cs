using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Infra.Dados.Arquivo.Compartilhado;
using PartyPlanner.WinApp.ModuloAluguel;
using PartyPlanner.WinApp.ModuloCliente;
using PartyPlanner.WinApp.ModuloFesta;
using PartyPlanner.WinApp.ModuloTema;

namespace PartyPlanner.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Dictionary<Control, ToolStripButton> coresBotoes = new();

        private IControladorBase _controladorBase;
        private UserControl _tabela;

        private static TelaPrincipalForm _telaPrincipal;
        private static DataContext _dataContext = new(carregarDados: true);

        private RepositorioAluguel _repositorioAluguel = new(_dataContext);
        private RepositorioCliente _repositorioCliente = new(_dataContext);
        private RepositorioFesta _repositorioFesta = new(_dataContext);
        private RepositorioTema _repositorioTema = new(_dataContext);

        private TabelaAluguelControl _tabelaAluguel = new();
        private TabelaClienteControl _tabelaCliente = new();
        private TabelaFestaControl _tabelaFesta = new();
        private TabelaTemaControl _tabelaTema = new();

        public TelaPrincipalForm()
        {
            InitializeComponent();

            _telaPrincipal = this;

            AdicionarBotoesDicionario();
        }

        private void AdicionarBotoesDicionario()
        {
            coresBotoes.Add(_tabelaCliente, btnCliente);
            coresBotoes.Add(_tabelaFesta, btnFesta);
            coresBotoes.Add(_tabelaTema, btnTema);
            coresBotoes.Add(_tabelaAluguel, btnAluguel);
        }

        public static void AtualizarStatus(string status)
        {
            _telaPrincipal.lbStatus.Text = status;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorCliente(_repositorioCliente, _tabelaCliente);

            ConfigurarTelaPrincipal();
        }

        private void btnFesta_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorFesta(_repositorioFesta, _tabelaFesta, _repositorioCliente, _repositorioTema);

            ConfigurarTelaPrincipal();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorTema(_repositorioTema, _tabelaTema);

            ConfigurarTelaPrincipal();
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            _controladorBase = new ControladorAluguel(_repositorioAluguel, _tabelaAluguel, _repositorioFesta);

            ConfigurarTelaPrincipal();
        }

        private void ConfigurarTelaPrincipal()
        {
            ConfigurarListagem();

            ConfigurarToolTipsAndButtons();

            AbrirListagem();

            ResetarBotoes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controladorBase.Adicionar();
            ResetarBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controladorBase.Editar();
            ResetarBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controladorBase.Excluir();
            ResetarBotoes();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _controladorBase.AdicionarItens();
            ResetarBotoes();
        }

        private void btnAttStatus_Click(object sender, EventArgs e)
        {
            _controladorBase.AtualizarStatus();
            ResetarBotoes();
        }

        private void AbrirListagem()
        {
            lbTipoCadastro.Text = _controladorBase.ObterTipoCadastro();
            plPrincipal.Controls.Clear();
            plPrincipal.Controls.Add(_tabela);
            _controladorBase.CarregarRegistros();
        }

        private void ConfigurarListagem()
        {
            _tabela = _controladorBase.ObterListagem();

            _tabela.Dock = DockStyle.Fill;
        }

        private void ConfigurarToolTipsAndButtons()
        {
            btnAdicionar.ToolTipText = _controladorBase.ToolTipAdicionar;
            btnEditar.ToolTipText = _controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = _controladorBase.ToolTipExcluir;
            barraFuncoes.Visible = true;
        }

        private void ResetarBotoes()
        {
            ConfigurarBotaoItem();

            ConfigurarBotaoAtualizarStatus();

            if (((DataGridView)_tabela.Controls[0]).SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void ConfigurarBotaoItem()
        {
            if (((DataGridView)_tabela.Controls[0]).SelectedRows.Count > 0 && _controladorBase is ControladorTema)
                btnAddItem.Enabled = true;
            else
                btnAddItem.Enabled = false;
        }

        private void ConfigurarBotaoAtualizarStatus()
        {
            if (((DataGridView)_tabela.Controls[0]).SelectedRows.Count > 0 && _controladorBase is ControladorAluguel)
                btnAttStatus.Enabled = true;
            else
                btnAttStatus.Enabled = false;
        }

        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            btn.ForeColor = Color.Black;
        }

        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            btn.ForeColor = Color.White;
        }

        private void plPrincipal_ControlAdded(object sender, ControlEventArgs e)
        {
            ToolStripButton btn;

            coresBotoes.TryGetValue(e.Control, out btn);

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.MouseLeave -= btnColor_MouseLeave;
        }

        private void plPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            ToolStripButton btn;

            coresBotoes.TryGetValue(e.Control, out btn);

            btn.BackColor = Color.FromArgb(0, 100, 165);
            btn.ForeColor = Color.White;
            btn.MouseLeave += btnColor_MouseLeave;
        }
    }
}