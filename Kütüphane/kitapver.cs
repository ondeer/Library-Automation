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
using IK;           //İşlem katmanına erişmek için
namespace Kütüphane
{
    public partial class kitapver : Form
    {
        public kitapver()
        {
            InitializeComponent();
        }
        DataTable ogrtablo = new DataTable();//ogrtablo adında bir datatable oluşturuluyor.
        DataTable kittablo = new DataTable();//kittablo adında bir datatable oluşturuluyor
        private void emanetver_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = false;        //başlangıç tarihi olduğu için dokunulmaz yaptım.
            IK.okuyucu liste = new IK.okuyucu();        //iş katmanından okuyucu classından nesne oluşturuluyor
            OleDbDataAdapter adtr = liste.okyccek();//adtr ye kitapçekteki veriler aktarılıyor
            ogrtablo.Clear();
            adtr.Fill(ogrtablo);   //adtr ye ogrtablodaki veriler aktarılıyor
            dataGridView1.DataSource = ogrtablo;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      //tüm satırı seçsin diye yapıldı.

            dataGridView1.MultiSelect = false;              //Tek bir sütundan seçilsin diye yapıldı

            IK.kitap kitliste = new IK.kitap();         //Diğer listeleme işlemeleri ile aynı işlemler yapılıyor.
            OleDbDataAdapter adt = kitliste.kitapcek();
            kittablo.Clear();
            adt.Fill(kittablo);
            dataGridView2.DataSource = kittablo;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      //Tüm satırı seçsin diye yapıldı.

            dataGridView2.MultiSelect = false;              //Tek bir sütundan seçilsin diye yapıldı


        }

        private void button1_Click(object sender, EventArgs e)
        {
            IK.emanet emanet = new IK.emanet();                         //iş katmanından nesne oluşturuluyor.
            emanet.tcno = dataGridView1.CurrentRow.Cells[0].Value.ToString();   //değişkenlere data griddeki indislerden veri gönderiliyor.
            emanet.adsoyad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            emanet.barkodno = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            emanet.kitapad = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            emanet.baslangıc = dateTimePicker2.Text;
            emanet.bitis = dateTimePicker1.Text;


            emanet.emanetekle(emanet);                           //veriler emanetekle metoduna gönderiliyor.
            MessageBox.Show("Kitap verme işlemi başarıyla gerçekleşmiştir.");


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnKitapCikis_Click(object sender, EventArgs e)
        {
            //Anaforma dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
