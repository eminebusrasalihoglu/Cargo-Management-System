using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace postaOtomasyon
{   
    public partial class formIslemEkle : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        int personelID;
        public formIslemEkle(int personelID)
        {
            InitializeComponent();
            this.personelID = personelID;   
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void oke_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int toplam = 0;
            string veri;
            string veri2;
            string cümle = "insert into Gönderici(AdSoyad,TC,Tel,Eposta,Adres) values(@AdSoyad,@TC,@Tel,@Eposta,@Adres)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txtTC.Text);
            komut2.Parameters.AddWithValue("@Tel", txtTel.Text);
            komut2.Parameters.AddWithValue("@Eposta", txtEposta.Text);
            komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            db.ekle_sil_guncelle(komut2, cümle);

            string cümle2 = "insert into Alici(AdSoyad,TC,Tel,Eposta,Adres) values(@AdSoyad,@TC,@Tel,@Eposta,@Adres)";
            SqlCommand komut3 = new SqlCommand();
            komut3.Parameters.AddWithValue("@AdSoyad", txtAdSoyad2.Text);
            komut3.Parameters.AddWithValue("@TC", txtTC2.Text);
            komut3.Parameters.AddWithValue("@Tel", txtTel2.Text);
            komut3.Parameters.AddWithValue("@Eposta", txtEposta2.Text);
            komut3.Parameters.AddWithValue("@Adres", txtAdres2.Text);
            db.ekle_sil_guncelle(komut3, cümle2);
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            string veri;
            string veri2;
            string cümle3 = "insert into Fatura (Tarih,Tür,Takipno,Fiyat,Açıklama,Hız) values(@Tarih,@Tür,@TakipNo,@Fiyat,@Açıklama,@Hız)";
            SqlCommand komut4 = new SqlCommand();
            komut4.Parameters.AddWithValue("@Tarih", textBox5.Text);
            komut4.Parameters.AddWithValue("@TakipNo", textBox1.Text);
            if (radioButton3.Checked)
            {
                toplam = 15;
                veri = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                toplam = 30;

                veri = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                toplam = 60;
                veri = radioButton5.Text;
            }
            else
            {
                toplam = 120;
                veri = radioButton6.Text;
            }
            komut4.Parameters.AddWithValue("@Tür", veri);
            if (radioButton2.Checked)
            {
                toplam = toplam * 2;
                veri2 = radioButton2.Text;
            }
            else
            {
                veri2 = radioButton1.Text;
            }
            komut4.Parameters.AddWithValue("@Hız", veri2);
            komut4.Parameters.AddWithValue("@Açıklama", textBox3.Text);
            textBox6.Text = toplam.ToString();
            komut4.Parameters.AddWithValue("@Fiyat", toplam);
            db.ekle_sil_guncelle(komut4, cümle3);
            
            string cümle = "insert into Gönderici(AdSoyad,TC,Tel,Eposta,Adres) values(@AdSoyad,@TC,@Tel,@Eposta,@Adres)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txtTC.Text);
            komut2.Parameters.AddWithValue("@Tel", txtTel.Text);
            komut2.Parameters.AddWithValue("@Eposta", txtEposta.Text);
            komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            db.ekle_sil_guncelle(komut2, cümle);

            string cümle2 = "insert into Alici(AdSoyad,TC,Tel,Eposta,Adres) values(@AdSoyad,@TC,@Tel,@Eposta,@Adres)";
            SqlCommand komut3 = new SqlCommand();
            komut3.Parameters.AddWithValue("@AdSoyad", txtAdSoyad2.Text);
            komut3.Parameters.AddWithValue("@TC", txtTC2.Text);
            komut3.Parameters.AddWithValue("@Tel", txtTel2.Text);
            komut3.Parameters.AddWithValue("@Eposta", txtEposta2.Text);
            komut3.Parameters.AddWithValue("@Adres", txtAdres2.Text);
            db.ekle_sil_guncelle(komut3, cümle2);
            
            textBox6.Text = toplam.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=BUSRAPC;Initial Catalog=PostaOfis;Integrated Security=True");
            baglanti.Open();
            int gonderiID;
            
            SqlCommand file1 = new SqlCommand("Select ID from Gönderici WHERE TC= @tc", baglanti);
            file1.Parameters.AddWithValue("@tc", txtTC.Text);
            gonderiID = (Int32)file1.ExecuteScalar();
            int aliciID;
            SqlCommand file2 = new SqlCommand("Select ID from Alici WHERE TC= @tc", baglanti);
            file2.Parameters.AddWithValue("@tc", txtTC2.Text);
            aliciID = (Int32)file2.ExecuteScalar();
            int faturaID;
            SqlCommand file3 = new SqlCommand("Select ID from Fatura WHERE Takipno= @tn", baglanti);
            file3.Parameters.AddWithValue("@tn", textBox1.Text);
            faturaID = (Int32)file3.ExecuteScalar();
            baglanti.Close();
            string cümle4 = "insert into Posta(GöndericiID,AlıcıID,FaturaID,PersonelID,ŞubeID,TeslimatID) values(@veri1,@veri2,@veri3,@veri4,@veri5,@veri6)";
            SqlCommand komut5 = new SqlCommand();
            komut5.Parameters.AddWithValue("@veri1", gonderiID);
            komut5.Parameters.AddWithValue("@veri2", aliciID);
            komut5.Parameters.AddWithValue("@veri3", faturaID);
            komut5.Parameters.AddWithValue("@veri4", personelID);
            komut5.Parameters.AddWithValue("@veri5", subeID.Text);
            komut5.Parameters.AddWithValue("@veri6", txtTeslimatID.Text);
            db.ekle_sil_guncelle(komut5, cümle4);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void formIslemEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
