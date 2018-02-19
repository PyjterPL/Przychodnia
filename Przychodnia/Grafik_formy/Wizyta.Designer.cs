namespace Przychodnia.Grafik_formy
{
    partial class Wizyta
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
            this.Opis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DodOpis = new System.Windows.Forms.Button();
            this.WypRecpt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OpisWczesniejszy = new System.Windows.Forms.RichTextBox();
            this.edtOp = new System.Windows.Forms.Button();
            this.pokazRcpt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(16, 316);
            this.Opis.MaxLength = 5000;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(1139, 272);
            this.Opis.TabIndex = 0;
            this.Opis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(841, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // DodOpis
            // 
            this.DodOpis.Location = new System.Drawing.Point(1020, 594);
            this.DodOpis.Name = "DodOpis";
            this.DodOpis.Size = new System.Drawing.Size(131, 30);
            this.DodOpis.TabIndex = 2;
            this.DodOpis.Text = "Dodaj Opis";
            this.DodOpis.UseVisualStyleBackColor = true;
            this.DodOpis.Click += new System.EventHandler(this.button1_Click);
            // 
            // WypRecpt
            // 
            this.WypRecpt.Location = new System.Drawing.Point(1157, 65);
            this.WypRecpt.Name = "WypRecpt";
            this.WypRecpt.Size = new System.Drawing.Size(131, 52);
            this.WypRecpt.TabIndex = 3;
            this.WypRecpt.Text = "Wypisz Receptę";
            this.WypRecpt.UseVisualStyleBackColor = true;
            this.WypRecpt.Click += new System.EventHandler(this.WypRecpt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // OpisWczesniejszy
            // 
            this.OpisWczesniejszy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OpisWczesniejszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpisWczesniejszy.Location = new System.Drawing.Point(16, 65);
            this.OpisWczesniejszy.Name = "OpisWczesniejszy";
            this.OpisWczesniejszy.ReadOnly = true;
            this.OpisWczesniejszy.Size = new System.Drawing.Size(1135, 232);
            this.OpisWczesniejszy.TabIndex = 5;
            this.OpisWczesniejszy.Text = "";
            // 
            // edtOp
            // 
            this.edtOp.Location = new System.Drawing.Point(883, 594);
            this.edtOp.Name = "edtOp";
            this.edtOp.Size = new System.Drawing.Size(131, 30);
            this.edtOp.TabIndex = 6;
            this.edtOp.Text = "Edytuj Pełny Opis";
            this.edtOp.UseVisualStyleBackColor = true;
            this.edtOp.Click += new System.EventHandler(this.edtOp_Click);
            // 
            // pokazRcpt
            // 
            this.pokazRcpt.Location = new System.Drawing.Point(1157, 123);
            this.pokazRcpt.Name = "pokazRcpt";
            this.pokazRcpt.Size = new System.Drawing.Size(131, 52);
            this.pokazRcpt.TabIndex = 7;
            this.pokazRcpt.Text = "Pokaż Recepty";
            this.pokazRcpt.UseVisualStyleBackColor = true;
            this.pokazRcpt.Click += new System.EventHandler(this.pokazRcpt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Historia Pacjenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis Bierzącej Wizyty";
            // 
            // Wizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pokazRcpt);
            this.Controls.Add(this.edtOp);
            this.Controls.Add(this.OpisWczesniejszy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WypRecpt);
            this.Controls.Add(this.DodOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Opis);
            this.Name = "Wizyta";
            this.Text = "Wizyta";
            this.Load += new System.EventHandler(this.Wizyta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Opis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodOpis;
        private System.Windows.Forms.Button WypRecpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox OpisWczesniejszy;
        private System.Windows.Forms.Button edtOp;
        private System.Windows.Forms.Button pokazRcpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}