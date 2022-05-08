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
    public partial class frmIst : Form
    {
        postaVeriTabani db = new postaVeriTabani();
        public frmIst()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cümle7 = "Select Count(p.TeslimatID) as [Teslimatcinin Mevcut İs Sayisi],f.ID as [Teslimat ID] From Fatura as f INNER JOIN Posta as p ON p.TeslimatID = f.ID WHERE p.TeslimatID = '" + textBox3.Text + "' GROUP BY f.ID,p.TeslimatID";
            SqlDataAdapter adtr8 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr8, cümle7);

        }

        private void t_Click(object sender, EventArgs e)
        {
            String cümle8 = "BEGIN DECLARE @toplam INT SELECT  @toplam = SUM(fiyat)  FROM fatura i INNER JOIN posta o ON o.FaturaID = i.ID WHERE  YEAR(Tarih) = 2021    SELECT @toplam as [Yıllık Toplam Kazanç] IF @toplam > 300 BEGIN PRINT 'Super sene aferim ayol' END ELSE BEGIN PRINT 'Calismaya devam' END END";
            SqlDataAdapter adtr9 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr9, cümle8);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String cümle9 = "Select TeslimatID,count(FaturaID) as Maas,CASE WHEN count(FaturaID) >= 200 THEN'2 Kat MESAİ' WHEN count(FaturaID)>= 100 THEN ' MESAİ'WHEN count(FaturaID)>= 50 THEN 'ASKERI'ELSE 'PART TIME 'END FROM Posta GROUP BY TeslimatID";
            SqlDataAdapter adtr10 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr10, cümle9);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIst_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle77 = "SELECT SUM(fiyat) as Toplam,ŞubeID FROM fatura i INNER JOIN posta o ON o.FaturaID = i.ID GROUP BY ŞubeID Having ŞubeID = '"+Convert.ToInt32(textBox1.Text)+"'";
            SqlDataAdapter adtr77 = new SqlDataAdapter();
            dataGridView1.DataSource = db.listele(adtr77, cümle77);
        }
    }
}
