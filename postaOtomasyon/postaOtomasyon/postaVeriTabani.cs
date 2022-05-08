using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace postaOtomasyon
{
    class postaVeriTabani
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BUSRAPC;Initial Catalog=PostaOfis;Integrated Security=True");
        DataTable tablo;

        public void ekle_sil_guncelle(SqlCommand komut,String sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {

            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }

    }
}
