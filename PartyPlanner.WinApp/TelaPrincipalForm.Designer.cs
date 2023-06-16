namespace PartyPlanner.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            toolStrip1 = new ToolStrip();
            btnCliente = new ToolStripButton();
            btnFesta = new ToolStripButton();
            btnTema = new ToolStripButton();
            btnAluguel = new ToolStripButton();
            barraFuncoes = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAddItem = new ToolStripButton();
            btnAttStatus = new ToolStripButton();
            lbTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            plPrincipal = new Panel();
            toolStrip1.SuspendLayout();
            barraFuncoes.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(0, 100, 165);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCliente, btnFesta, btnTema, btnAluguel });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1013, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(0, 100, 165);
            btnCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCliente.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.White;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageTransparentColor = Color.Magenta;
            btnCliente.Margin = new Padding(0);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(15);
            btnCliente.RightToLeft = RightToLeft.No;
            btnCliente.Size = new Size(106, 58);
            btnCliente.Text = "Cliente";
            btnCliente.TextDirection = ToolStripTextDirection.Horizontal;
            btnCliente.Click += btnCliente_Click;
            btnCliente.MouseEnter += btnColor_MouseEnter;
            btnCliente.MouseLeave += btnColor_MouseLeave;
            // 
            // btnFesta
            // 
            btnFesta.BackColor = Color.FromArgb(0, 100, 165);
            btnFesta.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFesta.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnFesta.ForeColor = Color.White;
            btnFesta.Image = (Image)resources.GetObject("btnFesta.Image");
            btnFesta.ImageTransparentColor = Color.Magenta;
            btnFesta.Margin = new Padding(0);
            btnFesta.Name = "btnFesta";
            btnFesta.Padding = new Padding(15);
            btnFesta.RightToLeft = RightToLeft.No;
            btnFesta.Size = new Size(92, 58);
            btnFesta.Text = "Festa";
            btnFesta.TextDirection = ToolStripTextDirection.Horizontal;
            btnFesta.Click += btnFesta_Click;
            btnFesta.MouseEnter += btnColor_MouseEnter;
            btnFesta.MouseLeave += btnColor_MouseLeave;
            // 
            // btnTema
            // 
            btnTema.BackColor = Color.FromArgb(0, 100, 165);
            btnTema.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTema.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTema.ForeColor = Color.White;
            btnTema.Image = (Image)resources.GetObject("btnTema.Image");
            btnTema.ImageTransparentColor = Color.Magenta;
            btnTema.Margin = new Padding(0);
            btnTema.Name = "btnTema";
            btnTema.Padding = new Padding(15);
            btnTema.RightToLeft = RightToLeft.No;
            btnTema.Size = new Size(95, 58);
            btnTema.Text = "Tema";
            btnTema.TextDirection = ToolStripTextDirection.Horizontal;
            btnTema.Click += btnTema_Click;
            btnTema.MouseEnter += btnColor_MouseEnter;
            btnTema.MouseLeave += btnColor_MouseLeave;
            // 
            // btnAluguel
            // 
            btnAluguel.BackColor = Color.FromArgb(0, 100, 165);
            btnAluguel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAluguel.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAluguel.ForeColor = Color.White;
            btnAluguel.Image = (Image)resources.GetObject("btnAluguel.Image");
            btnAluguel.ImageTransparentColor = Color.Magenta;
            btnAluguel.Margin = new Padding(0);
            btnAluguel.Name = "btnAluguel";
            btnAluguel.Padding = new Padding(15);
            btnAluguel.RightToLeft = RightToLeft.No;
            btnAluguel.Size = new Size(110, 58);
            btnAluguel.Text = "Aluguel";
            btnAluguel.TextDirection = ToolStripTextDirection.Horizontal;
            btnAluguel.Click += btnAluguel_Click;
            btnAluguel.MouseEnter += btnColor_MouseEnter;
            btnAluguel.MouseLeave += btnColor_MouseLeave;
            // 
            // barraFuncoes
            // 
            barraFuncoes.BackColor = Color.White;
            barraFuncoes.GripStyle = ToolStripGripStyle.Hidden;
            barraFuncoes.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnAddItem, btnAttStatus, lbTipoCadastro });
            barraFuncoes.Location = new Point(0, 58);
            barraFuncoes.Name = "barraFuncoes";
            barraFuncoes.Size = new Size(1013, 54);
            barraFuncoes.TabIndex = 1;
            barraFuncoes.Visible = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(80, 230, 80);
            btnAdicionar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Image = Properties.Resources.add;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Margin = new Padding(10);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(103, 34);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(80, 130, 230);
            btnEditar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Image = Properties.Resources.edit;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(79, 34);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(230, 80, 80);
            btnExcluir.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Image = Properties.Resources.remove;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(10);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(85, 34);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Yellow;
            btnAddItem.Enabled = false;
            btnAddItem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Image = Properties.Resources.addItem;
            btnAddItem.ImageScaling = ToolStripItemImageScaling.None;
            btnAddItem.ImageTransparentColor = Color.Magenta;
            btnAddItem.Margin = new Padding(10);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(5);
            btnAddItem.Size = new Size(135, 34);
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnAttStatus
            // 
            btnAttStatus.BackColor = Color.Orange;
            btnAttStatus.Enabled = false;
            btnAttStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttStatus.Image = Properties.Resources.statusCheck;
            btnAttStatus.ImageScaling = ToolStripItemImageScaling.None;
            btnAttStatus.ImageTransparentColor = Color.Magenta;
            btnAttStatus.Margin = new Padding(10);
            btnAttStatus.Name = "btnAttStatus";
            btnAttStatus.Padding = new Padding(5);
            btnAttStatus.Size = new Size(142, 34);
            btnAttStatus.Text = "Atualizar Status";
            btnAttStatus.Click += btnAttStatus_Click;
            // 
            // lbTipoCadastro
            // 
            lbTipoCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTipoCadastro.Name = "lbTipoCadastro";
            lbTipoCadastro.Size = new Size(0, 51);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1013, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 17);
            // 
            // plPrincipal
            // 
            plPrincipal.Dock = DockStyle.Fill;
            plPrincipal.Location = new Point(0, 58);
            plPrincipal.Name = "plPrincipal";
            plPrincipal.Size = new Size(1013, 546);
            plPrincipal.TabIndex = 3;
            plPrincipal.ControlAdded += plPrincipal_ControlAdded;
            plPrincipal.ControlRemoved += plPrincipal_ControlRemoved;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 626);
            Controls.Add(plPrincipal);
            Controls.Add(barraFuncoes);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Party Planner";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            barraFuncoes.ResumeLayout(false);
            barraFuncoes.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCliente;
        private ToolStripButton btnFesta;
        private ToolStripButton btnTema;
        private ToolStripButton btnAluguel;
        private ToolStrip barraFuncoes;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbStatus;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lbTipoCadastro;
        private Panel plPrincipal;
        private ToolStripButton btnAddItem;
        private ToolStripButton btnAttStatus;
    }
}