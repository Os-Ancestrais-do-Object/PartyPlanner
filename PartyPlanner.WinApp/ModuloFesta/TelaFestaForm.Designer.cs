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
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(410, 254);
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
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(334, 254);
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
            txtFinal.Location = new Point(306, 154);
            txtFinal.Name = "txtFinal";
            txtFinal.ShowUpDown = true;
            txtFinal.Size = new Size(127, 23);
            txtFinal.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 158);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 31;
            label5.Text = "Término:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 158);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 30;
            label4.Text = "Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 131);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 29;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 67);
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
            txtInicio.Location = new Point(97, 154);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(127, 23);
            txtInicio.TabIndex = 26;
            // 
            // txtData
            // 
            txtData.CustomFormat = "";
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(97, 125);
            txtData.Name = "txtData";
            txtData.Size = new Size(127, 23);
            txtData.TabIndex = 24;
            // 
            // cbTema
            // 
            cbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(97, 96);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(203, 23);
            cbTema.TabIndex = 23;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(97, 64);
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
            label6.Location = new Point(53, 99);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 36;
            label6.Text = "Tema:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 186);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 38;
            label7.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(97, 183);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(203, 23);
            cbCliente.TabIndex = 37;
            // 
            // TelaFestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 302);
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
        public ComboBox cbTema;
        private TextBox txtEndereco;
        public TextBox txtId;
        private Label label6;
        private Label label7;
        public ComboBox cbCliente;
    }
}