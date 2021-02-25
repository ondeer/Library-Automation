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
    public partial class teslimal : Form
    {
        public teslimal()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        public void listele()
        {              //Diğer listeleme işlemleri ile aynı işlemler yapılıyor.

            IK.emanet emanetliste = new IK.emanet();
            OleDbDataAdapter adtr = emanetliste.emanetcek();
            tablo.Clear();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      //tüm satırı seçsin diye yapıldı.

            dataGridView1.MultiSelect = false;              //tek bir sütundan seçilsin diye yapıldı
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // DataGrid in satırları saydırılıyor
            {
                DataGridViewCellStyle CellColor = new DataGridViewCellStyle(); // Renklendirmek için bunu kullanıyoruz.


                DateTime Tarih; // Tarih değişkeni oluşturduk.
                Tarih = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value); // DataGrid deki Tarih değişkenini Tarih değişkenimize aktardık.

                DateTime Suan = Convert.ToDateTime(DateTime.Now.ToLongDateString()); // Şuanki saati çekiyorz.


                TimeSpan GunFarki = Suan.Subtract(Tarih); // Suanki zaman ile veritabanındaki kayıt zamanı karşılaştırılıyor
                // Bu karşılaştırma sonucuna görede renklendirme işlemi yapılıyr.
                //Alttaki kodda integer türüne çevirme işlemi yapılmıştır.
                int Fark = int.Parse(GunFarki.Days.ToString());

                string kar = dataGridView1.Rows[i].Cells[7].Value.ToString();
                if (kar != "Teslim Edildi") // DataGrid in Emanet Durumu hücresi Teslim Edilmedi ise
                { // aşağıdaki kod blokları çalışıyor
                    if (Fark < -2)
                    { // Günü daha çok varsa =) yeşil yaptık.
                        CellColor.BackColor = Color.Green;
                        CellColor.ForeColor = Color.White;
                        dataGridView1.Rows[i].DefaultCellStyle = CellColor;
                    }
                    else if (Fark <= 2)
                    { // Güne iki gün kalmışsa sarı renk yaptık
                        CellColor.BackColor = Color.Yellow;
                        CellColor.ForeColor = Color.Black;
                        dataGridView1.Rows[i].DefaultCellStyle = CellColor;
                    }
                    if (Fark > 0)
                    {

                        // Eğer günü geçmişse DataGrid de kırmızı renk ile boyanıyor satır
                        CellColor.BackColor = Color.Red;
                        CellColor.ForeColor = Color.White;
                        dataGridView1.Rows[i].DefaultCellStyle = CellColor;


                    }
                }
                else
                {
                    // Eğer Teslim edildi ise direk yeşil renk yapımı sağlanıyor.
                    CellColor.BackColor = Color.Green;
                    CellColor.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle = CellColor;
                }
            }

        }


        public void cezahesapla()
        {
                DateTime Tarih; // Tarih değişkeni oluşturduk.

                Tarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value); // DataGrid deki Tarih değişkenini Tarih değişkenimize aktardık.

                DateTime Suan = Convert.ToDateTime(DateTime.Now.ToLongDateString()); // Şuanki saati çekiyorz.

                TimeSpan GunFarki = Suan.Subtract(Tarih); // Suanki zaman ile veritabanındaki kayıt zamanı karşılaştırılıyor
                
                //Alttaki kodda integer türüne çevirme işlemi yapılmıştır.

                 int Fark = int.Parse(GunFarki.Days.ToString());

                 if (Fark > 0)
                    {
                        IK.okuyucu borc = new IK.okuyucu();                                  //iş katmanından nesne oluşturuluyor.
                        borc.tcno = dataGridView1.CurrentRow.Cells[1].Value.ToString();      //data gridden veriler değişkenlere aktarılıyor.
                        borc.adsoyad = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        borc.ceza = Fark;
                        borc.cezaa(borc);                                                     //veriler cezaa metoduna aktarılıyor.
                    }
         }


        private void Emanetlistele_Load(object sender, EventArgs e)
        {
            listele(); //Form loadında listele metodu çağırılıyor
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void btnteslim_Click(object sender, EventArgs e)
        {

            
            IK.emanet teslimi = new IK.emanet();                //iş katmanından nesne oluşturuluyor.
            teslimi.tcno = dataGridView1.CurrentRow.Cells[1].Value.ToString();           //data gridden değişkenlere veri aktarılıyor.
            teslimi.kitapad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            teslimi.teslim = DateTime.Now.ToLongDateString();
            teslimi.emanetdurumu(teslimi);            //emanet durumuna veriler aktarılıyor.
            MessageBox.Show("Kitap teslim alındı");
            cezahesapla();//cezahesapla metodu çağırılıyor
            listele();//listele metodu çağırılıyor
            




        }

        private void BtnKitapCikis_Click(object sender, EventArgs e)
        {
            //Anaforma dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }

        
    }
}
