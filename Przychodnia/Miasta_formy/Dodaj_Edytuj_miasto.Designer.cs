namespace Przychodnia.Miasta_formy
{
    partial class Dodaj_Edytuj_miasto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DodajEdytujButton = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // DodajEdytujButton
            // 
            this.DodajEdytujButton.Location = new System.Drawing.Point(13, 40);
            this.DodajEdytujButton.Name = "DodajEdytujButton";
            this.DodajEdytujButton.Size = new System.Drawing.Size(75, 23);
            this.DodajEdytujButton.TabIndex = 1;
            this.DodajEdytujButton.Text = "Dodaj";
            this.DodajEdytujButton.UseVisualStyleBackColor = true;
            this.DodajEdytujButton.Click += new System.EventHandler(this.DodajEdytujButton_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(197, 39);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 2;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // Dodaj_Edytuj_miasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.DodajEdytujButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Dodaj_Edytuj_miasto";
            this.Text = "Dodaj_Edytuj_miasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DodajEdytujButton;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}