namespace Przychodnia.Grafik_formy
{
    partial class Odwolane_forma
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
            this.OdwolaneTabela = new System.Windows.Forms.DataGridView();
            this.Id_odwolania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pes_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacjent_ImNazw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lekarz_ImNazw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spec_Lek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odw_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OdwolaneTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // OdwolaneTabela
            // 
            this.OdwolaneTabela.AllowUserToAddRows = false;
            this.OdwolaneTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdwolaneTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_odwolania,
            this.Pes_pacjenta,
            this.Pacjent_ImNazw,
            this.Lekarz_ImNazw,
            this.Spec_Lek,
            this.odw_data});
            this.OdwolaneTabela.Location = new System.Drawing.Point(12, 12);
            this.OdwolaneTabela.Name = "OdwolaneTabela";
            this.OdwolaneTabela.Size = new System.Drawing.Size(1063, 292);
            this.OdwolaneTabela.TabIndex = 0;
            // 
            // Id_odwolania
            // 
            this.Id_odwolania.HeaderText = "ID Odwołania ";
            this.Id_odwolania.Name = "Id_odwolania";
            // 
            // Pes_pacjenta
            // 
            this.Pes_pacjenta.HeaderText = "PESEL Pacjenta";
            this.Pes_pacjenta.Name = "Pes_pacjenta";
            this.Pes_pacjenta.Width = 120;
            // 
            // Pacjent_ImNazw
            // 
            this.Pacjent_ImNazw.HeaderText = "Imię i Nazwisko Pacjenta ";
            this.Pacjent_ImNazw.Name = "Pacjent_ImNazw";
            this.Pacjent_ImNazw.Width = 200;
            // 
            // Lekarz_ImNazw
            // 
            this.Lekarz_ImNazw.HeaderText = "Imię i nazwisko Lekarza";
            this.Lekarz_ImNazw.Name = "Lekarz_ImNazw";
            this.Lekarz_ImNazw.Width = 200;
            // 
            // Spec_Lek
            // 
            this.Spec_Lek.HeaderText = "Specjalizacja Lekarza";
            this.Spec_Lek.Name = "Spec_Lek";
            this.Spec_Lek.Width = 200;
            // 
            // odw_data
            // 
            this.odw_data.HeaderText = "Data Odwołania Wizyty";
            this.odw_data.Name = "odw_data";
            this.odw_data.Width = 200;
            // 
            // Odwolane_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 452);
            this.Controls.Add(this.OdwolaneTabela);
            this.Name = "Odwolane_forma";
            this.Text = "Odwolane_forma";
            ((System.ComponentModel.ISupportInitialize)(this.OdwolaneTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OdwolaneTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_odwolania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pes_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacjent_ImNazw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lekarz_ImNazw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spec_Lek;
        private System.Windows.Forms.DataGridViewTextBoxColumn odw_data;
    }
}