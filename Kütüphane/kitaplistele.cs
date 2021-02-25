using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//veritabanı işlemleri için
using IK;               //İşlem katmanına erişim için
namespace Kütüphane
{
    public partial class kitaplistele : Form
    {
        public kitaplistele()
        {
            InitializeComponent();
        }

        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)
        {
            //Anaforma dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }
        DataTable tablo = new DataTable();          //tablo adında bir datatable oluşturuluyor.
        public void listele()
        {
            IK.kitap liste = new IK.kitap();            //iş katmanından nesne oluşturuluyor
            OleDbDataAdapter adtr = liste.kitapcek();   //adtr ye kitapçekteki veriler aktarılıyor 
            tablo.Clear();
            adtr.Fill(tablo);                           //adtrye tablo aktarılıyor.
            dataGridView1.DataSource = tablo;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Tüm satırı seçsin diye yapıldı.

            dataGridView1.MultiSelect = false;//Tek bir sütundan seçilsin yapıldı

        }
        private void kitaplistele_Load(object sender, EventArgs e)
        {
            listele(); //Form loadında listele metodu çağırılıyor
        }

       
    }
}
