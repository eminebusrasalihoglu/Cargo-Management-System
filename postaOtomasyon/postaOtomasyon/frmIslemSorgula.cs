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
    public partial class frmIslemSorgula : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        public frmIslemSorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
                string cümle = "Select f.Fiyat,f.Tarih,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE f.Fiyat > '" + Convert.ToInt32(textBox1.Text) + "'";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr2, cümle); }
            else if (radioButton2.Checked) {
                string cümle2 = "Select f.Fiyat,f.Tarih,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE f.Fiyat  < '" + textBox1.Text + "'";
                SqlDataAdapter adtr3 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr3, cümle2); }
            else {
                string cümle3 = "Select f.Fiyat,f.Tarih,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE f.Fiyat  = '" + textBox1.Text + "'";
                SqlDataAdapter adtr4 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr4, cümle3); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                string cümle4 = "Select f.Takipno,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE YEAR(Tarih)='" + textBox2.Text+ "' AND MONTH(Tarih)= '" + textBox4.Text+ "' AND DAY(Tarih)='" + textBox5.Text+ "'";
                SqlDataAdapter adtr5 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr5, cümle4);
            }
            else if (radioButton4.Checked)
            {
                string cümle5 = "Select f.Takipno,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE YEAR(Tarih)='" + textBox2.Text + "' AND MONTH(Tarih)= '" + textBox4.Text + "'";
                SqlDataAdapter adtr6 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr6, cümle5);
            }
            else if(radioButton3.Checked)
            {
                string cümle6 = "Select f.Takipno,a.AdSoyad From Fatura AS f INNER JOIN Alici as a ON a.ID = f.ID WHERE YEAR(Tarih)='" + textBox2.Text + "'"; 
                SqlDataAdapter adtr7 = new SqlDataAdapter();
                dataGridView1.DataSource = db.listele(adtr7, cümle6);
            }
            else
            {
                Console.WriteLine("selm");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
               
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void t_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           

        }
    }
}
