namespace Kütüphane
{
    partial class okyckayıtform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okyckayıtform));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnOkuyucuCikis = new System.Windows.Forms.Button();
            this.BtnOkuyucuGuncelle = new System.Windows.Forms.Button();
            this.BtnOkuyucuEkle = new System.Windows.Forms.Button();
            this.DateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.TxtDogumYeri = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrKayitPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(320, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 102;
            // 
            // TxtTelefonNo
            // 
            this.TxtTelefonNo.Location = new System.Drawing.Point(254, 278);
            this.TxtTelefonNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefonNo.Mask = "(999) 000-0000";
            this.TxtTelefonNo.Name = "TxtTelefonNo";
            this.TxtTelefonNo.Size = new System.Drawing.Size(209, 22);
            this.TxtTelefonNo.TabIndex = 88;
            // 
            // BtnOkuyucuCikis
            // 
            this.BtnOkuyucuCikis.FlatAppearance.BorderSize = 0;
            this.BtnOkuyucuCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkuyucuCikis.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkuyucuCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnOkuyucuCikis.Image")));
            this.BtnOkuyucuCikis.Location = new System.Drawing.Point(530, 376);
            this.BtnOkuyucuCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOkuyucuCikis.Name = "BtnOkuyucuCikis";
            this.BtnOkuyucuCikis.Size = new System.Drawing.Size(167, 101);
            this.BtnOkuyucuCikis.TabIndex = 93;
            this.BtnOkuyucuCikis.Text = "Ana Sayfa";
            this.BtnOkuyucuCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOkuyucuCikis.UseVisualStyleBackColor = true;
            this.BtnOkuyucuCikis.Click += new System.EventHandler(this.BtnOkuyucuCikis_Click);
            // 
            // BtnOkuyucuGuncelle
            // 
            this.BtnOkuyucuGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnOkuyucuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkuyucuGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkuyucuGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnOkuyucuGuncelle.Image")));
            this.BtnOkuyucuGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOkuyucuGuncelle.Location = new System.Drawing.Point(504, 219);
            this.BtnOkuyucuGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOkuyucuGuncelle.Name = "BtnOkuyucuGuncelle";
            this.BtnOkuyucuGuncelle.Size = new System.Drawing.Size(213, 93);
            this.BtnOkuyucuGuncelle.TabIndex = 92;
            this.BtnOkuyucuGuncelle.Text = "Sil veya Güncelle";
            this.BtnOkuyucuGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOkuyucuGuncelle.UseVisualStyleBackColor = true;
            this.BtnOkuyucuGuncelle.Click += new System.EventHandler(this.BtnOkuyucuGuncelle_Click);
            // 
            // BtnOkuyucuEkle
            // 
            this.BtnOkuyucuEkle.FlatAppearance.BorderSize = 0;
            this.BtnOkuyucuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkuyucuEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkuyucuEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnOkuyucuEkle.Image")));
            this.BtnOkuyucuEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOkuyucuEkle.Location = new System.Drawing.Point(530, 87);
            this.BtnOkuyucuEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOkuyucuEkle.Name = "BtnOkuyucuEkle";
            this.BtnOkuyucuEkle.Size = new System.Drawing.Size(139, 84);
            this.BtnOkuyucuEkle.TabIndex = 91;
            this.BtnOkuyucuEkle.Text = "Ekle";
            this.BtnOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOkuyucuEkle.UseVisualStyleBackColor = true;
            this.BtnOkuyucuEkle.Click += new System.EventHandler(this.BtnOkuyucuEkle_Click);
            // 
            // DateTimeDogumTarihi
            // 
            this.DateTimeDogumTarihi.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeDogumTarihi.Location = new System.Drawing.Point(254, 219);
            this.DateTimeDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeDogumTarihi.Name = "DateTimeDogumTarihi";
            this.DateTimeDogumTarihi.Size = new System.Drawing.Size(209, 27);
            this.DateTimeDogumTarihi.TabIndex = 87;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(254, 385);
            this.TxtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(209, 109);
            this.TxtAdres.TabIndex = 90;
            // 
            // TxtEposta
            // 
            this.TxtEposta.Location = new System.Drawing.Point(254, 327);
            this.TxtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(209, 22);
            this.TxtEposta.TabIndex = 89;
            // 
            // TxtDogumYeri
            // 
            this.TxtDogumYeri.Location = new System.Drawing.Point(254, 176);
            this.TxtDogumYeri.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDogumYeri.Name = "TxtDogumYeri";
            this.TxtDogumYeri.Size = new System.Drawing.Size(209, 22);
            this.TxtDogumYeri.TabIndex = 86;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(254, 133);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(209, 22);
            this.TxtAdSoyad.TabIndex = 85;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(254, 87);
            this.TxtTc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(209, 22);
            this.TxtTc.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(56, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 27);
            this.label10.TabIndex = 100;
            this.label10.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(57, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 99;
            this.label7.Text = "E-Posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(56, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 98;
            this.label6.Text = "Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(57, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 97;
            this.label5.Text = "Kayıt Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(56, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 27);
            this.label4.TabIndex = 96;
            this.label4.Text = "Doğum Yeri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(56, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 95;
            this.label3.Text = "TC No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(56, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 94;
            this.label1.Text = "Ad Soyad :";
            // 
            // OgrKayitPanel
            // 
            this.OgrKayitPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OgrKayitPanel.BackgroundImage")));
            this.OgrKayitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OgrKayitPanel.Location = new System.Drawing.Point(61, 13);
            this.OgrKayitPanel.Margin = new System.Windows.Forms.Padding(4);
            this.OgrKayitPanel.Name = "OgrKayitPanel";
            this.OgrKayitPanel.Size = new System.Drawing.Size(452, 53);
            this.OgrKayitPanel.TabIndex = 103;
            // 
            // okyckayıtform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 517);
            this.ControlBox = false;
            this.Controls.Add(this.OgrKayitPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTelefonNo);
            this.Controls.Add(this.BtnOkuyucuCikis);
            this.Controls.Add(this.BtnOkuyucuGuncelle);
            this.Controls.Add(this.BtnOkuyucuEkle);
            this.Controls.Add(this.DateTimeDogumTarihi);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.TxtEposta);
            this.Controls.Add(this.TxtDogumYeri);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "okyckayıtform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtTelefonNo;
        private System.Windows.Forms.Button BtnOkuyucuCikis;
        private System.Windows.Forms.Button BtnOkuyucuGuncelle;
        private System.Windows.Forms.Button BtnOkuyucuEkle;
        private System.Windows.Forms.DateTimePicker DateTimeDogumTarihi;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtEposta;
        private System.Windows.Forms.TextBox TxtDogumYeri;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel OgrKayitPanel;
    }
}