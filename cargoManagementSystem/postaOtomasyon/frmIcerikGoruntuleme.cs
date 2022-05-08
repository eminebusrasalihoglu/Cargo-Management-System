using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postaOtomasyon
{
    public partial class frmIcerikGoruntuleme : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        public frmIcerikGoruntuleme()
        {
            InitializeComponent();
        }

        private void frmIcerikGoruntuleme_Load(object sender, EventArgs e)
        {
            string cümle = "select * from Gönderici";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView5.DataSource = db.listele(adtr2, cümle);
            string cümle2 = "select * from Alici";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView2.DataSource = db.listele(adtr3, cümle2);
            string cümle3 = "select * from Fatura";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr4, cümle3);
            string cümle4 = "select * from Teslimat";
            SqlDataAdapter adtr5 = new SqlDataAdapter();
            dataGridView4.DataSource = db.listele(adtr5, cümle4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Gönderici where ID like '%" +textBox1.Text+ "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView5.DataSource = db.listele(adtr2, cümle);
            string cümle2 = "select * from Alici where ID like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView2.DataSource = db.listele(adtr3, cümle2);
            string cümle3 = "select * from Fatura where ID like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr4, cümle3);
            string cümle4 = "select * from Teslimat where ID like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr5 = new SqlDataAdapter();
            dataGridView4.DataSource = db.listele(adtr5, cümle4);

        }
    }
}
