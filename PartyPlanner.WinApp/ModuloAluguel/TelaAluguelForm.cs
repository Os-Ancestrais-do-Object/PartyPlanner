using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form, ITelaBase<Aluguel>
    {
        private Aluguel _aluguel;

        private bool isValid;

        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        public TextBox TxtId => txtId;

        public Aluguel? Entidade
        {
            set
            {
                txtId.Text = value.id.ToString();
                //cbFesta.Text = value.Festa.Cliente.Nome;
                txtValorCobrado.Text = value.ValorCobrado.ToString();
                txtDesconto.Text = value.Desconto.ToString();
                txtSinal.Text = value.Sinal.ToString();
                txtValorTotal.Text = value.ValorTotal.ToString();
            }
            get
            {
                return _aluguel;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);

            if (isValid == false)
            {
                this.DialogResult = DialogResult.None;
                ImplementarMetodos();
                return;
            }

            Festa? festa = cbFesta.SelectedItem as Festa;

            _aluguel = new Aluguel(festa, Convert.ToDecimal(txtValorCobrado.Text), txtDesconto.Value, Convert.ToDecimal(txtSinal.Text), Convert.ToDecimal(txtValorTotal.Text), StatusAluguel.EmAberto);

            if (_aluguel.id == 0)
                _aluguel.id = int.Parse(txtId.Text);
        }

        private void ImplementarMetodos()
        {
            cbFesta.TextChanged += ValidarCampos;
            txtValorCobrado.TextChanged += ValidarCampos;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            Aluguel aluguel = new();

            lbErroFesta.Visible = aluguel.ValidarCampoVazio(cbFesta.Text);
            lbErroValorCobrado.Visible = aluguel.ValidarCampoVazio(txtValorCobrado.Text);

            if (lbErroFesta.Visible || lbErroValorCobrado.Visible)
                isValid = false;
            else
                isValid = true;
        }

        private void Calcular_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorCobrado.Text))
            {
                txtValorTotal.ResetText();
                txtSinal.ResetText();

                return;
            }

            decimal valorCobrado = Convert.ToDecimal(txtValorCobrado.Text);
            decimal desconto = Convert.ToDecimal(txtDesconto.Value) / 100;

            decimal valorTotal = valorCobrado - (valorCobrado * desconto);
            decimal sinal = valorTotal - valorTotal * 0.6m;

            txtValorTotal.Text = $"{valorTotal:F2}";
            txtSinal.Text = $"{sinal:F2}";
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && (txt.Text == "" || txt.Text.Contains(",")))
                e.Handled = true;
        }

        private void cbFesta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Festa festaSelecionada = (Festa)cbFesta.SelectedItem;
            decimal valorTotal = Math.Round(festaSelecionada.Tema.ValorTotal * (decimal)(festaSelecionada.HoraFinal - festaSelecionada.HoraInicio).TotalHours);
            txtValorCobrado.Text = valorTotal.ToString();
        }
    }
}
