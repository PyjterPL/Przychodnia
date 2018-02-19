namespace Przychodnia.OddzialySpecjalizacje_formy
{
    partial class DodSpec_Form
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
            this.DodSpecB = new System.Windows.Forms.Button();
            this.AnSpecB = new System.Windows.Forms.Button();
            this.SpecT = new System.Windows.Forms.TextBox();
            this.TekstL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DodSpecB
            // 
            this.DodSpecB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DodSpecB.Location = new System.Drawing.Point(83, 105);
            this.DodSpecB.Name = "DodSpecB";
            this.DodSpecB.Size = new System.Drawing.Size(98, 36);
            this.DodSpecB.TabIndex = 0;
            this.DodSpecB.Text = "Dodaj ";
            this.DodSpecB.UseVisualStyleBackColor = true;
            this.DodSpecB.Click += new System.EventHandler(this.DodSpecB_Click);
            // 
            // AnSpecB
            // 
            this.AnSpecB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnSpecB.Location = new System.Drawing.Point(224, 105);
            this.AnSpecB.Name = "AnSpecB";
            this.AnSpecB.Size = new System.Drawing.Size(98, 36);
            this.AnSpecB.TabIndex = 1;
            this.AnSpecB.Text = "Anuluj";
            this.AnSpecB.UseVisualStyleBackColor = true;
            this.AnSpecB.Click += new System.EventHandler(this.AnSpecB_Click);
            // 
            // SpecT
            // 
            this.SpecT.Location = new System.Drawing.Point(83, 57);
            this.SpecT.MaxLength = 50;
            this.SpecT.Name = "SpecT";
            this.SpecT.Size = new System.Drawing.Size(239, 20);
            this.SpecT.TabIndex = 2;
            // 
            // TekstL
            // 
            this.TekstL.AutoSize = true;
            this.TekstL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TekstL.Location = new System.Drawing.Point(54, 25);
            this.TekstL.Name = "TekstL";
            this.TekstL.Size = new System.Drawing.Size(318, 18);
            this.TekstL.TabIndex = 3;
            this.TekstL.Text = "Wpisz poniżej nazwę nowej specjalizacji ";
            // 
            // DodSpec_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 167);
            this.Controls.Add(this.TekstL);
            this.Controls.Add(this.SpecT);
            this.Controls.Add(this.AnSpecB);
            this.Controls.Add(this.DodSpecB);
            this.Name = "DodSpec_Form";
            this.Text = "DodSpec_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodSpecB;
        private System.Windows.Forms.Button AnSpecB;
        private System.Windows.Forms.TextBox SpecT;
        private System.Windows.Forms.Label TekstL;
    }
}