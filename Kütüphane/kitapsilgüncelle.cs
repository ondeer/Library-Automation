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
using IK;               //İşlem katmanına erişmek için

namespace Kütüphane
{
    public partial class kitapsilgüncelle : Form
    {
        public kitapsilgüncelle()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        public void ktplistele()                    //diğer listeleme işlemleri ile aynı uygulamalar yapılıyor.
        {
            IK.kitap liste = new IK.kitap();   //kitap classından nesne oluşturuluyor
            OleDbDataAdapter adtr = liste.kitapcek(); //adtr ye kitapcek den veriler aktarılıyor
            tablo.Clear();
            adtr.Fill(tablo);   //adtrye tablo aktarılıyor.
            dataGridView1.DataSource = tablo;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Tüm satırı seçsin diye yapıldı.
            dataGridView1.MultiSelect = false; //Tek bir sütundan seçilsin yapıldı

        }
        private void kitapsilgüncelle_Load(object sender, EventArgs e)
        {
            ktplistele(); //Form loadında kitaplistele metodu çağırılıyor
        }

        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)
        {
            //Anaforma dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.ShowDialog();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            IK.kitap kitap = new IK.kitap();
            kitap.barkod = dataGridView1.CurrentRow.Cells[0].Value.ToString();       //iş katmanından nesne oluşturlup barkod değişkenine 0. indis gönderiliyor
            kitap.kitapsil(kitap);                                                   //alınan veriler kitapsil metoduna gönderiliyor.
            MessageBox.Show("Kayıt başarıyla silinmiştir.");
            ktplistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();       //data griddeki bilgiler textlere çekiliyor.
            txttür.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtyayınevi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsayfa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Güncelle butonu için
            if (txtkitapad.Text != "" && txtsayfa.Text != "" && txttür.Text != "" && txtyayınevi.Text != "" && txtyazar.Text != "")
            //textlerin boş olup olmamaması kontrol eiliyor.
            {
                IK.kitap ktp = new IK.kitap();          //iş katmanından nesne oluşturuluyor.
                ktp.kitapad = txtkitapad.Text;            //değişkenlere textdeki veriler aktarılıyor.
                ktp.kitaptur = txttür.Text;
                ktp.kitapyayınevi = txtyayınevi.Text;
                ktp.kitapyazar = txtyazar.Text;
                ktp.sayfasayi = txtsayfa.Text;
                ktp.basımtarih = dateTimePicker1.Text;
                ktp.barkod = dataGridView1.CurrentRow.Cells[0].Value.ToString();//barkod koduna 0. indis gönderiliyor.
                ktp.kitapguncelle(ktp);                                         //veriler kitap güncelleme metoduna gönderiliyor.
                MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
                ktplistele();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz ve seçilen satırın tüm alanlarını doldurunuz.");
            }
        }
    }
}

