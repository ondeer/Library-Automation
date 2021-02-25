using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; //veritabanı işlemleri için
using VK;               // Veri Katmanı kullanmak için
namespace IK
{
    public class kitap
    {
        public string barkod;           //Sunum katmanından gelecek olan veriler için değişkenler tanımlandı.
        public string kitapad;
        public string kitaptur;
        public string kitapyazar;
        public string kitapyayınevi;
        public string basımtarih;
        public string sayfasayi;

        VK.baglanti baglantiyap = new VK.baglanti(); //Veri katmanındaki metod ile bağlantı yapılması için nesne oluşturuldu.

        public void kitapekle(kitap bilgi) //Kitap ekleme formu için kitap ekleme metodu yapıldı
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("insert into KitapTable (BarkodNo,KitapAdi,KitapTuru,KitapYazari,KitapYayinEvi,BasimTarihi,SayfaSayisi) values (@barkod, @kitapad, @kitaptür,@kitapyazar,@kitapyayın,@basım,@sayfa)");
            cmd.Parameters.AddWithValue("@barkod", bilgi.barkod);
            cmd.Parameters.AddWithValue("@kitapad", bilgi.kitapad);
            cmd.Parameters.AddWithValue("@kitaptür", bilgi.kitaptur);
            cmd.Parameters.AddWithValue("@kitapyazar", bilgi.kitapyazar);
            cmd.Parameters.AddWithValue("@kitapyayın", bilgi.kitapyayınevi);
            cmd.Parameters.AddWithValue("@basım", bilgi.basımtarih);
            cmd.Parameters.AddWithValue("@sayfa", bilgi.sayfasayi);



            cmd.ExecuteNonQuery();                  //Kitap ekleme işlemi için insert komutu ile ekleme işlemi yapılıyor@ li ifadelere değişkenler aktarılıyor.
            baglantiyap.Baglantikapa();
        }

        public OleDbDataAdapter kitapcek()
        {
            VK.baglanti baglantivecalistir = new VK.baglanti(); //verikatmanından nesne oluşturuluyor.


            OleDbDataAdapter adt = baglantivecalistir.adabter("Select BarkodNo,KitapAdi,KitapTuru,KitapYazari,KitapYayinEvi,BasimTarihi,SayfaSayisi From KitapTable");
            return adt;         //Kitap listeleme işlemi için kitap tablosundan veriler çekiliyor.

        }

        public void kitapguncelle(kitap bilgi)
        {
            OleDbCommand cmd = baglantiyap.SorguOlustur("update KitapTable set KitapAdi=@kitapad,KitapTuru=@tür,KitapYazari=@yazar,KitapYayinEvi=@yayınevi,SayfaSayisi=@sayfa,BasimTarihi=@basım where BarkodNo=@barkod ");
            cmd.Parameters.AddWithValue("@kitapad", bilgi.kitapad);
            cmd.Parameters.AddWithValue("@tür", bilgi.kitaptur);
            cmd.Parameters.AddWithValue("@yazar", bilgi.kitapyazar);
            cmd.Parameters.AddWithValue("@yayınevi", bilgi.kitapyayınevi);
            cmd.Parameters.AddWithValue("@sayfa", bilgi.sayfasayi);
            cmd.Parameters.AddWithValue("@basım", bilgi.basımtarih);
            cmd.Parameters.AddWithValue("@barkod", bilgi.barkod);

            cmd.ExecuteNonQuery();                      //kitap güncelleme işlemi için gerekli update işlemi yazılıyor ve @ li ifadelere değişkenler aktarılıyor.
            baglantiyap.Baglantikapa();


        }

        public void kitapsil(kitap silinecek)
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("delete from KitapTable where BarkodNo='" + silinecek.barkod + "'");

            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();  //kitap silme işlemi için delete komutu ile gelen barkod numarasına göre silme işlemi yapılıyor

        }


        public OleDbCommand tumkitapsayi()
        {
            baglantiyap.BaglantiAc();
            OleDbCommand cmd = baglantiyap.SorguOlustur("Select count(*) From KitapTable");
            return cmd;         //zedgraph için tüm kitapların sayısı sayılıyor.



        }
    }
}

