namespace Przychodnia.Recepty_formy
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
            this.komL = new System.Windows.Forms.Label();
            this.wygenL = new System.Windows.Forms.Label();
            this.potwDialog = new System.Windows.Forms.Button();
            this.anlulujDialog = new System.Windows.Forms.Button();
            this.checnumT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // komL
            // 
            this.komL.AutoSize = true;
            this.komL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komL.Location = new System.Drawing.Point(30, 25);
            this.komL.Name = "komL";
            this.komL.Size = new System.Drawing.Size(57, 20);
            this.komL.TabIndex = 0;
            this.komL.Text = "label1";
            this.komL.Visible = false;
            // 
            // wygenL
            // 
            this.wygenL.AutoSize = true;
            this.wygenL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wygenL.Location = new System.Drawing.Point(184, 112);
            this.wygenL.Name = "wygenL";
            this.wygenL.Size = new System.Drawing.Size(61, 27);
            this.wygenL.TabIndex = 1;
            this.wygenL.Text = "label2";
            this.wygenL.UseCompatibleTextRendering = true;
            // 
            // potwDialog
            // 
            this.potwDialog.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.potwDialog.Location = new System.Drawing.Point(72, 284);
            this.potwDialog.Name = "potwDialog";
            this.potwDialog.Size = new System.Drawing.Size(101, 37);
            this.potwDialog.TabIndex = 2;
            this.potwDialog.Text = "Potwierdz";
            this.potwDialog.UseVisualStyleBackColor = true;
            this.potwDialog.Click += new System.EventHandler(this.potwDialog_Click);
            // 
            // anlulujDialog
            // 
            this.anlulujDialog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anlulujDialog.Location = new System.Drawing.Point(254, 284);
            this.anlulujDialog.Name = "anlulujDialog";
            this.anlulujDialog.Size = new System.Drawing.Size(101, 37);
            this.anlulujDialog.TabIndex = 3;
            this.anlulujDialog.Text = "Anuluj";
            this.anlulujDialog.UseVisualStyleBackColor = true;
            this.anlulujDialog.Click += new System.EventHandler(this.anlulujDialog_Click);
            // 
            // checnumT
            // 
            this.checnumT.Location = new System.Drawing.Point(146, 156);
            this.checnumT.Name = "checnumT";
            this.checnumT.Size = new System.Drawing.Size(130, 20);
            this.checnumT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aby potwierdzić usunięcie przepisz powyższą liczbę i kliknij potwierdz";
            // 
            // PotwierdzDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checnumT);
            this.Controls.Add(this.anlulujDialog);
            this.Controls.Add(this.potwDialog);
            this.Controls.Add(this.wygenL);
            this.Controls.Add(this.komL);
            this.Name = "PotwierdzDialog";
            this.Text = "PotwierdzDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label komL;
        private System.Windows.Forms.Label wygenL;
        private System.Windows.Forms.Button potwDialog;
        private System.Windows.Forms.Button anlulujDialog;
        private System.Windows.Forms.TextBox checnumT;
        private System.Windows.Forms.Label label3;
    }
}