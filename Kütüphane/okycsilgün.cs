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
using IK;               //İşlem Katmanına erişmek için
namespace Kütüphane
{
    public partial class okycsilgün : Form
    {
        public okycsilgün()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();
        public void listele()
        {                 //diğer listeleme işlemleri ile aynı işlemler yapılıyor.
            IK.okuyucu liste = new IK.okuyucu(); //İşlem katmanından Okuyucu classından nesne oluşturuluyor
            OleDbDataAdapter adtr = liste.okyccek(); //adtr ye okyccek den veriler aktarılıyor
            tablo.Clear();
            adtr.Fill(tablo);   //adtrye tablo aktarılıyor.
            dataGridView1.DataSource = tablo;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Tüm satırı seçsin diye yapıldı.
            this.dataGridView1.MultiSelect = false;//Tek bir sütundan seçilsin diye yapıldı

        }
        private void okyclisteform_Load(object sender, EventArgs e)
        {

            listele(); //Form loadında listele metodu çağırılıyor

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();       //data griddeki indislerden textlere veriler çekiliyor.
            txtdgmyeri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                IK.okuyucu ogr = new IK.okuyucu();             //iş katmanından nesne oluşturuluyor.
                ogr.tcno = dataGridView1.CurrentRow.Cells[0].Value.ToString();      //data gridden rcnoya veri gönderiliyor.
                ogr.okycsil(ogr);                                            //silme metoduna gönderiliyor.
                MessageBox.Show("Kayıt başarıyla silinmiştir.");
                txtadres.Text = "";                                 //sildikten sonra textler boşaltılıyor.
                txtadsoyad.Text = "";
                txtdgmyeri.Text = "";
                txttelefon.Text = "";
                txtmail.Text = "";
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir okuyucu seçiniz.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadres.Text != "" && txtadsoyad.Text != "" && txtdgmyeri.Text != "" && txttelefon.Text != "" && txtmail.Text != "")
            {                                           //if ile textlerin boş olmaması kontrol ediliyor.
                IK.okuyucu guncelle = new IK.okuyucu();         //iş katamnından nesne oluşturuluyor.
                guncelle.adsoyad = txtadsoyad.Text;             //değişkenlere textdeki veriler aktarılıyor.
                guncelle.dogumyeri = txtdgmyeri.Text;
                guncelle.telefon = txttelefon.Text;
                guncelle.mail = txtmail.Text;
                guncelle.adres = txtadres.Text;
                guncelle.tcno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                guncelle.okycguncelle(guncelle);
                MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz ve seçilen satırın tüm alanlarını doldurunuz.");
            }

            listele(); //listele metodu çağırıldı
        }

        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)
        {
            //Ana Sayfaya dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.ShowDialog();
        }

        
    }
}
