namespace wodomierz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.haslo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pLogin = new System.Windows.Forms.Label();
            this.pHaslo = new System.Windows.Forms.Label();
            this.pWynikLogowania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(290, 64);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(174, 20);
            this.haslo.TabIndex = 1;
            this.haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pLogin
            // 
            this.pLogin.AutoSize = true;
            this.pLogin.Location = new System.Drawing.Point(189, 45);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(36, 13);
            this.pLogin.TabIndex = 3;
            this.pLogin.Text = "Login:";
            this.pLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // pHaslo
            // 
            this.pHaslo.AutoSize = true;
            this.pHaslo.Location = new System.Drawing.Point(189, 71);
            this.pHaslo.Name = "pHaslo";
            this.pHaslo.Size = new System.Drawing.Size(39, 13);
            this.pHaslo.TabIndex = 4;
            this.pHaslo.Text = "Hasło:";
            // 
            // pWynikLogowania
            // 
            this.pWynikLogowania.AutoSize = true;
            this.pWynikLogowania.Location = new System.Drawing.Point(375, 219);
            this.pWynikLogowania.Name = "pWynikLogowania";
            this.pWynikLogowania.Size = new System.Drawing.Size(10, 13);
            this.pWynikLogowania.TabIndex = 5;
            this.pWynikLogowania.Text = ".";
            this.pWynikLogowania.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pWynikLogowania);
            this.Controls.Add(this.pHaslo);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Wodomierz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pLogin;
        private System.Windows.Forms.Label pHaslo;
        private System.Windows.Forms.Label pWynikLogowania;
    }
}

