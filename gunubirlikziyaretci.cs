using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ziyaretcikayit
{
    //class değişkenleri
    internal class gunubirlikziyaretci
    {
        int _id;
        string _plaka;
        string _adsoyad;
        string _tcno;
        string _giris;
        string _cikis;
        DateTime _tarih;
        byte _sabah;
        byte _ogle;
        byte _aksam;
        byte _gunubirlik;
        string _aciklama;


        //verilerimizi okuyup yazdırıyoruz
        internal int id { get => _id; set => _id = value; }

        internal string plaka { get => _plaka; set => _plaka = value; }

        internal string adsoyad { get => _adsoyad; set => _adsoyad = value; }

        internal string tcno { get => _tcno; set => _tcno = value; }

        internal string giris { get => _giris; set => _giris = value; }

        internal string cikis { get => _cikis; set => _cikis = value; }

        internal DateTime tarih { get => _tarih; set => _tarih = value; }

        internal byte sabah { get => _sabah; set => _sabah = value; }

        internal byte ogle { get => _ogle; set => _ogle = value; }

        internal byte aksam { get => _aksam; set => _aksam = value; }

        internal byte gunubirlik { get => _gunubirlik; set => _gunubirlik = value; }

        internal string aciklama { get => _aciklama; set => _aciklama = value; }
        //sql bağlantısı
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //insert
        private const string InsertQuery = "Insert Into dbGunubirlik ( plaka,adsoyad,tcno,giris,cikis,tarih,sabah,ogle,aksam,gunubirlik,aciklama) Values (@gunubirlikziyaretciplaka,@gunubirlikziyaretciadsoyad,@gunubirlikziyaretcitcno,@gunubirlikziyaretcigiris,@gunubirlikziyaretcicikis,@gunubirlikziyaretcitarih,@gunubirlikziyaretcisabah,@gunubirlikziyaretciogle,@gunubirlikziyaretciaksam,@gunubirlikziyaretcigunubirlik,@gunubirlikziyaretciaciklama)";


        public bool Insertgunubirlikziyaretci(gunubirlikziyaretci gunubirlikziyaretci)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@gunubirlikziyaretciid", gunubirlikziyaretci.id);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciplaka", gunubirlikziyaretci.plaka);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciadsoyad", gunubirlikziyaretci.adsoyad);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcitcno", gunubirlikziyaretci.tcno);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcigiris", gunubirlikziyaretci.giris);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcicikis", gunubirlikziyaretci.cikis);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcitarih", gunubirlikziyaretci.tarih);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcisabah", gunubirlikziyaretci.sabah);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciogle", gunubirlikziyaretci.ogle);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciaksam", gunubirlikziyaretci.aksam);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcigunubirlik", gunubirlikziyaretci.gunubirlik);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciaciklama", gunubirlikziyaretci.aciklama);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;

        }
        //update
        private const string UpdateQuery = "Update dbGunubirlik set  plaka=@gunubirlikziyaretciplaka,adsoyad=@gunubirlikziyaretciadsoyad,tcno=@gunubirlikziyaretcitcno,giris=@gunubirlikziyaretcigiris,cikis=@gunubirlikziyaretcicikis,tarih=@gunubirlikziyaretcitarih,sabah=@gunubirlikziyaretcisabah,ogle=@gunubirlikziyaretciogle,aksam=@gunubirlikziyaretciaksam,gunubirlik=@gunubirlikziyaretcigunubirlik,aciklama=@gunubirlikziyaretciaciklama where id=@gunubirlikziyaretciid";
        public bool Updategunubirlikziyaretci(gunubirlikziyaretci gunubirlikziyaretci)
        {

            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@gunubirlikziyaretciid", gunubirlikziyaretci.id);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciplaka", gunubirlikziyaretci.plaka);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciadsoyad", gunubirlikziyaretci.adsoyad);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcitcno", gunubirlikziyaretci.tcno);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcigiris", gunubirlikziyaretci.giris);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcicikis", gunubirlikziyaretci.cikis);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcitarih", gunubirlikziyaretci.tarih);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcisabah", gunubirlikziyaretci.sabah);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciogle", gunubirlikziyaretci.ogle);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciaksam", gunubirlikziyaretci.aksam);
                    com.Parameters.AddWithValue("@gunubirlikziyaretcigunubirlik", gunubirlikziyaretci.gunubirlik);
                    com.Parameters.AddWithValue("@gunubirlikziyaretciaciklama", gunubirlikziyaretci.aciklama);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;


        }
        //delete
        private const string DeleteQuery = "Delete from dbGunubirlik where id=@gunubirlikziyaretciid";

        public bool Deleteziyaretci(gunubirlikziyaretci gunubirlikziyaretci)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@gunubirlikziyaretciid", gunubirlikziyaretci.id);

                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        //datatableyi dolduran komut

        private const string SelectQuery = "Select * from dbGunubirlik";

        public DataTable Getgunubirlikziyaretci()
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


