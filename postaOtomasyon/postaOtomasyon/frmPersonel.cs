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
    public partial class frmPersonel : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            string cümle = "select * from Personel";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr2, cümle);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Personel where ID like '%" + textBox10.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr2, cümle);
        }
    }
}
