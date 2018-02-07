namespace Przychodnia.Grafik_formy
{
    partial class Wybor_specjalizacji_form
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
            this.Wybierz_button = new System.Windows.Forms.Button();
            this.Anuluj_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Wybierz_button
            // 
            this.Wybierz_button.Location = new System.Drawing.Point(12, 61);
            this.Wybierz_button.Name = "Wybierz_button";
            this.Wybierz_button.Size = new System.Drawing.Size(75, 23);
            this.Wybierz_button.TabIndex = 0;
            this.Wybierz_button.Text = "Wybierz";
            this.Wybierz_button.UseVisualStyleBackColor = true;
            this.Wybierz_button.Click += new System.EventHandler(this.Wybierz_button_Click);
            // 
            // Anuluj_button
            // 
            this.Anuluj_button.Location = new System.Drawing.Point(197, 61);
            this.Anuluj_button.Name = "Anuluj_button";
            this.Anuluj_button.Size = new System.Drawing.Size(75, 23);
            this.Anuluj_button.TabIndex = 1;
            this.Anuluj_button.Text = "Anuluj";
            this.Anuluj_button.UseVisualStyleBackColor = true;
            this.Anuluj_button.Click += new System.EventHandler(this.Anuluj_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Wybor_specjalizacji_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Anuluj_button);
            this.Controls.Add(this.Wybierz_button);
            this.Name = "Wybor_specjalizacji_form";
            this.Text = "Wybor_specjalizacji_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wybierz_button;
        private System.Windows.Forms.Button Anuluj_button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}