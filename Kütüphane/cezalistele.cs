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
    public partial class cezalistele : Form
    {
        public cezalistele()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();          //tablo adında datatable oluşturuldu.
        public void listele()
        {   //listele adında bir metod oluşturuldu.

            IK.okuyucu liste = new IK.okuyucu();            //iş katmanından bir nesne oluşturulup dataadabter ile dataadabter şeklinde dönen metoddan adtr oluşturuldu
            OleDbDataAdapter adtr = liste.okyccezacek();     //daha sonra adabter içine tablo atıldı ve datagridviewin data sourcesine aktarıldı
            tablo.Clear();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      //tüm satırı seçsin diye yapıldı.

            dataGridView1.MultiSelect = false;              //tek bir sütundan seçilsin diye yapıldı

        }
        private void cezalistele_Load(object sender, EventArgs e)
        {
            listele();  //listeleme metodu çağırıldı
        }

        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)  
        {
            //Anaforma dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cezayı öde butonu için
            IK.okuyucu czöde = new IK.okuyucu();                                    //iş katmanından nesne oluşturulup oradaki tcnoya
            czöde.tcno = dataGridView1.CurrentRow.Cells[0].Value.ToString();         //datagriddeki 0. indisteki değer atandı ve ordaki cezasilme mtoduna aktarıldı.
            czöde.okyccezasil(czöde);
            MessageBox.Show("Ceza tamamen ödenmiştir.");
            listele();

        }

       
    }
}
