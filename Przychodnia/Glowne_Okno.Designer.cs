namespace Przychodnia
{
    partial class Okno_glowne
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
            this.buttonLekarze = new System.Windows.Forms.Button();
            this.buttonPacienci = new System.Windows.Forms.Button();
            this.Wizyty_button = new System.Windows.Forms.Button();
            this.Recepty_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMiasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLekarze
            // 
            this.buttonLekarze.AutoSize = true;
            this.buttonLekarze.Location = new System.Drawing.Point(12, 12);
            this.buttonLekarze.Name = "buttonLekarze";
            this.buttonLekarze.Size = new System.Drawing.Size(284, 23);
            this.buttonLekarze.TabIndex = 0;
            this.buttonLekarze.Text = "Lekarze";
            this.buttonLekarze.UseVisualStyleBackColor = true;
            this.buttonLekarze.Click += new System.EventHandler(this.buttonLekarze_Click);
            // 
            // buttonPacienci
            // 
            this.buttonPacienci.AutoSize = true;
            this.buttonPacienci.Location = new System.Drawing.Point(12, 41);
            this.buttonPacienci.Name = "buttonPacienci";
            this.buttonPacienci.Size = new System.Drawing.Size(284, 23);
            this.buttonPacienci.TabIndex = 1;
            this.buttonPacienci.Text = "Pacjenci";
            this.buttonPacienci.UseVisualStyleBackColor = true;
            this.buttonPacienci.Click += new System.EventHandler(this.buttonPacienci_Click);
            // 
            // Wizyty_button
            // 
            this.Wizyty_button.Location = new System.Drawing.Point(13, 71);
            this.Wizyty_button.Name = "Wizyty_button";
            this.Wizyty_button.Size = new System.Drawing.Size(283, 23);
            this.Wizyty_button.TabIndex = 2;
            this.Wizyty_button.Text = "Wizyty";
            this.Wizyty_button.UseVisualStyleBackColor = true;
            this.Wizyty_button.Click += new System.EventHandler(this.Wizyty_button_Click);
            // 
            // Recepty_Button
            // 
            this.Recepty_Button.Location = new System.Drawing.Point(13, 100);
            this.Recepty_Button.Name = "Recepty_Button";
            this.Recepty_Button.Size = new System.Drawing.Size(283, 23);
            this.Recepty_Button.TabIndex = 3;
            this.Recepty_Button.Text = "Recepty";
            this.Recepty_Button.UseVisualStyleBackColor = true;
            this.Recepty_Button.Click += new System.EventHandler(this.Recepty_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oddziały oraz Specjalizacje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMiasta
            // 
            this.buttonMiasta.Location = new System.Drawing.Point(12, 159);
            this.buttonMiasta.Name = "buttonMiasta";
            this.buttonMiasta.Size = new System.Drawing.Size(284, 23);
            this.buttonMiasta.TabIndex = 5;
            this.buttonMiasta.Text = "Miasta";
            this.buttonMiasta.UseVisualStyleBackColor = true;
            this.buttonMiasta.Click += new System.EventHandler(this.buttonMiasta_Click);
            // 
            // Okno_glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 210);
            this.Controls.Add(this.buttonMiasta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Recepty_Button);
            this.Controls.Add(this.Wizyty_button);
            this.Controls.Add(this.buttonPacienci);
            this.Controls.Add(this.buttonLekarze);
            this.Name = "Okno_glowne";
            this.Text = "Przychodnia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLekarze;
        private System.Windows.Forms.Button buttonPacienci;
        private System.Windows.Forms.Button Wizyty_button;
        private System.Windows.Forms.Button Recepty_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMiasta;
    }
}

