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
    public partial class IspisRacuna : Form
    {
        public IspisRacuna()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragRacun_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisRacuna_Load(object sender, EventArgs e)
        {
            GridViewRacun();
        }
        public void GridViewRacun()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM racun", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewRacun.DataSource = dt;
            condatabase.Close();
            dataGridViewRacun.Columns[0].HeaderText = "Šifra računa";
            dataGridViewRacun.Columns[1].HeaderText = "Datum izdavanja";
            dataGridViewRacun.Columns[2].HeaderText = "Način plaćanja";
            dataGridViewRacun.Columns[3].HeaderText = "Šifra evidencije";
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
