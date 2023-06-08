namespace PartyPlanner.WinApp.ModuloFesta
{
    partial class TabelaFestaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridFesta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridFesta).BeginInit();
            SuspendLayout();
            // 
            // gridFesta
            // 
            gridFesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFesta.Location = new Point(208, 126);
            gridFesta.Name = "gridFesta";
            gridFesta.RowTemplate.Height = 25;
            gridFesta.Size = new Size(240, 150);
            gridFesta.TabIndex = 0;
            // 
            // TabelaFestaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridFesta);
            Name = "TabelaFestaControl";
            Size = new Size(656, 397);
            ((System.ComponentModel.ISupportInitialize)gridFesta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridFesta;
    }
}
