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
    public partial class okycliste : Form
    {
        public okycliste()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();      //tablo adında bir datatable oluşturuluyor.
        public void listele()
        {
            IK.okuyucu liste = new IK.okuyucu();                    //iş katmanından nesne oluşturuluyor

            OleDbDataAdapter adtr = liste.okyccek();                 //adtr ye okyccek den veriler aktarılıyor 
            tablo.Clear();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;                           //adtrye tablo aktarılıyor.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Tüm satırı seçsin diye yapıldı.

            dataGridView1.MultiSelect = false;//Tek bir sütundan seçilsin yapıldı

        }

        private void okycliste_Load(object sender, EventArgs e)
        {
            listele();//Form loadında listele metodu çağırılıyor
        }



        private void BtnOkuyucuCikis_Click(object sender, EventArgs e)
        {
            //Ana Sayfaya dönmek için
            this.Close();
            anaform ana = new anaform();
            ana.Show();
        }



    }
}
