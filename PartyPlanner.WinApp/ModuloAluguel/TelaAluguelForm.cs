using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form, ITelaBase<Aluguel>
    {
        private Aluguel _aluguel;

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
                txtData.Text = value.DataQuitacao.ToString("d");
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
            Festa? festa = null;//cbFesta.SelectedItem as Festa;

            _aluguel = new Aluguel(festa, Convert.ToDateTime(txtData.Text), Convert.ToDecimal(txtValorCobrado.Text), Convert.ToDecimal(txtDesconto.Text), Convert.ToDecimal(txtSinal.Text), Convert.ToDecimal(txtValorTotal.Text));

            if (_aluguel.id == 0)
                _aluguel.id = int.Parse(txtId.Text);
        }

        private void Calcular_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorCobrado.Text) || string.IsNullOrEmpty(txtDesconto.Text))
            {
                txtValorTotal.ResetText();
                txtSinal.ResetText();

                return;
            }

            decimal valorCobrado = Convert.ToDecimal(txtValorCobrado.Text);
            decimal desconto = Convert.ToDecimal(txtDesconto.Text) / 100;

            decimal valorTotal = valorCobrado - (valorCobrado * desconto);
            decimal sinal = valorTotal - valorTotal * 0.6m;

            txtValorTotal.Text = $"R${valorTotal:F2}";
            txtSinal.Text = $"R${sinal:F2}";
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && (txt.Text == "" || txt.Text.Contains(",")))
                e.Handled = true;
        }

        private void Limit100_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            ApenasNumeros_KeyPress(sender, e);

            if (char.IsDigit(e.KeyChar))
            {
                decimal desconto = Convert.ToDecimal(txt.Text + e.KeyChar);

                e.Handled = desconto > 100;
            }
        }
    }
}
