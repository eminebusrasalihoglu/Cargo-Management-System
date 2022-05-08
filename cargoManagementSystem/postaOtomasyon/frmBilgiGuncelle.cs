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

namespace postaOtomasyon
{
    public partial class frmBilgiGuncelle : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        public frmBilgiGuncelle()
        {
            InitializeComponent();
        }
        private void YenidenListele()
        {
            string cümle = "select * from Gönderici";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr2, cümle);
        }
        private void frmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            YenidenListele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "update Gönderici set TC=@tc,AdSoyad=@adsoyad,Tel=@tel,Eposta=@eposta,adres=@adres where TC=@tc";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@tel", txtTel.Text);
            komut.Parameters.AddWithValue("@eposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            db.ekle_sil_guncelle(komut, cümle);
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";
            YenidenListele();

        }

        

       

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtID.Text = satir.Cells[0].Value.ToString();
            txtTC.Text=satir.Cells[2].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTel.Text = satir.Cells[3].Value.ToString();
            txtEposta.Text = satir.Cells[4].Value.ToString();
            txtAdres.Text = satir.Cells[5].Value.ToString();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
