namespace PartyPlanner.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            txtId = new TextBox();
            txtNome = new TextBox();
            lbNome = new Label();
            lbId = new Label();
            lbErro = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(273, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(197, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 22;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(190, 23);
            txtNome.TabIndex = 20;
            txtNome.TextChanged += Validacoes_TextChanged;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(40, 56);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 18;
            lbNome.Text = "Nome:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(29, 27);
            lbId.Name = "lbId";
            lbId.Size = new Size(54, 15);
            lbId.TabIndex = 17;
            lbId.Text = "Número:";
            // 
            // lbErro
            // 
            lbErro.AutoSize = true;
            lbErro.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErro.ForeColor = Color.Red;
            lbErro.Location = new Point(164, 37);
            lbErro.Name = "lbErro";
            lbErro.Size = new Size(112, 13);
            lbErro.TabIndex = 25;
            lbErro.Text = "*Campo Obrigatório";
            lbErro.Visible = false;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 152);
            Controls.Add(lbErro);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Temas";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        public TextBox txtId;
        private TextBox txtNome;
        private Label lbNome;
        private Label lbId;
        private Label lbErro;
    }
}