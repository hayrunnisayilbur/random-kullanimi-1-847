namespace random_kullanimi_1_847
{
    partial class Form1
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnOrtalamaNotUret = new System.Windows.Forms.Button();
            this.btnGecmeKalmaDurum = new System.Windows.Forms.Button();
            this.lblOgrenciNotlar = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblDuzGecen = new System.Windows.Forms.Label();
            this.lblTakdir = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(250, 96);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(198, 238);
            this.lbNotlar.TabIndex = 0;
            // 
            // btnOrtalamaNotUret
            // 
            this.btnOrtalamaNotUret.Location = new System.Drawing.Point(48, 96);
            this.btnOrtalamaNotUret.Name = "btnOrtalamaNotUret";
            this.btnOrtalamaNotUret.Size = new System.Drawing.Size(165, 68);
            this.btnOrtalamaNotUret.TabIndex = 1;
            this.btnOrtalamaNotUret.Text = "ortalama not üret";
            this.btnOrtalamaNotUret.UseVisualStyleBackColor = true;
            this.btnOrtalamaNotUret.Click += new System.EventHandler(this.btnOrtalamaNotUret_Click);
            // 
            // btnGecmeKalmaDurum
            // 
            this.btnGecmeKalmaDurum.Location = new System.Drawing.Point(48, 345);
            this.btnGecmeKalmaDurum.Name = "btnGecmeKalmaDurum";
            this.btnGecmeKalmaDurum.Size = new System.Drawing.Size(165, 69);
            this.btnGecmeKalmaDurum.TabIndex = 2;
            this.btnGecmeKalmaDurum.Text = "geçme kalma durum";
            this.btnGecmeKalmaDurum.UseVisualStyleBackColor = true;
            this.btnGecmeKalmaDurum.Click += new System.EventHandler(this.btnGecmeKalmaDurum_Click);
            // 
            // lblOgrenciNotlar
            // 
            this.lblOgrenciNotlar.AutoSize = true;
            this.lblOgrenciNotlar.Location = new System.Drawing.Point(247, 64);
            this.lblOgrenciNotlar.Name = "lblOgrenciNotlar";
            this.lblOgrenciNotlar.Size = new System.Drawing.Size(74, 13);
            this.lblOgrenciNotlar.TabIndex = 3;
            this.lblOgrenciNotlar.Text = "öğrenci notlar:";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(250, 345);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(102, 13);
            this.lblKalan.TabIndex = 4;
            this.lblKalan.Text = "kalan öğrenci sayısı:";
            // 
            // lblDuzGecen
            // 
            this.lblDuzGecen.AutoSize = true;
            this.lblDuzGecen.Location = new System.Drawing.Point(250, 373);
            this.lblDuzGecen.Name = "lblDuzGecen";
            this.lblDuzGecen.Size = new System.Drawing.Size(126, 13);
            this.lblDuzGecen.TabIndex = 5;
            this.lblDuzGecen.Text = "düz geçen öğrenci sayısı:";
            // 
            // lblTakdir
            // 
            this.lblTakdir.AutoSize = true;
            this.lblTakdir.Location = new System.Drawing.Point(250, 400);
            this.lblTakdir.Name = "lblTakdir";
            this.lblTakdir.Size = new System.Drawing.Size(64, 13);
            this.lblTakdir.TabIndex = 6;
            this.lblTakdir.Text = "takdir sayısı:";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Location = new System.Drawing.Point(250, 426);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(79, 13);
            this.lblTesekkur.TabIndex = 7;
            this.lblTesekkur.Text = "teşekkür sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 557);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblTakdir);
            this.Controls.Add(this.lblDuzGecen);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblOgrenciNotlar);
            this.Controls.Add(this.btnGecmeKalmaDurum);
            this.Controls.Add(this.btnOrtalamaNotUret);
            this.Controls.Add(this.lbNotlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnOrtalamaNotUret;
        private System.Windows.Forms.Button btnGecmeKalmaDurum;
        private System.Windows.Forms.Label lblOgrenciNotlar;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblDuzGecen;
        private System.Windows.Forms.Label lblTakdir;
        private System.Windows.Forms.Label lblTesekkur;
    }
}

