namespace Przychodnia.Grafik_formy
{
    partial class Grafik_glowna_forma
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
            this.lekarz_comboBox = new System.Windows.Forms.ComboBox();
            this.lekarz_label = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Pokaz_button = new System.Windows.Forms.Button();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacjent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oddział = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umow_button = new System.Windows.Forms.Button();
            this.Odwolaj_button = new System.Windows.Forms.Button();
            this.Dodaj_godzin_button = new System.Windows.Forms.Button();
            this.Odwolaj_godziny_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // lekarz_comboBox
            // 
            this.lekarz_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarz_comboBox.FormattingEnabled = true;
            this.lekarz_comboBox.Location = new System.Drawing.Point(57, 12);
            this.lekarz_comboBox.Name = "lekarz_comboBox";
            this.lekarz_comboBox.Size = new System.Drawing.Size(121, 21);
            this.lekarz_comboBox.TabIndex = 0;
            // 
            // lekarz_label
            // 
            this.lekarz_label.AutoSize = true;
            this.lekarz_label.Location = new System.Drawing.Point(12, 15);
            this.lekarz_label.Name = "lekarz_label";
            this.lekarz_label.Size = new System.Drawing.Size(39, 13);
            this.lekarz_label.TabIndex = 1;
            this.lekarz_label.Text = "Lekarz";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(203, 15);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(30, 13);
            this.data_label.TabIndex = 2;
            this.data_label.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Pokaz_button
            // 
            this.Pokaz_button.Location = new System.Drawing.Point(455, 10);
            this.Pokaz_button.Name = "Pokaz_button";
            this.Pokaz_button.Size = new System.Drawing.Size(75, 23);
            this.Pokaz_button.TabIndex = 4;
            this.Pokaz_button.Text = "Pokaż";
            this.Pokaz_button.UseVisualStyleBackColor = true;
            this.Pokaz_button.Click += new System.EventHandler(this.Pokaz_button_Click);
            // 
            // Tabela
            // 
            this.Tabela.AllowUserToAddRows = false;
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Godzina,
            this.Pacjent,
            this.Opis,
            this.Oddział});
            this.Tabela.Location = new System.Drawing.Point(12, 38);
            this.Tabela.Name = "Tabela";
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(551, 386);
            this.Tabela.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Godzina
            // 
            this.Godzina.HeaderText = "Godzina";
            this.Godzina.Name = "Godzina";
            this.Godzina.ReadOnly = true;
            // 
            // Pacjent
            // 
            this.Pacjent.HeaderText = "Pacjent";
            this.Pacjent.Name = "Pacjent";
            this.Pacjent.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Oddział
            // 
            this.Oddział.HeaderText = "Oddział";
            this.Oddział.Name = "Oddział";
            this.Oddział.ReadOnly = true;
            // 
            // Umow_button
            // 
            this.Umow_button.Location = new System.Drawing.Point(12, 432);
            this.Umow_button.Name = "Umow_button";
            this.Umow_button.Size = new System.Drawing.Size(97, 23);
            this.Umow_button.TabIndex = 6;
            this.Umow_button.Text = "Umów wizytę";
            this.Umow_button.UseVisualStyleBackColor = true;
            // 
            // Odwolaj_button
            // 
            this.Odwolaj_button.Location = new System.Drawing.Point(115, 431);
            this.Odwolaj_button.Name = "Odwolaj_button";
            this.Odwolaj_button.Size = new System.Drawing.Size(95, 23);
            this.Odwolaj_button.TabIndex = 7;
            this.Odwolaj_button.Text = "Odwołaj wizytę";
            this.Odwolaj_button.UseVisualStyleBackColor = true;
            // 
            // Dodaj_godzin_button
            // 
            this.Dodaj_godzin_button.Location = new System.Drawing.Point(12, 461);
            this.Dodaj_godzin_button.Name = "Dodaj_godzin_button";
            this.Dodaj_godzin_button.Size = new System.Drawing.Size(119, 23);
            this.Dodaj_godzin_button.TabIndex = 8;
            this.Dodaj_godzin_button.Text = "Dodaj godziny pracy";
            this.Dodaj_godzin_button.UseVisualStyleBackColor = true;
            this.Dodaj_godzin_button.Click += new System.EventHandler(this.Dodaj_godzin_button_Click);
            // 
            // Odwolaj_godziny_button
            // 
            this.Odwolaj_godziny_button.Location = new System.Drawing.Point(138, 461);
            this.Odwolaj_godziny_button.Name = "Odwolaj_godziny_button";
            this.Odwolaj_godziny_button.Size = new System.Drawing.Size(133, 23);
            this.Odwolaj_godziny_button.TabIndex = 9;
            this.Odwolaj_godziny_button.Text = "Odwołaj godziny pracy";
            this.Odwolaj_godziny_button.UseVisualStyleBackColor = true;
            // 
            // Grafik_glowna_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 494);
            this.Controls.Add(this.Odwolaj_godziny_button);
            this.Controls.Add(this.Dodaj_godzin_button);
            this.Controls.Add(this.Odwolaj_button);
            this.Controls.Add(this.Umow_button);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.Pokaz_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.lekarz_label);
            this.Controls.Add(this.lekarz_comboBox);
            this.Name = "Grafik_glowna_forma";
            this.Text = "Grafik_glowna_forma";
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lekarz_comboBox;
        private System.Windows.Forms.Label lekarz_label;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Pokaz_button;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacjent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oddział;
        private System.Windows.Forms.Button Umow_button;
        private System.Windows.Forms.Button Odwolaj_button;
        private System.Windows.Forms.Button Dodaj_godzin_button;
        private System.Windows.Forms.Button Odwolaj_godziny_button;
    }
}