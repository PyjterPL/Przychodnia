namespace Przychodnia.Pacjenci_formy
{
    partial class Pacjenci_glowne_okno
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
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_urodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodajButton = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.Button();
            this.Odswierz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabela
            // 
            this.Tabela.AllowUserToAddRows = false;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pesel,
            this.Imie,
            this.Nazwisko,
            this.Data_urodzenia,
            this.Adres,
            this.Miasto,
            this.Telefon,
            this.Plec,
            this.Lekarz});
            this.Tabela.Location = new System.Drawing.Point(13, 13);
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(1044, 159);
            this.Tabela.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pesel
            // 
            this.Pesel.HeaderText = "Pesel";
            this.Pesel.Name = "Pesel";
            this.Pesel.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Data_urodzenia
            // 
            this.Data_urodzenia.HeaderText = "Data urodzenia";
            this.Data_urodzenia.Name = "Data_urodzenia";
            this.Data_urodzenia.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // Miasto
            // 
            this.Miasto.HeaderText = "Miasto";
            this.Miasto.Name = "Miasto";
            this.Miasto.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Plec
            // 
            this.Plec.HeaderText = "Płeć";
            this.Plec.Name = "Plec";
            this.Plec.ReadOnly = true;
            // 
            // Lekarz
            // 
            this.Lekarz.HeaderText = "Lekarz prowadzący";
            this.Lekarz.Name = "Lekarz";
            this.Lekarz.ReadOnly = true;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(13, 179);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // Usun
            // 
            this.Usun.Enabled = false;
            this.Usun.Location = new System.Drawing.Point(95, 179);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(75, 23);
            this.Usun.TabIndex = 2;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.Location = new System.Drawing.Point(177, 179);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(75, 23);
            this.Edytuj.TabIndex = 3;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Odswierz
            // 
            this.Odswierz.Location = new System.Drawing.Point(259, 179);
            this.Odswierz.Name = "Odswierz";
            this.Odswierz.Size = new System.Drawing.Size(75, 23);
            this.Odswierz.TabIndex = 4;
            this.Odswierz.Text = "Odswierz";
            this.Odswierz.UseVisualStyleBackColor = true;
            this.Odswierz.Click += new System.EventHandler(this.Odswierz_Click);
            // 
            // Pacjenci_glowne_okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 312);
            this.Controls.Add(this.Odswierz);
            this.Controls.Add(this.Edytuj);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.Tabela);
            this.Name = "Pacjenci_glowne_okno";
            this.Text = "Pacjenci_glowne_okno";
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_urodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lekarz;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.Button Odswierz;
    }
}