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
            this.Id_specjalizacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodSpec = new System.Windows.Forms.Button();
            this.EdtSpec = new System.Windows.Forms.Button();
            this.UsuSpec = new System.Windows.Forms.Button();
            this.Odswierz = new System.Windows.Forms.Button();
            this.LekSpecTabela = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imię = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrzypSpec = new System.Windows.Forms.Button();
            this.Wymaz = new System.Windows.Forms.Button();
            this.WymAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpecjalizacjeTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LekSpecTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // SpecjalizacjeTabela
            // 
            this.SpecjalizacjeTabela.AllowUserToAddRows = false;
            this.SpecjalizacjeTabela.AllowUserToDeleteRows = false;
            this.SpecjalizacjeTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_specjalizacji,
            this.NazwaSpec});
            this.SpecjalizacjeTabela.Location = new System.Drawing.Point(12, 298);
            this.SpecjalizacjeTabela.Name = "SpecjalizacjeTabela";
            this.SpecjalizacjeTabela.ReadOnly = true;
            this.SpecjalizacjeTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecjalizacjeTabela.Size = new System.Drawing.Size(365, 250);
            this.SpecjalizacjeTabela.TabIndex = 2;
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
            // DodSpec
            // 
            this.DodSpec.Location = new System.Drawing.Point(383, 353);
            this.DodSpec.Name = "DodSpec";
            this.DodSpec.Size = new System.Drawing.Size(122, 33);
            this.DodSpec.TabIndex = 3;
            this.DodSpec.Text = "Dodaj Specjalizację ";
            this.DodSpec.UseVisualStyleBackColor = true;
            this.DodSpec.Click += new System.EventHandler(this.DodSpec_Click);
            // 
            // EdtSpec
            // 
            this.EdtSpec.Location = new System.Drawing.Point(383, 392);
            this.EdtSpec.Name = "EdtSpec";
            this.EdtSpec.Size = new System.Drawing.Size(122, 33);
            this.EdtSpec.TabIndex = 4;
            this.EdtSpec.Text = "Edytuj Specjalizację";
            this.EdtSpec.UseVisualStyleBackColor = true;
            this.EdtSpec.Click += new System.EventHandler(this.EdtSpec_Click);
            // 
            // UsuSpec
            // 
            this.UsuSpec.Location = new System.Drawing.Point(383, 431);
            this.UsuSpec.Name = "UsuSpec";
            this.UsuSpec.Size = new System.Drawing.Size(122, 33);
            this.UsuSpec.TabIndex = 5;
            this.UsuSpec.Text = "Usuń Specjalizację";
            this.UsuSpec.UseVisualStyleBackColor = true;
            this.UsuSpec.Click += new System.EventHandler(this.UsuSpec_Click);
            // 
            // Odswierz
            // 
            this.Odswierz.Location = new System.Drawing.Point(746, 501);
            this.Odswierz.Name = "Odswierz";
            this.Odswierz.Size = new System.Drawing.Size(122, 47);
            this.Odswierz.TabIndex = 6;
            this.Odswierz.Text = "Odśwież";
            this.Odswierz.UseVisualStyleBackColor = true;
            this.Odswierz.Click += new System.EventHandler(this.Odswierz_Click);
            // 
            // LekSpecTabela
            // 
            this.LekSpecTabela.AllowUserToAddRows = false;
            this.LekSpecTabela.AllowUserToDeleteRows = false;
            this.LekSpecTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.imieL,
            this.Imię,
            this.dataGridViewTextBoxColumn3,
            this.adres});
            this.LekSpecTabela.Location = new System.Drawing.Point(11, 12);
            this.LekSpecTabela.Name = "LekSpecTabela";
            this.LekSpecTabela.ReadOnly = true;
            this.LekSpecTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LekSpecTabela.Size = new System.Drawing.Size(740, 275);
            this.LekSpecTabela.TabIndex = 8;
            this.LekSpecTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LekSpecTabela_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID Lekarza";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // imieL
            // 
            this.imieL.HeaderText = "Imię ";
            this.imieL.Name = "imieL";
            this.imieL.ReadOnly = true;
            // 
            // Imię
            // 
            this.Imię.HeaderText = "Nazwisko";
            this.Imię.Name = "Imię";
            this.Imię.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwa Specjalizacji ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // adres
            // 
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            this.adres.Width = 200;
            // 
            // PrzypSpec
            // 
            this.PrzypSpec.Location = new System.Drawing.Point(757, 43);
            this.PrzypSpec.Name = "PrzypSpec";
            this.PrzypSpec.Size = new System.Drawing.Size(122, 38);
            this.PrzypSpec.TabIndex = 9;
            this.PrzypSpec.Text = "Przypisz Specjalizacje";
            this.PrzypSpec.UseVisualStyleBackColor = true;
            this.PrzypSpec.Click += new System.EventHandler(this.PrzypSpec_Click);
            // 
            // Wymaz
            // 
            this.Wymaz.Location = new System.Drawing.Point(757, 96);
            this.Wymaz.Name = "Wymaz";
            this.Wymaz.Size = new System.Drawing.Size(122, 41);
            this.Wymaz.TabIndex = 10;
            this.Wymaz.Text = "Wymaż Specjalizacje";
            this.Wymaz.UseVisualStyleBackColor = true;
            this.Wymaz.Click += new System.EventHandler(this.Odwolaj_Click);
            // 
            // WymAll
            // 
            this.WymAll.Location = new System.Drawing.Point(757, 143);
            this.WymAll.Name = "WymAll";
            this.WymAll.Size = new System.Drawing.Size(122, 41);
            this.WymAll.TabIndex = 11;
            this.WymAll.Text = "Wymaż Wszystkie Specjalizacje";
            this.WymAll.UseVisualStyleBackColor = true;
            this.WymAll.Click += new System.EventHandler(this.WymAll_Click);
            // 
            // OdzSpecGlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.WymAll);
            this.Controls.Add(this.Wymaz);
            this.Controls.Add(this.PrzypSpec);
            this.Controls.Add(this.LekSpecTabela);
            this.Controls.Add(this.Odswierz);
            this.Controls.Add(this.UsuSpec);
            this.Controls.Add(this.EdtSpec);
            this.Controls.Add(this.DodSpec);
            this.Controls.Add(this.SpecjalizacjeTabela);
            this.Name = "OdzSpecGlowneOkno";
            this.Text = "OdzSpecGlowneOkno";
            ((System.ComponentModel.ISupportInitialize)(this.SpecjalizacjeTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LekSpecTabela)).EndInit();
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
        private System.Windows.Forms.DataGridView LekSpecTabela;
        private System.Windows.Forms.Button PrzypSpec;
        private System.Windows.Forms.Button Wymaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imię;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.Button WymAll;
    }
}