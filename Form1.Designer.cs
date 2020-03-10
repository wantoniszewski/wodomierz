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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.haslo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pLogin = new System.Windows.Forms.Label();
            this.pHaslo = new System.Windows.Forms.Label();
            this.pWynikLogowania = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qwqwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sssdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssfddsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrrt4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uioiuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(72, 38);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(174, 20);
            this.haslo.TabIndex = 1;
            this.haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pLogin
            // 
            this.pLogin.AutoSize = true;
            this.pLogin.Location = new System.Drawing.Point(22, 19);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(36, 13);
            this.pLogin.TabIndex = 3;
            this.pLogin.Text = "Login:";
            this.pLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // pHaslo
            // 
            this.pHaslo.AutoSize = true;
            this.pHaslo.Location = new System.Drawing.Point(22, 45);
            this.pHaslo.Name = "pHaslo";
            this.pHaslo.Size = new System.Drawing.Size(39, 13);
            this.pHaslo.TabIndex = 4;
            this.pHaslo.Text = "Hasło:";
            // 
            // pWynikLogowania
            // 
            this.pWynikLogowania.AutoSize = true;
            this.pWynikLogowania.Location = new System.Drawing.Point(280, 19);
            this.pWynikLogowania.Name = "pWynikLogowania";
            this.pWynikLogowania.Size = new System.Drawing.Size(10, 13);
            this.pWynikLogowania.TabIndex = 5;
            this.pWynikLogowania.Text = ".";
            this.pWynikLogowania.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1036, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwqwToolStripMenuItem,
            this.asToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem,
            this.sssdToolStripMenuItem,
            this.ssfddsToolStripMenuItem});
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asToolStripMenuItem.Text = "as";
            // 
            // qwqwToolStripMenuItem
            // 
            this.qwqwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rrrToolStripMenuItem,
            this.rrrt4ToolStripMenuItem,
            this.uioiuyToolStripMenuItem});
            this.qwqwToolStripMenuItem.Name = "qwqwToolStripMenuItem";
            this.qwqwToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qwqwToolStripMenuItem.Text = "qwqw";
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ssToolStripMenuItem.Text = "ss";
            // 
            // sssdToolStripMenuItem
            // 
            this.sssdToolStripMenuItem.Name = "sssdToolStripMenuItem";
            this.sssdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sssdToolStripMenuItem.Text = "sssd";
            // 
            // ssfddsToolStripMenuItem
            // 
            this.ssfddsToolStripMenuItem.Name = "ssfddsToolStripMenuItem";
            this.ssfddsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ssfddsToolStripMenuItem.Text = "ssfdds";
            // 
            // rrrToolStripMenuItem
            // 
            this.rrrToolStripMenuItem.Name = "rrrToolStripMenuItem";
            this.rrrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rrrToolStripMenuItem.Text = "rrr";
            // 
            // rrrt4ToolStripMenuItem
            // 
            this.rrrt4ToolStripMenuItem.Name = "rrrt4ToolStripMenuItem";
            this.rrrt4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rrrt4ToolStripMenuItem.Text = "rrrt4";
            // 
            // uioiuyToolStripMenuItem
            // 
            this.uioiuyToolStripMenuItem.Name = "uioiuyToolStripMenuItem";
            this.uioiuyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uioiuyToolStripMenuItem.Text = "uioiuy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pWynikLogowania);
            this.Controls.Add(this.pHaslo);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Wodomierz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem qwqwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rrrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rrrt4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uioiuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sssdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssfddsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}

