using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloFesta;

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
                //txtEndereco.Text = value.Festa.Cliente.Nome;
                //txtData.Text = value.Data;
                //txtValorCobrado.Text = value.ValorCobrado;
                //txtDesconto.Text = value.Desconto;
                //txtSinal.Text = value.Sinal;
                //txtValorTotal.Text = value.ValorTotal;
            }
            get
            {
                return _aluguel;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Festa festa = cbFesta.SelectedItem as Festa;

            //_aluguel = new Aluguel(festa, txtData.Text, txtValorCobrado.Text, txtValorCobrado.Text, txtDesconto.Text, txtSinal.Text, txtValorTotal.Text);

            if (_aluguel.id == 0)
                _aluguel.id = int.Parse(txtId.Text);
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && (txt.Text == "" || txt.Text.Contains(",")))
                e.Handled = true;
        }
    }
}
