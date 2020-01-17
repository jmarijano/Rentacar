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
    public partial class IspisEvidencijeZaposlenika : Form
    {
        public IspisEvidencijeZaposlenika()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragEvidencijaZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisEvidencijeZaposlenika_Load(object sender, EventArgs e)
        {
            GridViewEvidencijaZaposlenika();
        }
        private void GridViewEvidencijaZaposlenika()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=;convert zero datetime=True";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM evidencija_o_zaposleniku", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewEvidencijaZaposlenika.DataSource = dt;
            condatabase.Close();
            dataGridViewEvidencijaZaposlenika.Columns[0].HeaderText = "Šifra evidencije";
            dataGridViewEvidencijaZaposlenika.Columns[1].HeaderText = "Datum dolaska";
            dataGridViewEvidencijaZaposlenika.Columns[2].HeaderText = "Datum odlaska";;
            dataGridViewEvidencijaZaposlenika.Columns[3].HeaderText = "Šifra zaposlenika";
            dataGridViewEvidencijaZaposlenika.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
            dataGridViewEvidencijaZaposlenika.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
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
