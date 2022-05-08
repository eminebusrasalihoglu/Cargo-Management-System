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
using System.Data;
namespace postaOtomasyon
{
    public partial class frmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BUSRAPC;Initial Catalog=PostaOfis;Integrated Security=True");
        public frmGiris()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where Eposta='"+textBox1.Text+"' and TC='"+textBox2.Text+"'",baglanti);
            SqlDataReader file = komut.ExecuteReader();
            int personelID = 0;
            
            if (file.Read()){
                personelID = Convert.ToInt32(file[0]);
                frmMenu menu = new frmMenu(personelID);
                menu.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgisi veya şifre hatalı");
                textBox1.Clear();
                textBox2.Clear();

            }
            baglanti.Close();
        }
    }
}
