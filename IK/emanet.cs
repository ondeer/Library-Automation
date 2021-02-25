using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; //Veritabanı işlemleri için
using VK;                // Veri Katmanı kullanmak için
namespace IK
{
    public class emanet
    {
        public string adsoyad;      //Sunum katmanından gelecek olan veriler için değişkenler tanımlandı.
        public string tcno;
        public string barkodno;
        public string kitapad;
        public string baslangıc;
        public string bitis;
        public string teslim;
        public string emanetdurum = "Teslim Edilmedi";

        VK.baglanti baglantiyap = new VK.baglanti();   //Veri katmanındaki metod ile bağlantı yapılması için nesne oluşturuldu.

        public void emanetekle(emanet bilgi)          //emanet ekleme formu için emanet ekleme metodu yapıldı
        {
            
            OleDbCommand cmd = baglantiyap.SorguOlustur("INSERT INTO EmanetTable(AdSoyad,TcKimlikNo,BarkodNo,KitapAdi,BaslangicTarihi,BitisTarihi,EmanetDurumu) values (@AdSoyad,@TcKimlikNo,@BarkodNo,@KitapAdi,@BaslangicTarihi,@BitisTarihi,@EmanetDurumu)");
            cmd.Parameters.AddWithValue("@AdSoyad", bilgi.adsoyad);  //gerekli sorgu yapma metodu çağırıldıktan sonra insert komutu ile ekleme yapıldı değişkenler sunum katmanından çağırılacağı için değişkenler verildi.
            cmd.Parameters.AddWithValue("@TcKimlikNo", bilgi.tcno);
            cmd.Parameters.AddWithValue("@BarkodNo", bilgi.barkodno);
            cmd.Parameters.AddWithValue("@KitapAdi", bilgi.kitapad);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", bilgi.baslangıc);
            cmd.Parameters.AddWithValue("@BitisTarihi", bilgi.bitis);

            cmd.Parameters.AddWithValue("@EmanetDurumu", bilgi.emanetdurum);

            cmd.ExecuteNonQuery();              //komut işletildikten sonra kapa metodu ile kapatıldı.
            baglantiyap.Baglantikapa();
        }
        public OleDbDataAdapter emanetcek()  //Emanet listelemek için dataadabter şeklinde dönüş tipi olan bir metod tanımlandı  
        {


            OleDbDataAdapter adt = baglantiyap.adabter("Select * From EmanetTable");//gerkeli select komutu uygulandı.
            return adt;

        }
        public void emanetdurumu(emanet bilgi)//teslim edilme durumu için emanet durumu güncellendi
        {
            
            baglantiyap.BaglantiAc();
            OleDbCommand cmd = baglantiyap.SorguOlustur("UPDATE EmanetTable SET  EmanetDurumu='Teslim Edildi',TeslimTarihi='" + bilgi.teslim + "' WHERE TcKimlikNo=@tc and KitapAdi=@KitapAdi");
            cmd.Parameters.AddWithValue("@tc", bilgi.tcno);
            cmd.Parameters.AddWithValue("@KitapAdi", bilgi.kitapad);//update komutu istenilen koşulları yerine getirdikten sonra emanet durumunu teslim edildi olarak değiştirecek
           

            cmd.ExecuteNonQuery();
            baglantiyap.Baglantikapa();
        }

        public OleDbCommand teslimedilmedi()
        {
            baglantiyap.BaglantiAc();
            OleDbCommand cmd = baglantiyap.SorguOlustur("Select count(*) From EmanetTable where EmanetDurumu Like '" + "Teslim Edilmedi" + "'");
            return cmd;                 // bu metod zedgraph için teslim edilmeyen kitapların sayısını sayıyor.


        }
        public OleDbCommand teslimedildi()
        {
            baglantiyap.BaglantiAc();
            OleDbCommand cmd = baglantiyap.SorguOlustur("Select count(*) From EmanetTable where EmanetDurumu Like '" + "Teslim Edildi" + "'");
            return cmd;                 // bu metod zedgraph için teslim edilen kitapların sayısını sayıyor.
        }
    }
}
