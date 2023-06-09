namespace PartyPlanner.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtData = new DateTimePicker();
            cbFesta = new ComboBox();
            txtValorTotal = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            txtValorCobrado = new TextBox();
            label5 = new Label();
            txtSinal = new TextBox();
            label7 = new Label();
            txtDesconto = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(364, 199);
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
            btnAdd.Location = new Point(288, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 97);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 29;
            label3.Text = "Data Quitação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 152);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 28;
            label2.Text = "Valor Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Número:";
            // 
            // txtData
            // 
            txtData.CustomFormat = "";
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(118, 91);
            txtData.Name = "txtData";
            txtData.Size = new Size(127, 23);
            txtData.TabIndex = 24;
            // 
            // cbFesta
            // 
            cbFesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFesta.FormattingEnabled = true;
            cbFesta.Location = new Point(118, 62);
            cbFesta.Name = "cbFesta";
            cbFesta.Size = new Size(203, 23);
            cbFesta.TabIndex = 23;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(323, 149);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(95, 23);
            txtValorTotal.TabIndex = 22;
            txtValorTotal.KeyPress += ApenasNumeros_KeyPress;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 65);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 36;
            label6.Text = "Festa de:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 38;
            label4.Text = "Valor Cobrado:";
            // 
            // txtValorCobrado
            // 
            txtValorCobrado.Location = new Point(118, 120);
            txtValorCobrado.Name = "txtValorCobrado";
            txtValorCobrado.Size = new Size(95, 23);
            txtValorCobrado.TabIndex = 37;
            txtValorCobrado.KeyPress += ApenasNumeros_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 123);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 40;
            label5.Text = "Sinal:";
            // 
            // txtSinal
            // 
            txtSinal.Location = new Point(323, 120);
            txtSinal.Name = "txtSinal";
            txtSinal.Size = new Size(95, 23);
            txtSinal.TabIndex = 39;
            txtSinal.KeyPress += ApenasNumeros_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 152);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 42;
            label7.Text = "Desconto(%):";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(118, 149);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(95, 23);
            txtDesconto.TabIndex = 41;
            txtDesconto.KeyPress += ApenasNumeros_KeyPress;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 247);
            Controls.Add(label7);
            Controls.Add(txtDesconto);
            Controls.Add(label5);
            Controls.Add(txtSinal);
            Controls.Add(label4);
            Controls.Add(txtValorCobrado);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtData);
            Controls.Add(cbFesta);
            Controls.Add(txtValorTotal);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Aluguéis";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker txtData;
        public ComboBox cbFesta;
        private TextBox txtValorTotal;
        public TextBox txtId;
        private Label label6;
        private Label label4;
        private TextBox txtValorCobrado;
        private Label label5;
        private TextBox txtSinal;
        private Label label7;
        private TextBox txtDesconto;
    }
}