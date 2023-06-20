namespace PartyPlanner.WinApp.ModuloFesta
{
    partial class TelaFestaForm
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
            txtFinal = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtInicio = new DateTimePicker();
            txtData = new DateTimePicker();
            cbTema = new ComboBox();
            txtEndereco = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cbCliente = new ComboBox();
            lbErroEndereco = new Label();
            lbErroTema = new Label();
            lbErroData = new Label();
            lbErroHora = new Label();
            lbErroCliente = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(410, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(334, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFinal
            // 
            txtFinal.CustomFormat = "HH:mm";
            txtFinal.Format = DateTimePickerFormat.Custom;
            txtFinal.Location = new Point(306, 203);
            txtFinal.Name = "txtFinal";
            txtFinal.ShowUpDown = true;
            txtFinal.Size = new Size(127, 23);
            txtFinal.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 207);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 31;
            label5.Text = "Término:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 209);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 30;
            label4.Text = "Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 167);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 29;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 28;
            label2.Text = "Endereço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Número:";
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "HH:mm";
            txtInicio.Format = DateTimePickerFormat.Custom;
            txtInicio.Location = new Point(97, 203);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(127, 23);
            txtInicio.TabIndex = 26;
            // 
            // txtData
            // 
            txtData.CustomFormat = "";
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(97, 161);
            txtData.Name = "txtData";
            txtData.Size = new Size(127, 23);
            txtData.TabIndex = 24;
            // 
            // cbTema
            // 
            cbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(97, 119);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(203, 23);
            cbTema.TabIndex = 23;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(97, 77);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(336, 23);
            txtEndereco.TabIndex = 22;
            // 
            // txtId
            // 
            txtId.Location = new Point(97, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 122);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 36;
            label6.Text = "Tema:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 248);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 38;
            label7.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(97, 245);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(203, 23);
            cbCliente.TabIndex = 37;
            // 
            // lbErroEndereco
            // 
            lbErroEndereco.AutoSize = true;
            lbErroEndereco.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroEndereco.ForeColor = Color.Red;
            lbErroEndereco.Location = new Point(97, 61);
            lbErroEndereco.Name = "lbErroEndereco";
            lbErroEndereco.Size = new Size(112, 13);
            lbErroEndereco.TabIndex = 39;
            lbErroEndereco.Text = "*Campo Obrigatório";
            lbErroEndereco.Visible = false;
            // 
            // lbErroTema
            // 
            lbErroTema.AutoSize = true;
            lbErroTema.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroTema.ForeColor = Color.Red;
            lbErroTema.Location = new Point(97, 103);
            lbErroTema.Name = "lbErroTema";
            lbErroTema.Size = new Size(112, 13);
            lbErroTema.TabIndex = 40;
            lbErroTema.Text = "*Campo Obrigatório";
            lbErroTema.Visible = false;
            // 
            // lbErroData
            // 
            lbErroData.AutoSize = true;
            lbErroData.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroData.ForeColor = Color.Red;
            lbErroData.Location = new Point(97, 145);
            lbErroData.Name = "lbErroData";
            lbErroData.Size = new Size(207, 13);
            lbErroData.TabIndex = 41;
            lbErroData.Text = "*Data não pode ser menor à data atual";
            lbErroData.Visible = false;
            // 
            // lbErroHora
            // 
            lbErroHora.AutoSize = true;
            lbErroHora.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroHora.ForeColor = Color.Red;
            lbErroHora.Location = new Point(97, 187);
            lbErroHora.Name = "lbErroHora";
            lbErroHora.Size = new Size(295, 13);
            lbErroHora.TabIndex = 42;
            lbErroHora.Text = "*Hora Início não pode ser maior ou igual à data término";
            lbErroHora.Visible = false;
            // 
            // lbErroCliente
            // 
            lbErroCliente.AutoSize = true;
            lbErroCliente.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbErroCliente.ForeColor = Color.Red;
            lbErroCliente.Location = new Point(97, 229);
            lbErroCliente.Name = "lbErroCliente";
            lbErroCliente.Size = new Size(112, 13);
            lbErroCliente.TabIndex = 43;
            lbErroCliente.Text = "*Campo Obrigatório";
            lbErroCliente.Visible = false;
            // 
            // TelaFestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 342);
            Controls.Add(lbErroCliente);
            Controls.Add(lbErroHora);
            Controls.Add(lbErroData);
            Controls.Add(lbErroTema);
            Controls.Add(lbErroEndereco);
            Controls.Add(label7);
            Controls.Add(cbCliente);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(txtFinal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInicio);
            Controls.Add(txtData);
            Controls.Add(cbTema);
            Controls.Add(txtEndereco);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFestaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Festa";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private DateTimePicker txtFinal;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker txtInicio;
        private DateTimePicker txtData;
        internal ComboBox cbTema;
        private TextBox txtEndereco;
        public TextBox txtId;
        private Label label6;
        private Label label7;
        internal ComboBox cbCliente;
        private Label lbErroEndereco;
        private Label lbErroTema;
        private Label lbErroData;
        private Label lbErroHora;
        private Label lbErroCliente;
    }
}