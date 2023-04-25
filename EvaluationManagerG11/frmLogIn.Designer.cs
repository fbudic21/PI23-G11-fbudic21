namespace EvaluationManagerG11 {
    partial class frmLogIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.textKorisnickoIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Korisnicko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lozinka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Prijava";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(156, 81);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 9;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // textKorisnickoIme
            // 
            this.textKorisnickoIme.Location = new System.Drawing.Point(156, 54);
            this.textKorisnickoIme.Name = "textKorisnickoIme";
            this.textKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.textKorisnickoIme.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 182);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.textKorisnickoIme);
            this.Name = "Form1";
            this.Text = "frmLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox textKorisnickoIme;
    }
}

