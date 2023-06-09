using PartyPlanner.Dominio.ModuloTema.ModuloItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PartyPlanner.WinApp.ModuloTema.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private List<TemaItem> _temaItens = new();

        public TelaItemForm()
        {
            InitializeComponent();
        }

        public List<TemaItem> Entidade
        {
            set
            {
                if (value != null)
                    foreach (TemaItem item in value)
                    {
                        //listItens.Items.Add(item.Descricao);
                    }
            }
            get
            {
                return _temaItens;
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            //TemaItem itemTema = new TemaItem(txtDescricao.Text, txtValor.Text);

            //_temaItens.Add(itemTema);

            listItem.Items.Clear();

            foreach (TemaItem temaItem in _temaItens)
            {
                ListViewItem item = new ListViewItem(temaItem.id.ToString());
                //item.SubItems.Add(temaItem.Descricao);
                //item.SubItems.Add(temaItem.Valor);
                item.Tag = temaItem;
                listItem.Items.Add(item);
            }

            txtDescricao.ResetText();

            txtValor.ResetText();

            txtDescricao.Focus();
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
