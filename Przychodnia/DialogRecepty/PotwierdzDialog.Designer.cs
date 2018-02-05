namespace Przychodnia.DialogRecepty
{
    partial class PotwierdzDialog
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
            this.potwierdzenie = new System.Windows.Forms.Button();
            this.anulowanie = new System.Windows.Forms.Button();
            this.GenNum = new System.Windows.Forms.Label();
            this.GenNumText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // potwierdzenie
            // 
            this.potwierdzenie.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.potwierdzenie.Location = new System.Drawing.Point(41, 171);
            this.potwierdzenie.Name = "potwierdzenie";
            this.potwierdzenie.Size = new System.Drawing.Size(75, 23);
            this.potwierdzenie.TabIndex = 0;
            this.potwierdzenie.Text = "Potwierdź";
            this.potwierdzenie.UseVisualStyleBackColor = true;
            // 
            // anulowanie
            // 
            this.anulowanie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulowanie.Location = new System.Drawing.Point(168, 171);
            this.anulowanie.Name = "anulowanie";
            this.anulowanie.Size = new System.Drawing.Size(75, 23);
            this.anulowanie.TabIndex = 1;
            this.anulowanie.Text = "Anuluj";
            this.anulowanie.UseVisualStyleBackColor = true;
            // 
            // GenNum
            // 
            this.GenNum.AutoSize = true;
            this.GenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenNum.Location = new System.Drawing.Point(112, 51);
            this.GenNum.Name = "GenNum";
            this.GenNum.Size = new System.Drawing.Size(55, 24);
            this.GenNum.TabIndex = 2;
            this.GenNum.Text = "label";
            // 
            // GenNumText
            // 
            this.GenNumText.Location = new System.Drawing.Point(92, 109);
            this.GenNumText.Name = "GenNumText";
            this.GenNumText.Size = new System.Drawing.Size(100, 20);
            this.GenNumText.TabIndex = 3;
            // 
            // Potwierdź
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.GenNumText);
            this.Controls.Add(this.GenNum);
            this.Controls.Add(this.anulowanie);
            this.Controls.Add(this.potwierdzenie);
            this.Name = "Potwierdź";
            this.Text = "Potwierdź";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button potwierdzenie;
        private System.Windows.Forms.Button anulowanie;
        private System.Windows.Forms.Label GenNum;
        private System.Windows.Forms.TextBox GenNumText;
    }
}