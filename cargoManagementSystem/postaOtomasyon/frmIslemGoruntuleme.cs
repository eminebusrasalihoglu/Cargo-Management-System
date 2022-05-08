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
    public partial class frmIslemGoruntuleme : Form
    {

        postaVeriTabani db = new postaVeriTabani();
        public frmIslemGoruntuleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIcerikGoruntuleme sayfaIcerik = new frmIcerikGoruntuleme();
            sayfaIcerik.ShowDialog();
        }

        private void frmIslemGoruntuleme_Load(object sender, EventArgs e)
        {
            string cümle = "select * from Posta";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr2, cümle);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Posta where ID like '%" + textBox10.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr2, cümle);
        }
    }
}
