namespace PartyPlanner.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            btnCancelar = new Button();
            btnAdd = new Button();
            lbNome = new Label();
            lbTelefone = new Label();
            lbId = new Label();
            txtTelefone = new MaskedTextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            lbErroNome = new Label();
            lbErroTelefone = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(373, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(297, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(36, 78);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 20;
            lbNome.Text = "Nome:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(25, 120);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(54, 15);
            lbTelefone.TabIndex = 19;
            lbTelefone.Text = "Telefone:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(25, 36);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 18;
            lbId.Text = "Número:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(85, 117);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 23);
            txtTelefone.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(85, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 15;
            // 
            // lbErroNome
            // 
            lbErroNome.AutoSize = true;
            lbErroNome.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroNome.ForeColor = Color.Red;
            lbErroNome.Location = new Point(85, 59);
            lbErroNome.Name = "lbErroNome";
            lbErroNome.Size = new Size(112, 13);
            lbErroNome.TabIndex = 44;
            lbErroNome.Text = "*Campo Obrigatório";
            lbErroNome.Visible = false;
            // 
            // lbErroTelefone
            // 
            lbErroTelefone.AutoSize = true;
            lbErroTelefone.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroTelefone.ForeColor = Color.Red;
            lbErroTelefone.Location = new Point(85, 101);
            lbErroTelefone.Name = "lbErroTelefone";
            lbErroTelefone.Size = new Size(112, 13);
            lbErroTelefone.TabIndex = 45;
            lbErroTelefone.Text = "*Campo Obrigatório";
            lbErroTelefone.Visible = false;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 272);
            Controls.Add(lbErroTelefone);
            Controls.Add(lbErroNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(lbNome);
            Controls.Add(lbTelefone);
            Controls.Add(lbId);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private Label lbNome;
        private Label lbTelefone;
        private Label lbId;
        private MaskedTextBox txtTelefone;
        private TextBox txtNome;
        public TextBox txtId;
        private Label lbErroNome;
        private Label lbErroTelefone;
    }
}