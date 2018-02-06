﻿namespace Przychodnia.Recepty_formy
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
            this.Id_recepty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_lekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_waznosci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_grafiku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tresc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodRecpt = new System.Windows.Forms.Button();
            this.UsuRecpt = new System.Windows.Forms.Button();
            this.odsiwerz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptyTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceptyTabela
            // 
            this.ReceptyTabela.AllowUserToAddRows = false;
            this.ReceptyTabela.AllowUserToDeleteRows = false;
            this.ReceptyTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_recepty,
            this.Id_lekarza,
            this.Id_pacjenta,
            this.Data_waznosci,
            this.Id_grafiku,
            this.Tresc});
            this.ReceptyTabela.Location = new System.Drawing.Point(12, 12);
            this.ReceptyTabela.Name = "ReceptyTabela";
            this.ReceptyTabela.ReadOnly = true;
            this.ReceptyTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceptyTabela.Size = new System.Drawing.Size(823, 266);
            this.ReceptyTabela.TabIndex = 1;
            // 
            // Id_recepty
            // 
            this.Id_recepty.HeaderText = "ID Recepty";
            this.Id_recepty.Name = "Id_recepty";
            this.Id_recepty.ReadOnly = true;
            // 
            // Id_lekarza
            // 
            this.Id_lekarza.HeaderText = "ID Lekarza";
            this.Id_lekarza.Name = "Id_lekarza";
            this.Id_lekarza.ReadOnly = true;
            // 
            // Id_pacjenta
            // 
            this.Id_pacjenta.HeaderText = "ID Pacjenta";
            this.Id_pacjenta.Name = "Id_pacjenta";
            this.Id_pacjenta.ReadOnly = true;
            // 
            // Data_waznosci
            // 
            this.Data_waznosci.HeaderText = "Data Ważności";
            this.Data_waznosci.Name = "Data_waznosci";
            this.Data_waznosci.ReadOnly = true;
            // 
            // Id_grafiku
            // 
            this.Id_grafiku.HeaderText = "ID Grafiku";
            this.Id_grafiku.Name = "Id_grafiku";
            this.Id_grafiku.ReadOnly = true;
            // 
            // Tresc
            // 
            this.Tresc.HeaderText = "Treść Recepty";
            this.Tresc.Name = "Tresc";
            this.Tresc.ReadOnly = true;
            this.Tresc.Width = 300;
            // 
            // DodRecpt
            // 
            this.DodRecpt.Location = new System.Drawing.Point(12, 296);
            this.DodRecpt.Name = "DodRecpt";
            this.DodRecpt.Size = new System.Drawing.Size(89, 23);
            this.DodRecpt.TabIndex = 2;
            this.DodRecpt.Text = "Dodaj Receptę";
            this.DodRecpt.UseVisualStyleBackColor = true;
            this.DodRecpt.Click += new System.EventHandler(this.DodRecpt_Click);
            // 
            // UsuRecpt
            // 
            this.UsuRecpt.Location = new System.Drawing.Point(107, 296);
            this.UsuRecpt.Name = "UsuRecpt";
            this.UsuRecpt.Size = new System.Drawing.Size(88, 23);
            this.UsuRecpt.TabIndex = 3;
            this.UsuRecpt.Text = "Usuń Receptę";
            this.UsuRecpt.UseVisualStyleBackColor = true;
            this.UsuRecpt.Click += new System.EventHandler(this.UsuRecpt_Click);
            // 
            // odsiwerz
            // 
            this.odsiwerz.Location = new System.Drawing.Point(201, 296);
            this.odsiwerz.Name = "odsiwerz";
            this.odsiwerz.Size = new System.Drawing.Size(90, 23);
            this.odsiwerz.TabIndex = 5;
            this.odsiwerz.Text = "Odśwież";
            this.odsiwerz.UseVisualStyleBackColor = true;
            this.odsiwerz.Click += new System.EventHandler(this.odsiwerz_Click);
            // 
            // ReceptyGlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 336);
            this.Controls.Add(this.odsiwerz);
            this.Controls.Add(this.UsuRecpt);
            this.Controls.Add(this.DodRecpt);
            this.Controls.Add(this.ReceptyTabela);
            this.Name = "ReceptyGlowneOkno";
            this.Text = "ReceptyGlowneOkno";
            ((System.ComponentModel.ISupportInitialize)(this.ReceptyTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceptyTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_recepty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_lekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_waznosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_grafiku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tresc;
        private System.Windows.Forms.Button DodRecpt;
        private System.Windows.Forms.Button UsuRecpt;
        private System.Windows.Forms.Button odsiwerz;
    }
}