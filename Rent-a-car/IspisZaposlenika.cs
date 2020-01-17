using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rent_a_car
{
    public partial class IspisZaposlenika : Form
    {
        public IspisZaposlenika()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragGradovi_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisZaposlenika_Load(object sender, EventArgs e)
        {
            DataGridViewZaposlenici();
        }
        public void DataGridViewZaposlenici()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM zaposlenik", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewZaposlenici.DataSource = dt;
            condatabase.Close();
            dataGridViewZaposlenici.Columns[0].HeaderText = "Šifra zaposlenika";
            dataGridViewZaposlenici.Columns[1].HeaderText = "Ime zaposlenika";
            dataGridViewZaposlenici.Columns[2].HeaderText = "Prezime zaposlenika";
            dataGridViewZaposlenici.Columns[3].HeaderText = "OIB";
            dataGridViewZaposlenici.Columns[4].HeaderText = "Godina rođenja";
            dataGridViewZaposlenici.Columns[5].HeaderText = "Spol";
            dataGridViewZaposlenici.Columns[6].HeaderText = "Djelatnost";
            dataGridViewZaposlenici.Columns[7].HeaderText = "Obrazovanje";
            dataGridViewZaposlenici.Columns[8].HeaderText = "Radni staž";
            dataGridViewZaposlenici.Columns[9].HeaderText = "Poštanski  broj";
            dataGridViewZaposlenici.Columns[10].HeaderText = "Satnica";
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornikUnosa = new IzbornikUnosa();
            izbornikUnosa.ShowDialog();
            this.Close();
        }
    }
}
