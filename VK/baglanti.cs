using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//veritabanı işlemleri için
namespace VK
{
    public class baglanti
    {

        public OleDbConnection BaglantiAc() //Programın veritabanı ile bağlantı yapıldı.Oledbconnection şeklinde dönüş yapıldı.
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KutuphaneDB.mdb");
            baglanti.Open();
            return baglanti;
        }
        public OleDbConnection Baglantikapa()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KutuphaneDB.mdb");
            baglanti.Close();
            return baglanti;
        }//Aynı şekilde veritabanı ile arasındaki bağlantı kapatıldı.



        public OleDbCommand SorguOlustur(string sorgu)
        {
            OleDbCommand cmd = new OleDbCommand(sorgu, BaglantiAc());
            return cmd;
        }         //Herhangi bir sorgu yapılacağı zaman kullanılacak metod tanımlandı oledbcommand şeklinde dönüş yapıldı.
        public OleDbDataAdapter adabter(string sorgu)
        {
            OleDbDataAdapter adt = new OleDbDataAdapter(sorgu, BaglantiAc());
            return adt;
        }        //herhangi bir listeleme için oledbdataadabter şeklinde dönüşü olan bir metod tanımlandı.


    }
}

