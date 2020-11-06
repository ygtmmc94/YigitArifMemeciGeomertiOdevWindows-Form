namespace GeomometriOdev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lSekil = new System.Windows.Forms.Label();
            this.cbSekil = new System.Windows.Forms.ComboBox();
            this.pDikdortgen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDikdörtgenKısa = new System.Windows.Forms.TextBox();
            this.tbDikdörtgenUzun = new System.Windows.Forms.TextBox();
            this.lKısaKenarDikdörtgen = new System.Windows.Forms.Label();
            this.lUzunKenarDikDörtgen = new System.Windows.Forms.Label();
            this.pDikUcgen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lYukseklikDikUcgen = new System.Windows.Forms.Label();
            this.lTabanKenarDikUcgen = new System.Windows.Forms.Label();
            this.tbYukseklikDikUcgen = new System.Windows.Forms.TextBox();
            this.tbTabanKenarDikUcgen = new System.Windows.Forms.TextBox();
            this.pKare = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKareKenar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pEskenarUcgen = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lTabanKenarEsUcgen = new System.Windows.Forms.Label();
            this.tbTabanKenarEsUcgen = new System.Windows.Forms.TextBox();
            this.pDaire = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDaireYarıCap = new System.Windows.Forms.TextBox();
            this.lDaireYarıCap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHesapla = new System.Windows.Forms.ComboBox();
            this.bHesapla = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.bTemizle = new System.Windows.Forms.Button();
            this.pDikdortgen.SuspendLayout();
            this.pDikUcgen.SuspendLayout();
            this.pKare.SuspendLayout();
            this.pEskenarUcgen.SuspendLayout();
            this.pDaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // lSekil
            // 
            this.lSekil.AutoSize = true;
            this.lSekil.BackColor = System.Drawing.SystemColors.Menu;
            this.lSekil.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSekil.Location = new System.Drawing.Point(23, 47);
            this.lSekil.Name = "lSekil";
            this.lSekil.Size = new System.Drawing.Size(180, 21);
            this.lSekil.TabIndex = 0;
            this.lSekil.Text = "Geometrik Sekil :";
            // 
            // cbSekil
            // 
            this.cbSekil.BackColor = System.Drawing.SystemColors.Info;
            this.cbSekil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSekil.FormattingEnabled = true;
            this.cbSekil.Location = new System.Drawing.Point(226, 47);
            this.cbSekil.Name = "cbSekil";
            this.cbSekil.Size = new System.Drawing.Size(193, 21);
            this.cbSekil.TabIndex = 1;
            this.cbSekil.SelectedIndexChanged += new System.EventHandler(this.cbSekil_SelectedIndexChanged);
            // 
            // pDikdortgen
            // 
            this.pDikdortgen.BackColor = System.Drawing.Color.Transparent;
            this.pDikdortgen.Controls.Add(this.label1);
            this.pDikdortgen.Controls.Add(this.tbDikdörtgenKısa);
            this.pDikdortgen.Controls.Add(this.tbDikdörtgenUzun);
            this.pDikdortgen.Controls.Add(this.lKısaKenarDikdörtgen);
            this.pDikdortgen.Controls.Add(this.lUzunKenarDikDörtgen);
            this.pDikdortgen.Location = new System.Drawing.Point(31, 95);
            this.pDikdortgen.Name = "pDikdortgen";
            this.pDikdortgen.Size = new System.Drawing.Size(232, 120);
            this.pDikdortgen.TabIndex = 2;
            this.pDikdortgen.Paint += new System.Windows.Forms.PaintEventHandler(this.pDikdortgen_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "DikDörtgen";
            // 
            // tbDikdörtgenKısa
            // 
            this.tbDikdörtgenKısa.BackColor = System.Drawing.SystemColors.Info;
            this.tbDikdörtgenKısa.Location = new System.Drawing.Point(130, 92);
            this.tbDikdörtgenKısa.Name = "tbDikdörtgenKısa";
            this.tbDikdörtgenKısa.Size = new System.Drawing.Size(85, 20);
            this.tbDikdörtgenKısa.TabIndex = 3;
            // 
            // tbDikdörtgenUzun
            // 
            this.tbDikdörtgenUzun.BackColor = System.Drawing.SystemColors.Info;
            this.tbDikdörtgenUzun.Location = new System.Drawing.Point(130, 70);
            this.tbDikdörtgenUzun.Name = "tbDikdörtgenUzun";
            this.tbDikdörtgenUzun.Size = new System.Drawing.Size(85, 20);
            this.tbDikdörtgenUzun.TabIndex = 2;
            this.tbDikdörtgenUzun.TextChanged += new System.EventHandler(this.tbDikdörtgenUzun_TextChanged);
            // 
            // lKısaKenarDikdörtgen
            // 
            this.lKısaKenarDikdörtgen.AutoSize = true;
            this.lKısaKenarDikdörtgen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKısaKenarDikdörtgen.Location = new System.Drawing.Point(13, 92);
            this.lKısaKenarDikdörtgen.Name = "lKısaKenarDikdörtgen";
            this.lKısaKenarDikdörtgen.Size = new System.Drawing.Size(99, 16);
            this.lKısaKenarDikdörtgen.TabIndex = 1;
            this.lKısaKenarDikdörtgen.Text = "Kısa Kenar :";
            // 
            // lUzunKenarDikDörtgen
            // 
            this.lUzunKenarDikDörtgen.AutoSize = true;
            this.lUzunKenarDikDörtgen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUzunKenarDikDörtgen.Location = new System.Drawing.Point(13, 72);
            this.lUzunKenarDikDörtgen.Name = "lUzunKenarDikDörtgen";
            this.lUzunKenarDikDörtgen.Size = new System.Drawing.Size(105, 16);
            this.lUzunKenarDikDörtgen.TabIndex = 0;
            this.lUzunKenarDikDörtgen.Text = "Uzun Kenar :";
            // 
            // pDikUcgen
            // 
            this.pDikUcgen.BackColor = System.Drawing.Color.Transparent;
            this.pDikUcgen.Controls.Add(this.label2);
            this.pDikUcgen.Controls.Add(this.lYukseklikDikUcgen);
            this.pDikUcgen.Controls.Add(this.lTabanKenarDikUcgen);
            this.pDikUcgen.Controls.Add(this.tbYukseklikDikUcgen);
            this.pDikUcgen.Controls.Add(this.tbTabanKenarDikUcgen);
            this.pDikUcgen.Location = new System.Drawing.Point(270, 95);
            this.pDikUcgen.Name = "pDikUcgen";
            this.pDikUcgen.Size = new System.Drawing.Size(232, 120);
            this.pDikUcgen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dik Üçgen";
            // 
            // lYukseklikDikUcgen
            // 
            this.lYukseklikDikUcgen.AutoSize = true;
            this.lYukseklikDikUcgen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lYukseklikDikUcgen.Location = new System.Drawing.Point(14, 95);
            this.lYukseklikDikUcgen.Name = "lYukseklikDikUcgen";
            this.lYukseklikDikUcgen.Size = new System.Drawing.Size(89, 16);
            this.lYukseklikDikUcgen.TabIndex = 5;
            this.lYukseklikDikUcgen.Text = "Yükseklik :";
            // 
            // lTabanKenarDikUcgen
            // 
            this.lTabanKenarDikUcgen.AutoSize = true;
            this.lTabanKenarDikUcgen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lTabanKenarDikUcgen.Location = new System.Drawing.Point(14, 71);
            this.lTabanKenarDikUcgen.Name = "lTabanKenarDikUcgen";
            this.lTabanKenarDikUcgen.Size = new System.Drawing.Size(115, 16);
            this.lTabanKenarDikUcgen.TabIndex = 4;
            this.lTabanKenarDikUcgen.Text = "Taban Kenar :";
            // 
            // tbYukseklikDikUcgen
            // 
            this.tbYukseklikDikUcgen.BackColor = System.Drawing.SystemColors.Info;
            this.tbYukseklikDikUcgen.Location = new System.Drawing.Point(133, 92);
            this.tbYukseklikDikUcgen.Name = "tbYukseklikDikUcgen";
            this.tbYukseklikDikUcgen.Size = new System.Drawing.Size(85, 20);
            this.tbYukseklikDikUcgen.TabIndex = 4;
            // 
            // tbTabanKenarDikUcgen
            // 
            this.tbTabanKenarDikUcgen.BackColor = System.Drawing.SystemColors.Info;
            this.tbTabanKenarDikUcgen.Location = new System.Drawing.Point(133, 71);
            this.tbTabanKenarDikUcgen.Name = "tbTabanKenarDikUcgen";
            this.tbTabanKenarDikUcgen.Size = new System.Drawing.Size(85, 20);
            this.tbTabanKenarDikUcgen.TabIndex = 3;
            // 
            // pKare
            // 
            this.pKare.BackColor = System.Drawing.Color.Transparent;
            this.pKare.Controls.Add(this.label4);
            this.pKare.Controls.Add(this.tbKareKenar);
            this.pKare.Controls.Add(this.label3);
            this.pKare.Location = new System.Drawing.Point(31, 221);
            this.pKare.Name = "pKare";
            this.pKare.Size = new System.Drawing.Size(233, 87);
            this.pKare.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kare";
            // 
            // tbKareKenar
            // 
            this.tbKareKenar.BackColor = System.Drawing.SystemColors.Info;
            this.tbKareKenar.Location = new System.Drawing.Point(130, 54);
            this.tbKareKenar.Name = "tbKareKenar";
            this.tbKareKenar.Size = new System.Drawing.Size(85, 20);
            this.tbKareKenar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kenar :";
            // 
            // pEskenarUcgen
            // 
            this.pEskenarUcgen.BackColor = System.Drawing.Color.Transparent;
            this.pEskenarUcgen.Controls.Add(this.label5);
            this.pEskenarUcgen.Controls.Add(this.lTabanKenarEsUcgen);
            this.pEskenarUcgen.Controls.Add(this.tbTabanKenarEsUcgen);
            this.pEskenarUcgen.Location = new System.Drawing.Point(270, 221);
            this.pEskenarUcgen.Name = "pEskenarUcgen";
            this.pEskenarUcgen.Size = new System.Drawing.Size(232, 87);
            this.pEskenarUcgen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Eşkenar Üçgen";
            // 
            // lTabanKenarEsUcgen
            // 
            this.lTabanKenarEsUcgen.AutoSize = true;
            this.lTabanKenarEsUcgen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lTabanKenarEsUcgen.Location = new System.Drawing.Point(12, 54);
            this.lTabanKenarEsUcgen.Name = "lTabanKenarEsUcgen";
            this.lTabanKenarEsUcgen.Size = new System.Drawing.Size(115, 16);
            this.lTabanKenarEsUcgen.TabIndex = 7;
            this.lTabanKenarEsUcgen.Text = "Taban Kenar :";
            // 
            // tbTabanKenarEsUcgen
            // 
            this.tbTabanKenarEsUcgen.BackColor = System.Drawing.SystemColors.Info;
            this.tbTabanKenarEsUcgen.Location = new System.Drawing.Point(133, 51);
            this.tbTabanKenarEsUcgen.Name = "tbTabanKenarEsUcgen";
            this.tbTabanKenarEsUcgen.Size = new System.Drawing.Size(85, 20);
            this.tbTabanKenarEsUcgen.TabIndex = 4;
            // 
            // pDaire
            // 
            this.pDaire.BackColor = System.Drawing.Color.Transparent;
            this.pDaire.Controls.Add(this.label7);
            this.pDaire.Controls.Add(this.tbDaireYarıCap);
            this.pDaire.Controls.Add(this.lDaireYarıCap);
            this.pDaire.Location = new System.Drawing.Point(161, 314);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(232, 87);
            this.pDaire.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Daire";
            // 
            // tbDaireYarıCap
            // 
            this.tbDaireYarıCap.BackColor = System.Drawing.SystemColors.Info;
            this.tbDaireYarıCap.Location = new System.Drawing.Point(130, 50);
            this.tbDaireYarıCap.Name = "tbDaireYarıCap";
            this.tbDaireYarıCap.Size = new System.Drawing.Size(88, 20);
            this.tbDaireYarıCap.TabIndex = 5;
            // 
            // lDaireYarıCap
            // 
            this.lDaireYarıCap.AutoSize = true;
            this.lDaireYarıCap.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDaireYarıCap.Location = new System.Drawing.Point(24, 50);
            this.lDaireYarıCap.Name = "lDaireYarıCap";
            this.lDaireYarıCap.Size = new System.Drawing.Size(88, 16);
            this.lDaireYarıCap.TabIndex = 5;
            this.lDaireYarıCap.Text = "Yarı Çapı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "SONUÇ :";
            // 
            // cbHesapla
            // 
            this.cbHesapla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHesapla.FormattingEnabled = true;
            this.cbHesapla.Items.AddRange(new object[] {
            "-- Seçiniz --",
            "Çevre",
            "Alan"});
            this.cbHesapla.Location = new System.Drawing.Point(169, 407);
            this.cbHesapla.Name = "cbHesapla";
            this.cbHesapla.Size = new System.Drawing.Size(210, 21);
            this.cbHesapla.TabIndex = 14;
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(304, 434);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(75, 23);
            this.bHesapla.TabIndex = 15;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.BackColor = System.Drawing.SystemColors.Info;
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(159, 463);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(240, 56);
            this.lbSonuc.TabIndex = 16;
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(171, 434);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 17;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(526, 590);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.cbHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pDikUcgen);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.pEskenarUcgen);
            this.Controls.Add(this.pKare);
            this.Controls.Add(this.pDikdortgen);
            this.Controls.Add(this.cbSekil);
            this.Controls.Add(this.lSekil);
            this.Name = "Form1";
            this.Text = "GeometrikHesaplamalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pDikdortgen.ResumeLayout(false);
            this.pDikdortgen.PerformLayout();
            this.pDikUcgen.ResumeLayout(false);
            this.pDikUcgen.PerformLayout();
            this.pKare.ResumeLayout(false);
            this.pKare.PerformLayout();
            this.pEskenarUcgen.ResumeLayout(false);
            this.pEskenarUcgen.PerformLayout();
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSekil;
        private System.Windows.Forms.ComboBox cbSekil;
        private System.Windows.Forms.Panel pDikdortgen;
        private System.Windows.Forms.Label lKısaKenarDikdörtgen;
        private System.Windows.Forms.Label lUzunKenarDikDörtgen;
        private System.Windows.Forms.Panel pDikUcgen;
        private System.Windows.Forms.Panel pKare;
        private System.Windows.Forms.Panel pEskenarUcgen;
        private System.Windows.Forms.TextBox tbDikdörtgenKısa;
        private System.Windows.Forms.TextBox tbDikdörtgenUzun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lYukseklikDikUcgen;
        private System.Windows.Forms.Label lTabanKenarDikUcgen;
        private System.Windows.Forms.TextBox tbYukseklikDikUcgen;
        private System.Windows.Forms.TextBox tbTabanKenarDikUcgen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKareKenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lTabanKenarEsUcgen;
        private System.Windows.Forms.TextBox tbTabanKenarEsUcgen;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.TextBox tbDaireYarıCap;
        private System.Windows.Forms.Label lDaireYarıCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHesapla;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button bTemizle;
    }
}

