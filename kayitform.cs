using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ziyaretcikayit
{
    public partial class kayitform : Form

    {


        //ziyaretci sınıfımızı belirtiyoruz

        ziyaretci ziyaretci = new ziyaretci();
        public kayitform()
        {
            InitializeComponent();
            dgwZiyaretci.DataSource = ziyaretci.Getziyaretci();
            dgwZiyaretci.PerformLayout();


        }

        //uygulama ilk açıldığında textbox değerlerini boş atıyoruz
        private void ClearControls()
        {

            txtplaka.Text = "";
            txtadsoyad.Text = "";
            txttc.Text = "";
            txtfirmaad.Text = "";
            txtziyaretbirim.Text = "";
            txtgiris.Text = "";
            dateTimePicker1.Text = "";
            txtcikis.Text = "";
            txtaciklama.Text = "";
        }

        //ekle butonu fonksiyonları
        private void btnEkle_Click(object sender, EventArgs e)
        {

            ziyaretci.plaka = txtplaka.Text;
            ziyaretci.adsoyad = txtadsoyad.Text;
            ziyaretci.tcno = txttc.Text;
            ziyaretci.firmaad = txtfirmaad.Text;
            ziyaretci.birim = txtziyaretbirim.Text;
            ziyaretci.giris = txtgiris.Text;
            ziyaretci.tarih = Convert.ToDateTime(dateTimePicker1.Text);
            ziyaretci.cikis = (txtcikis.Text);
            ziyaretci.aciklama = txtaciklama.Text;

            var kontrol = ziyaretci.Insertziyaretci(ziyaretci);
            dgwZiyaretci.DataSource = ziyaretci.Getziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi başarıyla eklendi.");

            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

        }



        //güncelle butonu fonksiyonları
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            ziyaretci.id = Convert.ToInt32(txtid.Text);
            ziyaretci.plaka = txtplaka.Text;
            ziyaretci.adsoyad = txtadsoyad.Text;
            ziyaretci.tcno = txttc.Text;
            ziyaretci.firmaad = txtfirmaad.Text;
            ziyaretci.birim = txtziyaretbirim.Text;
            ziyaretci.giris = Convert.ToString(txtgiris.Text);
            ziyaretci.tarih = Convert.ToDateTime(dateTimePicker1.Text);
            ziyaretci.cikis = Convert.ToString(txtcikis.Text);
            ziyaretci.aciklama = txtaciklama.Text;

            var kontrol = ziyaretci.Updateziyaretci(ziyaretci);
            dgwZiyaretci.DataSource = ziyaretci.Getziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi bilgileri başarıyla güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");



        }
        //sil butonu fonksiyonları
        private void btnSil_Click(object sender, EventArgs e)
        {




            ziyaretci.id = Convert.ToInt32(txtid.Text);


            var kontrol = ziyaretci.Deleteziyaretci(ziyaretci);
            dgwZiyaretci.DataSource = ziyaretci.Getziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi başarıyla silindi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");



        }
        //temizle butonu fonksiyonları. textboxlardaki değerleri temizliyor
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearControls();





        }






        //datagridview üzerindeki verilere tıkladığımızda değerlerin textboxa yazdırılmasını sağlıyoruz.
        private void dgwZiyaretci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgwZiyaretci.CurrentRow.Cells[0].Value.ToString();
            txtplaka.Text = dgwZiyaretci.CurrentRow.Cells[1].Value.ToString();
            txtadsoyad.Text = dgwZiyaretci.CurrentRow.Cells[2].Value.ToString();
            txttc.Text = dgwZiyaretci.CurrentRow.Cells[3].Value.ToString();
            txtfirmaad.Text = dgwZiyaretci.CurrentRow.Cells[4].Value.ToString();
            txtziyaretbirim.Text = dgwZiyaretci.CurrentRow.Cells[5].Value.ToString();
            txtgiris.Text = dgwZiyaretci.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text = dgwZiyaretci.CurrentRow.Cells[8].Value.ToString();
            txtcikis.Text = dgwZiyaretci.CurrentRow.Cells[7].Value.ToString();
            txtaciklama.Text = dgwZiyaretci.CurrentRow.Cells[9].Value.ToString();

        }

        //form üzerindeki tarih ve saat labelları
        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToShortTimeString();

        }
        //excele aktar butonu fonksiyonlarımız
        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgwZiyaretci.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dgwZiyaretci.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgwZiyaretci.Rows.Count; i++)
            {
                for (int j = 0; j < dgwZiyaretci.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = dgwZiyaretci.Rows[i].Cells[j].Value.ToString();
                }
            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }

        //form yüklenirken form üzerindeki timerı başlatıyoruz
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void dbZiyaretciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        // mevcut verilerde plaka arama fonksiyonumuz
        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

            (dgwZiyaretci.DataSource as DataTable).DefaultView.RowFilter = string.Format("plaka LIKE '%{0}%'", searchtextBox.Text);

        }
        //ad soyad arama fonksiyonumuz
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgwZiyaretci.DataSource as DataTable).DefaultView.RowFilter = string.Format("adsoyad LIKE '%{0}%'", textBox1.Text);
        }
        //tarih filtreleme butonumuz
        private void button2_Click(object sender, EventArgs e)
        {
            (dgwZiyaretci.DataSource as DataTable).DefaultView.RowFilter = string.Format("tarih > '{0}' AND tarih <= '{1}'", dateTimePicker2.Value, dateTimePicker3.Value);

        }
        //tarih filtrelendikten sonra bu filtreyi temizleyip tüm verileri önümüze getiren fonksiyon
        private void button3_Click(object sender, EventArgs e)
        {
            dgwZiyaretci.DataSource = ziyaretci.Getziyaretci();

        }


    }
}






