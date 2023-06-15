namespace PartyPlanner.WinApp.ModuloAluguel
{
    partial class TelaStatusForm
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
            components = new System.ComponentModel.Container();
            cbStatus = new ComboBox();
            label3 = new Label();
            txtData = new DateTimePicker();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            label2 = new Label();
            lbAluguel = new Label();
            aluguelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)aluguelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(113, 51);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(127, 23);
            cbStatus.TabIndex = 24;
            cbStatus.SelectionChangeCommitted += cbStatus_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 102);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 31;
            label3.Text = "Data Quitação:";
            // 
            // txtData
            // 
            txtData.CustomFormat = "";
            txtData.Enabled = false;
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(113, 96);
            txtData.Name = "txtData";
            txtData.Size = new Size(127, 23);
            txtData.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 54);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 32;
            label1.Text = "Status:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(189, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 36);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(113, 156);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 36);
            btnGravar.TabIndex = 36;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 38;
            label2.Text = "Status de:";
            // 
            // lbAluguel
            // 
            lbAluguel.AutoSize = true;
            lbAluguel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbAluguel.Location = new Point(76, 7);
            lbAluguel.Name = "lbAluguel";
            lbAluguel.Size = new Size(0, 19);
            lbAluguel.TabIndex = 39;
            // 
            // aluguelBindingSource
            // 
            aluguelBindingSource.DataSource = typeof(Dominio.ModuloAluguel.Aluguel);
            // 
            // TelaStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 204);
            Controls.Add(lbAluguel);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtData);
            Controls.Add(cbStatus);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaStatusForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Status";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)aluguelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label2;
        private BindingSource aluguelBindingSource;
        private Label lbAluguel;
        internal ComboBox cbStatus;
        internal DateTimePicker txtData;
    }
}