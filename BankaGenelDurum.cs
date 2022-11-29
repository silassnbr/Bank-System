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

namespace den_2
{
    public partial class BankaGenelDurum : Form
    {
        public BankaGenelDurum()
        {
            InitializeComponent();
        }

        private void BankaGenelDurum_Load(object sender, EventArgs e)
        {
            
            string sorgu = "Select bankaid ,gelir ,gider, kar toplamBakiye from banka ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, SqlOperations.baglanti);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
