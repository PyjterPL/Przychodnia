namespace Przychodnia.OddzialySpecjalizacje_formy
{
    partial class OdzSpecGlowneOkno
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
            this.SpecjalizacjeTabela = new System.Windows.Forms.DataGridView();
            this.DodSpec = new System.Windows.Forms.Button();
            this.EdtSpec = new System.Windows.Forms.Button();
            this.UsuSpec = new System.Windows.Forms.Button();
            this.Id_specjalizacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odswierz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpecjalizacjeTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // SpecjalizacjeTabela
            // 
            this.SpecjalizacjeTabela.AllowUserToAddRows = false;
            this.SpecjalizacjeTabela.AllowUserToDeleteRows = false;
            this.SpecjalizacjeTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_specjalizacji,
            this.NazwaSpec});
            this.SpecjalizacjeTabela.Location = new System.Drawing.Point(12, 12);
            this.SpecjalizacjeTabela.Name = "SpecjalizacjeTabela";
            this.SpecjalizacjeTabela.ReadOnly = true;
            this.SpecjalizacjeTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecjalizacjeTabela.Size = new System.Drawing.Size(362, 154);
            this.SpecjalizacjeTabela.TabIndex = 2;
            // 
            // DodSpec
            // 
            this.DodSpec.Location = new System.Drawing.Point(12, 190);
            this.DodSpec.Name = "DodSpec";
            this.DodSpec.Size = new System.Drawing.Size(118, 32);
            this.DodSpec.TabIndex = 3;
            this.DodSpec.Text = "Dodaj Specjalizację ";
            this.DodSpec.UseVisualStyleBackColor = true;
            this.DodSpec.Click += new System.EventHandler(this.DodSpec_Click);
            // 
            // EdtSpec
            // 
            this.EdtSpec.Location = new System.Drawing.Point(136, 190);
            this.EdtSpec.Name = "EdtSpec";
            this.EdtSpec.Size = new System.Drawing.Size(122, 32);
            this.EdtSpec.TabIndex = 4;
            this.EdtSpec.Text = "Edytuj Specjalizację";
            this.EdtSpec.UseVisualStyleBackColor = true;
            // 
            // UsuSpec
            // 
            this.UsuSpec.Location = new System.Drawing.Point(264, 190);
            this.UsuSpec.Name = "UsuSpec";
            this.UsuSpec.Size = new System.Drawing.Size(110, 32);
            this.UsuSpec.TabIndex = 5;
            this.UsuSpec.Text = "Usuń Specjalizację";
            this.UsuSpec.UseVisualStyleBackColor = true;
            this.UsuSpec.Click += new System.EventHandler(this.UsuSpec_Click);
            // 
            // Id_specjalizacji
            // 
            this.Id_specjalizacji.HeaderText = "ID Specjalizaji";
            this.Id_specjalizacji.Name = "Id_specjalizacji";
            this.Id_specjalizacji.ReadOnly = true;
            // 
            // NazwaSpec
            // 
            this.NazwaSpec.HeaderText = "Nazwa Specjalizacji";
            this.NazwaSpec.Name = "NazwaSpec";
            this.NazwaSpec.ReadOnly = true;
            this.NazwaSpec.Width = 220;
            // 
            // Odswierz
            // 
            this.Odswierz.Location = new System.Drawing.Point(12, 228);
            this.Odswierz.Name = "Odswierz";
            this.Odswierz.Size = new System.Drawing.Size(118, 40);
            this.Odswierz.TabIndex = 6;
            this.Odswierz.Text = "Odśwież";
            this.Odswierz.UseVisualStyleBackColor = true;
            this.Odswierz.Click += new System.EventHandler(this.Odswierz_Click);
            // 
            // OdzSpecGlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 376);
            this.Controls.Add(this.Odswierz);
            this.Controls.Add(this.UsuSpec);
            this.Controls.Add(this.EdtSpec);
            this.Controls.Add(this.DodSpec);
            this.Controls.Add(this.SpecjalizacjeTabela);
            this.Name = "OdzSpecGlowneOkno";
            this.Text = "OdzSpecGlowneOkno";
            ((System.ComponentModel.ISupportInitialize)(this.SpecjalizacjeTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SpecjalizacjeTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_specjalizacji;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaSpec;
        private System.Windows.Forms.Button DodSpec;
        private System.Windows.Forms.Button EdtSpec;
        private System.Windows.Forms.Button UsuSpec;
        private System.Windows.Forms.Button Odswierz;
    }
}