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
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            if (TxtBarkodNo.Text != "" && TxtKitapAdi.Text != "" && TxtKitapTuru.Text != "" && TxtKitapYazari.Text != "" && TxtSayfaSayisi.Text != "" && TxtYayinEvi.Text != "")
            {
                IK.kitap kitap = new IK.kitap();             //iş katmanından nesne oluşturuluyor.
                kitap.barkod = TxtBarkodNo.Text;            //bir if kontrolü ile textlerin boş olup olmadığı kontrol edildikten sonra
                kitap.kitapad = TxtKitapAdi.Text;           //textlerde yazan veriler iş katmanındaki değişkenlere aktarılıyor.
                kitap.basımtarih = DateTimeBasimTarihi.Text;
                kitap.kitaptur = TxtKitapTuru.Text;
                kitap.kitapyayınevi = TxtYayinEvi.Text;
                kitap.kitapyazar = TxtKitapYazari.Text;
                kitap.sayfasayi = TxtSayfaSayisi.Text;

                kitap.kitapekle(kitap);                  //kitap ekle metodu gönderiliyor.altta ise textboclar boşaltılıyor.
                MessageBox.Show("Kitap kayıt başarıyla gerçekleşmiştir.");
                TxtBarkodNo.Text = "";
                TxtKitapAdi.Text = "";
                DateTimeBasimTarihi.Text = "";
                TxtKitapTuru.Text = "";
                TxtYayinEvi.Text = "";
                TxtKitapYazari.Text = "";
                TxtSayfaSayisi.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
            }

        }

        private void BtnKitapCikis_Click(object sender, EventArgs e)
        {
            //Ana sayfaya dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }

        private void BtnKitapGuncelle_Click(object sender, EventArgs e)//güncelle-silme formuna yönlendiriliyor.
        {
            this.Close();
            kitapsilgüncelle ktp = new kitapsilgüncelle();
            ktp.Show();
        }


    }
}
