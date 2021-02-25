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
    public partial class okyckayıtform : Form
    {
        public okyckayıtform()
        {
            InitializeComponent();
        }

        private void BtnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text != "" && TxtAdres.Text != "" && TxtDogumYeri.Text != "" && TxtEposta.Text != "" && TxtTc.Text != "" && TxtTelefonNo.Text != "" && DateTimeDogumTarihi.Text != "")
            {                                                       //if ile textlerin boş olmadığı kontrol edildikten sonra 
                IK.okuyucu ogr = new IK.okuyucu();                  //iş katmanından nesne oluşturuluyor.
                ogr.tcno = TxtTc.Text; ;                            //değişkenlere textlerdeki veriler gönderiliyor.
                ogr.adsoyad = TxtAdSoyad.Text;
                ogr.dogumyeri = TxtDogumYeri.Text;
                ogr.Kayıttarihi = DateTimeDogumTarihi.Text;
                ogr.telefon = TxtTelefonNo.Text;
                ogr.adres = TxtAdres.Text;
                ogr.mail = TxtEposta.Text;
                ogr.okycekle(ogr);                                       //ogrekle metoduna veriler gönderiliyor.
                TxtTc.Text = "";
                TxtAdSoyad.Text = "";
                TxtDogumYeri.Text = "";
                DateTimeDogumTarihi.Text = DateTime.Now.ToString();         //kayıt tarihine şu anki değer atanıyor ismi o şekilde kalmış.
                TxtTelefonNo.Text = "";
                TxtAdres.Text = "";
                TxtEposta.Text = "";
                MessageBox.Show("Kayıt başarıyla Eklenmiştir");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }


        }

        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)
        {
            //Ana Forma Dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }

        private void BtnOkuyucuGuncelle_Click(object sender, EventArgs e)
        {
            //Güncelle-silme formuna yönlendiriliyor.
            this.Hide();
            okycsilgün dgs = new okycsilgün();
            dgs.Show();
        }
    }
}
