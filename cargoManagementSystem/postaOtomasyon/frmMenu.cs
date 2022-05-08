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
    public partial class frmMenu : Form
    {
        int personelID;
        public frmMenu(int personelID)
        {
            InitializeComponent();
            this.personelID = personelID;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIslemler sayfaIslemler = new frmIslemler(personelID);
            sayfaIslemler.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonel sayfaPersonel = new frmPersonel();
            sayfaPersonel.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSube sayfaSube = new frmSube();
            sayfaSube.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
