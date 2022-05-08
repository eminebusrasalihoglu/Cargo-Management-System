using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postaOtomasyon
{
    public partial class frmIslemler : Form
    {
        int personelID;
        public frmIslemler(int personelID)
        {
            InitializeComponent();

            this.personelID = personelID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formIslemEkle sayfaIslemEkle = new formIslemEkle( personelID);
            sayfaIslemEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmIslemGoruntuleme sayfaIslemGoruntuleme = new frmIslemGoruntuleme();
            sayfaIslemGoruntuleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIslemSil sayfaIslemSil = new frmIslemSil(personelID);
            sayfaIslemSil.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmIslemSorgula sayfaIslemSorgu = new frmIslemSorgula();
            sayfaIslemSorgu.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmIst sayfaIst = new frmIst();
            sayfaIst.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBilgiGuncelle sayfaIcerik = new frmBilgiGuncelle();
            sayfaIcerik.ShowDialog();
        }

        private void frmIslemler_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIslemSil sayfaIslemsil = new frmIslemSil(personelID);
            sayfaIslemsil.ShowDialog();
        }
    }
}
