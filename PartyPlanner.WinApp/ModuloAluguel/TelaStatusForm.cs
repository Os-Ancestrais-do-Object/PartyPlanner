using PartyPlanner.Dominio.ModuloAluguel;

namespace PartyPlanner.WinApp.ModuloAluguel
{
    public partial class TelaStatusForm : Form
    {
        public TelaStatusForm()
        {
            InitializeComponent();
        }

        public Aluguel? Entidade
        {
            set
            {
                lbAluguel.Text = "TESTE"; //aluguelSelecionado.Festa.Cliente.ToString();
                cbStatus.DataSource = Enum.GetValues(typeof(StatusAluguel));
                cbStatus.SelectedIndex = (int)value.StatusAluguel;
                txtData.Value = value.DataQuitacao.HasValue ? value.DataQuitacao.Value : DateTime.Now;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
        }

        private void cbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtData.Enabled = (StatusAluguel)cbStatus.SelectedItem == StatusAluguel.Faturado;
        }
    }
}
