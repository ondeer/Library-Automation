namespace Kütüphane
{
    partial class teslimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teslimal));
            this.BtnKitapCikis = new System.Windows.Forms.Button();
            this.btnteslim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKitapCikis
            // 
            this.BtnKitapCikis.FlatAppearance.BorderSize = 0;
            this.BtnKitapCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKitapCikis.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKitapCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitapCikis.Image")));
            this.BtnKitapCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnKitapCikis.Location = new System.Drawing.Point(615, 383);
            this.BtnKitapCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKitapCikis.Name = "BtnKitapCikis";
            this.BtnKitapCikis.Size = new System.Drawing.Size(154, 88);
            this.BtnKitapCikis.TabIndex = 91;
            this.BtnKitapCikis.Text = "Ana Sayfa";
            this.BtnKitapCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKitapCikis.UseVisualStyleBackColor = true;
            this.BtnKitapCikis.Click += new System.EventHandler(this.BtnKitapCikis_Click);
            // 
            // btnteslim
            // 
            this.btnteslim.FlatAppearance.BorderSize = 0;
            this.btnteslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteslim.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteslim.Image = ((System.Drawing.Image)(resources.GetObject("btnteslim.Image")));
            this.btnteslim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnteslim.Location = new System.Drawing.Point(437, 382);
            this.btnteslim.Name = "btnteslim";
            this.btnteslim.Size = new System.Drawing.Size(159, 89);
            this.btnteslim.TabIndex = 90;
            this.btnteslim.Text = "Teslim al";
            this.btnteslim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnteslim.UseVisualStyleBackColor = true;
            this.btnteslim.Click += new System.EventHandler(this.btnteslim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 342);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teslimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 492);
            this.ControlBox = false;
            this.Controls.Add(this.BtnKitapCikis);
            this.Controls.Add(this.btnteslim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teslimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim";
            this.Load += new System.EventHandler(this.Emanetlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKitapCikis;
        private System.Windows.Forms.Button btnteslim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}