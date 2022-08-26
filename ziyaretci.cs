using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziyaretcikayit
{
    // class değişkenleri atandı
    internal class ziyaretci
    {
        int _id;
        string _plaka;
        string _adsoyad;
        string _tcno;
        string _firmaad;
        string _birim;
        string _giris;
        DateTime _tarih;
        string _cikis;
        string _aciklama;



        //get set metodlarıyla  verileri okuyup yazdırıyoruz
        internal int id { get => _id; set => _id = value; }
        internal string plaka { get => _plaka; set => _plaka = value; }
        internal string adsoyad { get => _adsoyad; set => _adsoyad = value; }
        internal string tcno { get => _tcno; set => _tcno = value; }
        internal string firmaad { get => _firmaad; set => _firmaad = value; }
        internal string birim { get => _birim; set => _birim = value; }
        internal string giris { get => _giris; set => _giris = value; }

        internal DateTime tarih { get => _tarih; set => _tarih = value; }
        internal string cikis { get => _cikis; set => _cikis = value; }
        internal string aciklama { get => _aciklama; set => _aciklama = value; }

        //sql bağlantısı 
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        //insert
        private const string InsertQuery = "Insert Into dbZiyaretci (plaka,adsoyad,tcno,firmaad,birim,giris,tarih,cikis,aciklama) Values (@ziyaretciplaka, @ziyaretciadsoyad, @ziyaretcitcno, @ziyaretcifirmaad, @ziyaretcibirim, @ziyaretcigiris,@ziyaretcitarih, @ziyaretcicikis, @ziyaretciaciklama)";

        public bool Insertziyaretci(ziyaretci ziyaretci)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@ziyaretciid", ziyaretci.id);
                    com.Parameters.AddWithValue("@ziyaretciplaka", ziyaretci.plaka);
                    com.Parameters.AddWithValue("@ziyaretciadsoyad", ziyaretci.adsoyad);
                    com.Parameters.AddWithValue("@ziyaretcitcno", ziyaretci.tcno);
                    com.Parameters.AddWithValue("@ziyaretcifirmaad", ziyaretci.firmaad);
                    com.Parameters.AddWithValue("@ziyaretcibirim", ziyaretci.birim);
                    com.Parameters.AddWithValue("@ziyaretcigiris", ziyaretci.giris);
                    com.Parameters.AddWithValue("@ziyaretcitarih", ziyaretci.tarih);
                    com.Parameters.AddWithValue("@ziyaretcicikis", ziyaretci.cikis);
                    com.Parameters.AddWithValue("@ziyaretciaciklama", ziyaretci.aciklama);

                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        //update
        private const string UpdateQuery = "Update dbZiyaretci set plaka=@ziyaretciplaka,adsoyad=@ziyaretciadsoyad,tcno=@ziyaretcitcno,firmaad=@ziyaretcifirmaad,birim=@ziyaretcibirim,giris=@ziyaretcigiris,tarih=@ziyaretcitarih,cikis=@ziyaretcicikis,aciklama=@ziyaretciaciklama where id=@ziyaretciid";
        public bool Updateziyaretci(ziyaretci ziyaretci)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {

                    com.Parameters.AddWithValue("@ziyaretciplaka", ziyaretci.plaka);
                    com.Parameters.AddWithValue("@ziyaretciadsoyad", ziyaretci.adsoyad);
                    com.Parameters.AddWithValue("@ziyaretcitcno", ziyaretci.tcno);
                    com.Parameters.AddWithValue("@ziyaretcifirmaad", ziyaretci.firmaad);
                    com.Parameters.AddWithValue("@ziyaretcibirim", ziyaretci.birim);
                    com.Parameters.AddWithValue("@ziyaretcigiris", ziyaretci.giris);
                    com.Parameters.AddWithValue("@ziyaretcitarih", ziyaretci.tarih);
                    com.Parameters.AddWithValue("@ziyaretcicikis", ziyaretci.cikis);
                    com.Parameters.AddWithValue("@ziyaretciaciklama", ziyaretci.aciklama);
                    com.Parameters.AddWithValue("@ziyaretciid", ziyaretci.id);

                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        //delete
        private const string DeleteQuery = "Delete from dbZiyaretci where id=@ziyaretciid";

        public bool Deleteziyaretci(ziyaretci ziyaretci)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@ziyaretciid", ziyaretci.id);

                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        //datagridview tablosunu dolduran fonksiyon
        private const string SelectQuery = "Select * from dbZiyaretci";


        public DataTable Getziyaretci()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        _ = adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }


    }
}

