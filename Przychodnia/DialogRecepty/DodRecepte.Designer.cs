namespace Przychodnia.DialogRecepty
{
    partial class DodRecepte
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
            this.DodajRecepteDialog = new System.Windows.Forms.Button();
            this.AnulujRecepteDialog = new System.Windows.Forms.Button();
            this.ComboLekarz = new System.Windows.Forms.ComboBox();
            this.Lekarzlabel = new System.Windows.Forms.Label();
            this.ComboPacjent = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PacjentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrescR = new System.Windows.Forms.RichTextBox();
            this.TrescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DodajRecepteDialog
            // 
            this.DodajRecepteDialog.Location = new System.Drawing.Point(350, 377);
            this.DodajRecepteDialog.Name = "DodajRecepteDialog";
            this.DodajRecepteDialog.Size = new System.Drawing.Size(143, 37);
            this.DodajRecepteDialog.TabIndex = 0;
            this.DodajRecepteDialog.Text = "Dodaj";
            this.DodajRecepteDialog.UseVisualStyleBackColor = true;
            this.DodajRecepteDialog.Click += new System.EventHandler(this.DodajRecepteDialog_Click);
            // 
            // AnulujRecepteDialog
            // 
            this.AnulujRecepteDialog.Location = new System.Drawing.Point(499, 377);
            this.AnulujRecepteDialog.Name = "AnulujRecepteDialog";
            this.AnulujRecepteDialog.Size = new System.Drawing.Size(140, 37);
            this.AnulujRecepteDialog.TabIndex = 1;
            this.AnulujRecepteDialog.Text = "Anuluj";
            this.AnulujRecepteDialog.UseVisualStyleBackColor = true;
            this.AnulujRecepteDialog.Click += new System.EventHandler(this.AnulujRecepteDialog_Click);
            // 
            // ComboLekarz
            // 
            this.ComboLekarz.FormattingEnabled = true;
            this.ComboLekarz.Location = new System.Drawing.Point(125, 16);
            this.ComboLekarz.Name = "ComboLekarz";
            this.ComboLekarz.Size = new System.Drawing.Size(298, 21);
            this.ComboLekarz.TabIndex = 2;
            // 
            // Lekarzlabel
            // 
            this.Lekarzlabel.AutoSize = true;
            this.Lekarzlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lekarzlabel.Location = new System.Drawing.Point(62, 20);
            this.Lekarzlabel.Name = "Lekarzlabel";
            this.Lekarzlabel.Size = new System.Drawing.Size(57, 17);
            this.Lekarzlabel.TabIndex = 3;
            this.Lekarzlabel.Text = "Lekarz";
            // 
            // ComboPacjent
            // 
            this.ComboPacjent.FormattingEnabled = true;
            this.ComboPacjent.Location = new System.Drawing.Point(125, 40);
            this.ComboPacjent.Name = "ComboPacjent";
            this.ComboPacjent.Size = new System.Drawing.Size(298, 21);
            this.ComboPacjent.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PacjentLabel
            // 
            this.PacjentLabel.AutoSize = true;
            this.PacjentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PacjentLabel.Location = new System.Drawing.Point(57, 41);
            this.PacjentLabel.Name = "PacjentLabel";
            this.PacjentLabel.Size = new System.Drawing.Size(62, 17);
            this.PacjentLabel.TabIndex = 4;
            this.PacjentLabel.Text = "Pacjent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Ważności";
            // 
            // TrescR
            // 
            this.TrescR.Location = new System.Drawing.Point(67, 122);
            this.TrescR.Name = "TrescR";
            this.TrescR.Size = new System.Drawing.Size(572, 249);
            this.TrescR.TabIndex = 8;
            this.TrescR.Text = "";
            // 
            // TrescLabel
            // 
            this.TrescLabel.AutoSize = true;
            this.TrescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrescLabel.Location = new System.Drawing.Point(12, 138);
            this.TrescLabel.Name = "TrescLabel";
            this.TrescLabel.Size = new System.Drawing.Size(49, 17);
            this.TrescLabel.TabIndex = 9;
            this.TrescLabel.Text = "Treść";
            this.TrescLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DodRecepte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 426);
            this.Controls.Add(this.TrescLabel);
            this.Controls.Add(this.TrescR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ComboPacjent);
            this.Controls.Add(this.PacjentLabel);
            this.Controls.Add(this.Lekarzlabel);
            this.Controls.Add(this.ComboLekarz);
            this.Controls.Add(this.AnulujRecepteDialog);
            this.Controls.Add(this.DodajRecepteDialog);
            this.Name = "DodRecepte";
            this.Text = "DodRecepte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajRecepteDialog;
        private System.Windows.Forms.Button AnulujRecepteDialog;
        private System.Windows.Forms.ComboBox ComboLekarz;
        private System.Windows.Forms.Label Lekarzlabel;
        private System.Windows.Forms.ComboBox ComboPacjent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label PacjentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TrescR;
        private System.Windows.Forms.Label TrescLabel;
    }
}