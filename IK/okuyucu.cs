using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//veritabanı işlemleri için
using VK;               // Veri Katmanı kullanmak için
namespace IK
{
    public class okuyucu
    {
        public string tcno;
        public string adsoyad;
        public string dogumyeri;
        public string Kayıttarihi;
        public string telefon;
        public string mail;
        public string adres;
        public int ceza;

        public int borc;
        VK.baglanti baglantiyap = new baglanti();  //veri katmanından nesne oluşturuluyor.

        public void okycekle(okuyucu bilgi) //Okuyucu ekleme formu için okuyucu ekleme metodu yapıldı
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("insert into OkuyucuTable (TcNo,AdSoyad,DogumYeri,KayıtTarihi,TelefonNo,MailAdresi,Ceza,Adresi) values (@tcno, @adsoyad, @dogumyeri,@dogumtarihi,@telefon,@mail,@ceza,@adres)");
            cmd.Parameters.AddWithValue("@tcno", bilgi.tcno);
            cmd.Parameters.AddWithValue("@adsoyad", bilgi.adsoyad);
            cmd.Parameters.AddWithValue("@dogumyeri", bilgi.dogumyeri);
            cmd.Parameters.AddWithValue("@dogumtarihi", bilgi.Kayıttarihi);
            cmd.Parameters.AddWithValue("@telefon", bilgi.telefon);
            cmd.Parameters.AddWithValue("@mail", bilgi.mail);       //okuyucu ekleme işlemi için @'li ifadelere değişkenler aktarılıyor ve insert komutu ile veritabanına ekleme işlemi yapılıyor
            cmd.Parameters.AddWithValue("@ceza", 0);
            cmd.Parameters.AddWithValue("@adres", bilgi.adres);
            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();
        }
        public void okycsil(okuyucu silinecek)
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("delete from OkuyucuTable where TcNo='" + silinecek.tcno + "'");

            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();     //Burada okuyucu silme işlemi için koşul olark direk değişken veriliyor ve silme komutu gerçekleşiyor.

        }

        public OleDbDataAdapter okyccek()
        {


            OleDbDataAdapter adt = baglantiyap.adabter("Select * From OkuyucuTable");
            return adt;     //okuyucuları listelemek için select komutu işlemi yapılıyor.

        }

        public void okycguncelle(okuyucu bilgi)
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("update OkuyucuTable set AdSoyad=@adsoyad,DogumYeri=@dgmyeri,TelefonNo=@tel,MailAdresi=@mail,Adresi=@adres where TcNo=@tc ");
            cmd.Parameters.AddWithValue("@adsoyad", bilgi.adsoyad);
            cmd.Parameters.AddWithValue("@dgmyeri", bilgi.dogumyeri);
            cmd.Parameters.AddWithValue("@tel", bilgi.telefon);
            cmd.Parameters.AddWithValue("@mail", bilgi.mail);           //yine verikatmanından çektiğimiz sorguyap metoduna sorgumuzu yazıp gerkli koşula göre kullanıcı verisini güncelliyoruz
            cmd.Parameters.AddWithValue("@adres", bilgi.adres);         //@'li ifadeye değişkenleri aktarıyoruz.
            cmd.Parameters.AddWithValue("@tc", bilgi.tcno);
            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();

        }

        public void cezaa(okuyucu bilgi)
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("select Ceza from OkuyucuTable where TcNo=@tc and AdSoyad=@ad");
            cmd.Parameters.AddWithValue("@tc", bilgi.tcno);
            cmd.Parameters.AddWithValue("@ad", bilgi.adsoyad);//gerekli koşullara göre  ceza verisini çekiyoruz

            OleDbDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                borc = Convert.ToInt32(dr["Ceza"]);                 //datareader yapıp readerdeki ceza verisini borc olarak inte çeviriyoruz
            }
            baglantiyap.Baglantikapa();
            bilgi.ceza += borc;                                        //ceza değişkenine inte çevirdiğimiz borc değişkenini arttırıp aktarıyoruz

            OleDbCommand komut = baglantiyap.SorguOlustur("update OkuyucuTable set Ceza=@borc where TcNo=@tc and AdSoyad=@ad");
            komut.Parameters.AddWithValue("@borc", bilgi.ceza);
            komut.Parameters.AddWithValue("@tc", bilgi.tcno);
            komut.Parameters.AddWithValue("@borc", bilgi.adsoyad);          //burda yine verilen koşullara göre güncelleme yapıyoruz ceza verisine yukarda borcu aktardığımız ceza değişkenini veriyoruz.
            komut.ExecuteNonQuery();
            baglantiyap.Baglantikapa();

        }


        public OleDbDataAdapter okyccezacek()
        {


            OleDbDataAdapter adt = baglantiyap.adabter("Select TcNo,AdSoyad,Ceza From OkuyucuTable");
            return adt;         //Ceza listeleme işlemi için okuyucu tablosundan gerekli bilgiler çekiliyor.

        }

        public void okyccezasil(okuyucu bilgi)
        {

            OleDbCommand cmd = baglantiyap.SorguOlustur("update OkuyucuTable set Ceza='0'  where TcNo=@tc");
            cmd.Parameters.AddWithValue("@tc", bilgi.tcno);
            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();         //ceza silme işlemi için gerekli koşul sağlandığında cezanın 0 olarak değiştirilmesi sağlanıyor.

        }
    }
}
