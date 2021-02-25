using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //veritabanı işlemleri için 
using ZedGraph;     //grafik için eklendi
using IK;
namespace Kütüphane
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CreateGraph(zg1);
        }

        private void button1_Click(object sender, EventArgs e)  //bütün butonlar için şu anki form gizlenip gerkli formdan nesne oluşturulup gösterilmiştir.
        {
            this.Hide();
            okyckayıtform OgrenciKaydet = new okyckayıtform();
            OgrenciKaydet.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            okycliste Ogrenciliste = new okycliste();
            Ogrenciliste.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitapver emanet = new kitapver();
            emanet.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            teslimal emanetliste = new teslimal();
            emanetliste.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitapekle ktp = new kitapekle();
            ktp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitaplistele ktp = new kitaplistele();
            ktp.Show();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            cezalistele cz = new cezalistele();
            cz.Show();
        }

        private void CreateGraph(ZedGraphControl zg1)
        {
            IK.kitap ktp = new IK.kitap();
            IK.emanet emnt = new IK.emanet();
            ktp.tumkitapsayi();
            OleDbCommand komut = ktp.tumkitapsayi();
            double KitapSayisi = Convert.ToDouble(komut.ExecuteScalar());


            // Tesslim edilmeyen tüm kitapların sayısı çekiliyor

            OleDbCommand KomutTeslimEdilmedi = emnt.teslimedilmedi();
            double TeslimEdilmediSayisi = Convert.ToDouble(KomutTeslimEdilmedi.ExecuteScalar());

            // Teslim Edilenlerin sayısı sorgu cümleciği le çekiliyor

            OleDbCommand KomutTeslimEdildi = emnt.teslimedildi();

            double TeslimEdildiSayisi = Convert.ToDouble(KomutTeslimEdildi.ExecuteScalar());

            GraphPane myPane = zg1.GraphPane;
            myPane.Title = "Kütüphane Kitap Sayısı"; // Zedgrap ın Ana başlığını güncellendi
            myPane.XAxis.Title = "Kitaplar"; // X Ekseni Başlığı
            myPane.YAxis.Title = "Kitap Sayısı"; // Y Ekseni Başılığı
            string[] Isimler = { "Tüm Kitaplar", "Teslim Edilmeyenler", "Teslim Edilenler" }; // Y Ekseni için değişkenler tanımlandı.

            double[] EkranaCiz = { KitapSayisi, 0, 0 }; // ZedGraph değeri buradan çekiliyor
            double[] TeslimEdilmeyen = { 0, TeslimEdilmediSayisi, 0 };
            double[] TeslimEdilen = { 0, 0, TeslimEdildiSayisi };


            // BarItem myBar = myPane.AddBar(" Toplam Kitap Sayısı ", null, EkranaCiz, Color.Yellow);
            //myBar.Bar.Fill = new Fill(Color.Red, Color.Red,Color.Red);
            BarItem myBar = myPane.AddBar(" Tüm Kitaplar", null, EkranaCiz, Color.Black);
            myBar = myPane.AddBar(" Teslim Edilmeyen ", null, TeslimEdilmeyen, Color.Red);
            myBar = myPane.AddBar(" Teslim Edilen ", null, TeslimEdilen, Color.Green); // Sütunların üstündeki alanlara yazı yazılıp renkleri belirlendi

            myBar.Bar.Fill = new Fill(Color.Black, Color.Black, Color.Black); // Sütunları Renklendirme işlemi yapılıyor.
            myBar.Bar.Fill = new Fill(Color.Red, Color.Red, Color.Red);
            myBar.Bar.Fill = new Fill(Color.Green, Color.Green, Color.Green);

            myPane.Legend.FontSpec.Size = 16;   // Grafik üstündeki Yazının boyutunu belirliyor.

            myPane.XAxis.IsTicsBetweenLabels = true; // Bunu true yapınca ayıraçlar yapılıyor aralarına

            myPane.XAxis.TextLabels = Isimler; // Eksenlerin (Y) değişken tipleri belirleniyor
            myPane.XAxis.Type = AxisType.Text; // Y Değerlerinin Yazı şeklinde olmasını sağlıyor





            zg1.AxisChange();
        }

        private void BtnKitapCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();         //programdan çıkış yapmak için 
        }

        

    }
}

