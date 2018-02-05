namespace Przychodnia
{
    partial class ReceptyGlowneOkno
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
            this.ReceptyTabela = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_urodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZamknijOknoRecept = new System.Windows.Forms.Button();
            this.DodRecpt = new System.Windows.Forms.Button();
            this.UsuRecpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptyTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceptyTabela
            // 
            this.ReceptyTabela.AllowUserToAddRows = false;
            this.ReceptyTabela.AllowUserToDeleteRows = false;
            this.ReceptyTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptyTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Imie,
            this.Nazwisko,
            this.Miasto,
            this.Adres,
            this.Data_urodzenia});
            this.ReceptyTabela.Location = new System.Drawing.Point(12, 36);
            this.ReceptyTabela.Name = "ReceptyTabela";
            this.ReceptyTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceptyTabela.Size = new System.Drawing.Size(844, 240);
            this.ReceptyTabela.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Recepty";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.HeaderText = "ID Lekarza";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "ID_Pacjenta";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Miasto
            // 
            this.Miasto.HeaderText = "ID Grafiku";
            this.Miasto.Name = "Miasto";
            this.Miasto.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Data Ważności";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // Data_urodzenia
            // 
            this.Data_urodzenia.HeaderText = "Treść";
            this.Data_urodzenia.Name = "Data_urodzenia";
            this.Data_urodzenia.ReadOnly = true;
            this.Data_urodzenia.Width = 300;
            // 
            // ZamknijOknoRecept
            // 
            this.ZamknijOknoRecept.Location = new System.Drawing.Point(781, 305);
            this.ZamknijOknoRecept.Name = "ZamknijOknoRecept";
            this.ZamknijOknoRecept.Size = new System.Drawing.Size(75, 23);
            this.ZamknijOknoRecept.TabIndex = 2;
            this.ZamknijOknoRecept.Text = "Zamknij";
            this.ZamknijOknoRecept.UseVisualStyleBackColor = true;
            this.ZamknijOknoRecept.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodRecpt
            // 
            this.DodRecpt.Location = new System.Drawing.Point(21, 304);
            this.DodRecpt.Name = "DodRecpt";
            this.DodRecpt.Size = new System.Drawing.Size(88, 23);
            this.DodRecpt.TabIndex = 3;
            this.DodRecpt.Text = "Dodaj Receptę";
            this.DodRecpt.UseVisualStyleBackColor = true;
            this.DodRecpt.Click += new System.EventHandler(this.DodRecpt_Click);
            // 
            // UsuRecpt
            // 
            this.UsuRecpt.Location = new System.Drawing.Point(115, 305);
            this.UsuRecpt.Name = "UsuRecpt";
            this.UsuRecpt.Size = new System.Drawing.Size(86, 23);
            this.UsuRecpt.TabIndex = 4;
            this.UsuRecpt.Text = "Usuń Receptę";
            this.UsuRecpt.UseVisualStyleBackColor = true;
            this.UsuRecpt.Click += new System.EventHandler(this.UsuRecpt_Click);
            // 
            // ReceptyGlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 340);
            this.Controls.Add(this.UsuRecpt);
            this.Controls.Add(this.DodRecpt);
            this.Controls.Add(this.ZamknijOknoRecept);
            this.Controls.Add(this.ReceptyTabela);
            this.Name = "ReceptyGlowneOkno";
            this.Text = "ReceptyGlowneOkno";
            ((System.ComponentModel.ISupportInitialize)(this.ReceptyTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceptyTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_urodzenia;
        private System.Windows.Forms.Button ZamknijOknoRecept;
        private System.Windows.Forms.Button DodRecpt;
        private System.Windows.Forms.Button UsuRecpt;
    }
}