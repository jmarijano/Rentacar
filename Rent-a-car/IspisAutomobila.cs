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
    public partial class IspisAutomobila : Form
    {
        public IspisAutomobila()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragIspisAutomobila_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisAutomobila_Load(object sender, EventArgs e)
        {
            GridViewAutomobil();
        }
        public void GridViewAutomobil()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=;convert zero datetime=True";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM automobil", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewAutomobil.DataSource = dt;
            condatabase.Close();
            dataGridViewAutomobil.Columns[0].HeaderText = "Šifra automobila";
            dataGridViewAutomobil.Columns[1].HeaderText = "Šifra osiguravajuće kuće";
            dataGridViewAutomobil.Columns[2].HeaderText = "Šifra klase";
            dataGridViewAutomobil.Columns[3].HeaderText = "Šifra proizvođača";
            dataGridViewAutomobil.Columns[4].HeaderText = "Boja automobila";
            dataGridViewAutomobil.Columns[5].HeaderText = "Potrošnja";
            dataGridViewAutomobil.Columns[6].HeaderText = "Datum kupnje";
            dataGridViewAutomobil.Columns[7].HeaderText = "Vrsta pogona";
            dataGridViewAutomobil.Columns[8].HeaderText = "Registracijski broj";
            dataGridViewAutomobil.Columns[9].HeaderText = "Naziv automobila";
            dataGridViewAutomobil.Columns[10].HeaderText = "Cijena iznajmljivanja";
            dataGridViewAutomobil.Columns[5].DefaultCellStyle.Format = "n2";
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
