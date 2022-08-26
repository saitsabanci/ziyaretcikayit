using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ziyaretcikayit
{
    public partial class gunubirlikform : Form
    {



        gunubirlikziyaretci gunubirlikziyaretci = new gunubirlikziyaretci();
        public gunubirlikform()
        {
            InitializeComponent();
            dgwGunubirlik.DataSource = gunubirlikziyaretci.Getgunubirlikziyaretci();
            dgwGunubirlik.PerformLayout();
        }
        //textboxların ilk durumunu belirten kısım

        private void ClearControls()
        {
            textBoxplaka.Text = "";
            textBoxadsoyad.Text = "";
            textBoxtcno.Text = "";
            maskedTextBoxgiris.Text = "";
            maskedTextBoxcikis.Text = "";
            dateTimePicker1.Text = "";
            textBoxaciklama.Text = "";



        }



        private void gunubirlikform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gunubirlikkayitDataSet.dbGunubirlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbGunubirlikTableAdapter.Fill(this.gunubirlikkayitDataSet.dbGunubirlik);


        }
        //gunubirlikform'daki ekle butonunun fonksiyonları
        private void buttonekle_Click(object sender, EventArgs e)
        {
            gunubirlikziyaretci.plaka = textBoxplaka.Text;
            gunubirlikziyaretci.adsoyad = textBoxadsoyad.Text;
            gunubirlikziyaretci.tcno = textBoxtcno.Text;
            gunubirlikziyaretci.giris = maskedTextBoxgiris.Text;
            gunubirlikziyaretci.cikis = maskedTextBoxcikis.Text;
            gunubirlikziyaretci.tarih = Convert.ToDateTime(dateTimePicker1.Text);
            gunubirlikziyaretci.sabah = Convert.ToByte((bool)checkBoxsabah.Checked);
            gunubirlikziyaretci.ogle = Convert.ToByte((bool)checkBoxogle.Checked);
            gunubirlikziyaretci.aksam = Convert.ToByte(checkBoxaksam.Checked);
            gunubirlikziyaretci.gunubirlik = Convert.ToByte(checkBoxgunubirlik.Checked);
            gunubirlikziyaretci.aciklama = textBoxaciklama.Text;
            //veritabanı eşitleme
            var kontrol = gunubirlikziyaretci.Insertgunubirlikziyaretci(gunubirlikziyaretci);
            dgwGunubirlik.DataSource = gunubirlikziyaretci.Getgunubirlikziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi başarıyla eklendi.");

            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

        }
        // gunubirlikform'daki güncelle butonu fonksiyonları
        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            gunubirlikziyaretci.id = Convert.ToInt32(textBoxid.Text);
            gunubirlikziyaretci.plaka = textBoxplaka.Text;
            gunubirlikziyaretci.adsoyad = textBoxadsoyad.Text;
            gunubirlikziyaretci.tcno = textBoxtcno.Text;
            gunubirlikziyaretci.giris = Convert.ToString(maskedTextBoxgiris.Text);
            gunubirlikziyaretci.cikis = Convert.ToString(maskedTextBoxcikis.Text);
            gunubirlikziyaretci.tarih = Convert.ToDateTime(dateTimePicker1.Text);
            gunubirlikziyaretci.sabah = Convert.ToByte((bool)checkBoxsabah.Checked);
            gunubirlikziyaretci.ogle = Convert.ToByte((bool)checkBoxogle.Checked);
            gunubirlikziyaretci.aksam = Convert.ToByte(checkBoxaksam.Checked);
            gunubirlikziyaretci.gunubirlik = Convert.ToByte(checkBoxgunubirlik.Checked);
            gunubirlikziyaretci.aciklama = textBoxaciklama.Text;


            var kontrol = gunubirlikziyaretci.Updategunubirlikziyaretci(gunubirlikziyaretci);
            dgwGunubirlik.DataSource = gunubirlikziyaretci.Getgunubirlikziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi bilgileri başarıyla güncellendi.");

            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");

        }
        //gunubirlikform'daki sil butonu fonksiyon
        private void buttonsil_Click(object sender, EventArgs e)
        {

            gunubirlikziyaretci.id = Convert.ToInt32(textBoxid.Text);


            var kontrol = gunubirlikziyaretci.Deleteziyaretci(gunubirlikziyaretci);
            dgwGunubirlik.DataSource = gunubirlikziyaretci.Getgunubirlikziyaretci();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Ziyaretçi başarıyla silindi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        //textboxlardaki verileri temizleyen fonksiyon
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        //datagridview satırlara tıklandığında verileri textboxa yazdırma
        private void dgwGunubirlik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxid.Text = dgwGunubirlik.CurrentRow.Cells[0].Value.ToString();
            textBoxplaka.Text = dgwGunubirlik.CurrentRow.Cells[1].Value.ToString();
            textBoxadsoyad.Text = dgwGunubirlik.CurrentRow.Cells[2].Value.ToString();
            textBoxtcno.Text = dgwGunubirlik.CurrentRow.Cells[3].Value.ToString();
            maskedTextBoxgiris.Text = dgwGunubirlik.CurrentRow.Cells[4].Value.ToString();
            maskedTextBoxcikis.Text = dgwGunubirlik.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dgwGunubirlik.CurrentRow.Cells[6].Value.ToString();
            textBoxaciklama.Text = dgwGunubirlik.CurrentRow.Cells[11].Value.ToString();

        }




        //excele aktarma butonu fonksiyonları
        private void buttonexcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgwGunubirlik.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dgwGunubirlik.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgwGunubirlik.Rows.Count; i++)
            {
                for (int j = 0; j < dgwGunubirlik.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = dgwGunubirlik.Rows[i].Cells[j].Value.ToString();

                }

            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }
        //plaka arama fonksiyonu
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgwGunubirlik.DataSource as DataTable).DefaultView.RowFilter = string.Format("plaka LIKE '%{0}%'", textBox1.Text);
        }
        //ad soyad arama fonksiyonu
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dgwGunubirlik.DataSource as DataTable).DefaultView.RowFilter = string.Format("adsoyad LIKE '%{0}%'", textBox2.Text);
        }
        //tarih filtreleme
        private void button1_Click(object sender, EventArgs e)
        {
            (dgwGunubirlik.DataSource as DataTable).DefaultView.RowFilter = string.Format("tarih > '{0}' AND tarih <= '{1}'", dateTimePicker2.Value, dateTimePicker3.Value);
        }
        //filtrelenen içeriği temizleme
        private void button2_Click(object sender, EventArgs e)
        {
            dgwGunubirlik.DataSource = gunubirlikziyaretci.Getgunubirlikziyaretci();
        }
    }
}
