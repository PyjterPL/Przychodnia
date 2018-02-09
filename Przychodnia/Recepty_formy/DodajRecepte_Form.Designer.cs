namespace Przychodnia.Recepty_formy
{
    partial class DodajRecepte_Form
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
            this.AnulujRecpteDialog = new System.Windows.Forms.Button();
            this.DodajRecepteDialog = new System.Windows.Forms.Button();
            this.ComboPacjent = new System.Windows.Forms.ComboBox();
            this.ComboLekarz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tresc = new System.Windows.Forms.RichTextBox();
            this.DataWaznosci = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnulujRecpteDialog
            // 
            this.AnulujRecpteDialog.Location = new System.Drawing.Point(155, 415);
            this.AnulujRecpteDialog.Name = "AnulujRecpteDialog";
            this.AnulujRecpteDialog.Size = new System.Drawing.Size(110, 33);
            this.AnulujRecpteDialog.TabIndex = 15;
            this.AnulujRecpteDialog.Text = "Anuluj";
            this.AnulujRecpteDialog.UseVisualStyleBackColor = true;
            // 
            // DodajRecepteDialog
            // 
            this.DodajRecepteDialog.Location = new System.Drawing.Point(29, 415);
            this.DodajRecepteDialog.Name = "DodajRecepteDialog";
            this.DodajRecepteDialog.Size = new System.Drawing.Size(110, 33);
            this.DodajRecepteDialog.TabIndex = 14;
            this.DodajRecepteDialog.Text = "Dodaj";
            this.DodajRecepteDialog.UseVisualStyleBackColor = true;
            this.DodajRecepteDialog.Click += new System.EventHandler(this.DodajRecepteDialog_Click);
            // 
            // ComboPacjent
            // 
            this.ComboPacjent.FormattingEnabled = true;
            this.ComboPacjent.Location = new System.Drawing.Point(112, 50);
            this.ComboPacjent.Name = "ComboPacjent";
            this.ComboPacjent.Size = new System.Drawing.Size(379, 21);
            this.ComboPacjent.TabIndex = 13;
            // 
            // ComboLekarz
            // 
            this.ComboLekarz.FormattingEnabled = true;
            this.ComboLekarz.Location = new System.Drawing.Point(112, 12);
            this.ComboLekarz.Name = "ComboLekarz";
            this.ComboLekarz.Size = new System.Drawing.Size(379, 21);
            this.ComboLekarz.TabIndex = 12;
            this.ComboLekarz.SelectedIndexChanged += new System.EventHandler(this.ComboLekarz_SelectedIndexChanged);
            this.ComboLekarz.TextChanged += new System.EventHandler(this.ComboLekarz_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Treść Recepty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pacjent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lekarz";
            // 
            // Tresc
            // 
            this.Tresc.Location = new System.Drawing.Point(29, 123);
            this.Tresc.Name = "Tresc";
            this.Tresc.Size = new System.Drawing.Size(836, 269);
            this.Tresc.TabIndex = 8;
            this.Tresc.Text = "";
            // 
            // DataWaznosci
            // 
            this.DataWaznosci.Location = new System.Drawing.Point(686, 13);
            this.DataWaznosci.Name = "DataWaznosci";
            this.DataWaznosci.Size = new System.Drawing.Size(200, 20);
            this.DataWaznosci.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(497, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data Ważnosci Recepty";
            // 
            // DodajRecepte_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataWaznosci);
            this.Controls.Add(this.AnulujRecpteDialog);
            this.Controls.Add(this.DodajRecepteDialog);
            this.Controls.Add(this.ComboPacjent);
            this.Controls.Add(this.ComboLekarz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tresc);
            this.Name = "DodajRecepte_Form";
            this.Text = "DodajRecepte_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnulujRecpteDialog;
        private System.Windows.Forms.Button DodajRecepteDialog;
        private System.Windows.Forms.ComboBox ComboPacjent;
        private System.Windows.Forms.ComboBox ComboLekarz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Tresc;
        private System.Windows.Forms.DateTimePicker DataWaznosci;
        private System.Windows.Forms.Label label4;
    }
}