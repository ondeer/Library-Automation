namespace Kütüphane
{
    partial class kitaplistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitaplistele));
            this.BtnOkuyucuCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOkuyucuCikis
            // 
            this.BtnOkuyucuCikis.FlatAppearance.BorderSize = 0;
            this.BtnOkuyucuCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOkuyucuCikis.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkuyucuCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnOkuyucuCikis.Image")));
            this.BtnOkuyucuCikis.Location = new System.Drawing.Point(438, 361);
            this.BtnOkuyucuCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOkuyucuCikis.Name = "BtnOkuyucuCikis";
            this.BtnOkuyucuCikis.Size = new System.Drawing.Size(159, 99);
            this.BtnOkuyucuCikis.TabIndex = 77;
            this.BtnOkuyucuCikis.Text = "Ana Sayfa";
            this.BtnOkuyucuCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOkuyucuCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOkuyucuCikis.UseVisualStyleBackColor = true;
            this.BtnOkuyucuCikis.Click += new System.EventHandler(this.BtnOkuyucuCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 342);
            this.dataGridView1.TabIndex = 76;
            // 
            // kitaplistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 473);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOkuyucuCikis);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitaplistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Liste";
            this.Load += new System.EventHandler(this.kitaplistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOkuyucuCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}