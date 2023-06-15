using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
