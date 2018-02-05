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
            this.buttonRecepty = new System.Windows.Forms.Button();
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
            this.buttonPacienci.Text = "Pacienci";
            this.buttonPacienci.UseVisualStyleBackColor = true;
            // 
            // buttonRecepty
            // 
            this.buttonRecepty.AutoSize = true;
            this.buttonRecepty.Location = new System.Drawing.Point(12, 70);
            this.buttonRecepty.Name = "buttonRecepty";
            this.buttonRecepty.Size = new System.Drawing.Size(284, 23);
            this.buttonRecepty.TabIndex = 2;
            this.buttonRecepty.Text = "Recepty";
            this.buttonRecepty.UseVisualStyleBackColor = true;
            this.buttonRecepty.Click += new System.EventHandler(this.buttonRecepty_Click);
            // 
            // Okno_glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 210);
            this.Controls.Add(this.buttonRecepty);
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
        private System.Windows.Forms.Button buttonRecepty;
    }
}

