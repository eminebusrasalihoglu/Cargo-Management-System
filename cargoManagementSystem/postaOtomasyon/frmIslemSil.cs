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
    public partial class frmIslemSil : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        int personelID;
        SqlConnection baglanti = new SqlConnection("Data Source=BUSRAPC;Initial Catalog=PostaOfis;Integrated Security=True");
        public frmIslemSil(int personelID)
        {
            InitializeComponent();
            this.personelID = personelID;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Int32 aliciID;
            int gonderiID;
            Int32 faturaID;
            Int32 x = Convert.ToInt32(textBox1.Text);
            
            SqlCommand komut2 = new SqlCommand();
            SqlCommand komut3 = new SqlCommand();
            SqlCommand komut4 = new SqlCommand();
            SqlCommand komut5 = new SqlCommand();

            if (Convert.ToInt32(textBox2.Text) == personelID)
            {
                SqlCommand file1 = new SqlCommand("Select GöndericiID from Posta WHERE ID= @ID", baglanti);
                file1.Parameters.AddWithValue("@ID", x);
                gonderiID = (Int32)file1.ExecuteScalar();
                SqlCommand file2 = new SqlCommand("Select AlıcıID from Posta WHERE ID= @ID", baglanti);
                file2.Parameters.AddWithValue("@ID", x);
                aliciID = (Int32)file2.ExecuteScalar();
                SqlCommand file3 = new SqlCommand("Select FaturaID from Posta WHERE ID= @ID", baglanti);
                file3.Parameters.AddWithValue("@ID", x);
                faturaID = (Int32)file3.ExecuteScalar();

                string cümle = "Delete from Posta where ID ='"+x+"'";
                string cümle2 = "Delete from Gönderici where ID = '" + gonderiID + "'";
                string cümle3 = "Delete from Alici where ID = '" + aliciID + "'";
                string cümle4 = "Delete from Fatura where ID = '" + faturaID + "'";
                komut2.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
                db.ekle_sil_guncelle(komut2, cümle);
                db.ekle_sil_guncelle(komut3, cümle2);
                db.ekle_sil_guncelle(komut4, cümle3);
                db.ekle_sil_guncelle(komut5, cümle4);
 
            }
            else
            {
                MessageBox.Show("Id'niz hatalıdır");
            }
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = " ";
            baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIslemSil_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
