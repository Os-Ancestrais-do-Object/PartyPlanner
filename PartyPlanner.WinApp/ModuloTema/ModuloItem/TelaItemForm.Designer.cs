namespace PartyPlanner.WinApp.ModuloTema.ModuloItem
{
    partial class TelaItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            lbTema = new Label();
            btnCancelar = new Button();
            btnAdd = new Button();
            txtDescricao = new TextBox();
            btnAdicionarItem = new Button();
            btnExcluirItem = new Button();
            label2 = new Label();
            txtValor = new TextBox();
            listItem = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lbErroDescricao = new Label();
            lbErroValor = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 107);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 27;
            label1.Text = "Item:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTema);
            groupBox1.Location = new Point(101, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 59);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tema Selecionado";
            // 
            // lbTema
            // 
            lbTema.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbTema.Location = new Point(0, 17);
            lbTema.Name = "lbTema";
            lbTema.Size = new Size(200, 39);
            lbTema.TabIndex = 1;
            lbTema.Text = "*Tema*";
            lbTema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(336, 514);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(260, 514);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Gravar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(91, 103);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(113, 23);
            txtDescricao.TabIndex = 23;
            txtDescricao.TextChanged += Validacoes_TextChanged;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Enabled = false;
            btnAdicionarItem.Location = new Point(56, 452);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(75, 23);
            btnAdicionarItem.TabIndex = 21;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Enabled = false;
            btnExcluirItem.Location = new Point(269, 452);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(75, 23);
            btnExcluirItem.TabIndex = 29;
            btnExcluirItem.Text = "Excluir";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 107);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 31;
            label2.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(258, 103);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(86, 23);
            txtValor.TabIndex = 30;
            txtValor.TextChanged += Validacoes_TextChanged;
            txtValor.KeyPress += ApenasNumeros_KeyPress;
            // 
            // listItem
            // 
            listItem.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listItem.FullRowSelect = true;
            listItem.GridLines = true;
            listItem.Location = new Point(56, 142);
            listItem.MultiSelect = false;
            listItem.Name = "listItem";
            listItem.Size = new Size(288, 304);
            listItem.TabIndex = 32;
            listItem.UseCompatibleStateImageBehavior = false;
            listItem.View = View.Details;
            listItem.SelectedIndexChanged += listItem_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Descrição";
            columnHeader1.Width = 188;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.Width = 95;
            // 
            // lbErroDescricao
            // 
            lbErroDescricao.AutoSize = true;
            lbErroDescricao.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroDescricao.ForeColor = Color.Red;
            lbErroDescricao.Location = new Point(91, 88);
            lbErroDescricao.Name = "lbErroDescricao";
            lbErroDescricao.Size = new Size(112, 13);
            lbErroDescricao.TabIndex = 33;
            lbErroDescricao.Text = "*Campo Obrigatório";
            lbErroDescricao.Visible = false;
            // 
            // lbErroValor
            // 
            lbErroValor.AutoSize = true;
            lbErroValor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroValor.ForeColor = Color.Red;
            lbErroValor.Location = new Point(258, 88);
            lbErroValor.Name = "lbErroValor";
            lbErroValor.Size = new Size(112, 13);
            lbErroValor.TabIndex = 34;
            lbErroValor.Text = "*Campo Obrigatório";
            lbErroValor.Visible = false;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 562);
            Controls.Add(lbErroValor);
            Controls.Add(lbErroDescricao);
            Controls.Add(listItem);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(btnExcluirItem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(txtDescricao);
            Controls.Add(btnAdicionarItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Itens";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        internal Label lbTema;
        internal Button btnCancelar;
        internal Button btnAdd;
        internal TextBox txtDescricao;
        private Label label2;
        internal TextBox txtValor;
        private ListView listItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lbErroDescricao;
        private Label lbErroValor;
        private Button btnAdicionarItem;
        private Button btnExcluirItem;
    }
}