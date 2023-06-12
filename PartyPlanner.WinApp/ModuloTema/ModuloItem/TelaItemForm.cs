using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;

namespace PartyPlanner.WinApp.ModuloTema.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private List<ItemTema> _temaItens;

        public TelaItemForm()
        {
            InitializeComponent();
        }

        public List<ItemTema> Entidade
        {
            set
            {
                _temaItens = new List<ItemTema>(value);

                if (value != null)
                    AtualizarLista();
            }
            get
            {
                return _temaItens;
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            ItemTema itemTema = new(txtDescricao.Text, Convert.ToDecimal(txtValor.Text));

            _temaItens.Add(itemTema);

            AtualizarLista();

            txtDescricao.ResetText();

            txtValor.ResetText();

            txtDescricao.Focus();

            lbErroDescricao.Visible = false;

            lbErroValor.Visible = false;
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (listItem.SelectedItems.Count == 0)
            {
                btnExcluirItem.Enabled = false;
                return;
            }

            ItemTema? itemSelecionado = ObterItemSelecionado();

            TelaPrincipalForm.AtualizarStatus($"Excluindo {itemSelecionado.Descricao}");

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja mesmo excluir?", $"Exclusão de Itens",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _temaItens.Remove(itemSelecionado);
            }

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listItem.Items.Clear();

            foreach (ItemTema item in _temaItens)
            {
                ListViewItem itemView = new ListViewItem(item.Descricao);
                itemView.SubItems.Add("R$" + item.Valor.ToString());
                itemView.Tag = item;
                listItem.Items.Add(itemView);
            }
        }

        public ItemTema? ObterItemSelecionado()
        {
            ListViewItem? itemSelecionado = listItem.SelectedItems.Count > 0 ? listItem.SelectedItems[0] : null;
            return (ItemTema?)itemSelecionado?.Tag;
        }

        private void Validacoes_TextChanged(object sender, EventArgs e)
        {
            ItemTema itemTema = new();

            lbErroDescricao.Visible = itemTema.ValidarCampoVazio(txtDescricao.Text) ? true : false;

            lbErroValor.Visible = itemTema.ValidarCampoVazio(txtValor.Text) ? true : false;

            btnAdicionarItem.Enabled = !lbErroDescricao.Visible && !lbErroValor.Visible ? true : false;
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && (txt.Text == "" || txt.Text.Contains(",")))
                e.Handled = true;
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcluirItem.Enabled = listItem.SelectedItems.Count > 0;
        }
    }
}
