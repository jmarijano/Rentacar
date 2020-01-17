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
    public partial class IspisKlijenta : Form
    {
        public IspisKlijenta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragKlijenti_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisKlijenta_Load(object sender, EventArgs e)
        {
            DataGridViewKlijenti();
        }

        public void DataGridViewKlijenti()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM klijent", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewKlijent.DataSource = dt;
            condatabase.Close();
            dataGridViewKlijent.Columns[0].HeaderText = "Šifra klijenta";
            dataGridViewKlijent.Columns[1].HeaderText = "Adresa";
            dataGridViewKlijent.Columns[2].HeaderText = "Broj vozačke dozvole";
            dataGridViewKlijent.Columns[3].HeaderText = "Ime klijenta";
            dataGridViewKlijent.Columns[4].HeaderText = "Prezime klijenta";
            dataGridViewKlijent.Columns[5].HeaderText = "Telefon";
            dataGridViewKlijent.Columns[6].HeaderText = "E - mail adresa";
            dataGridViewKlijent.Columns[7].HeaderText = "Poštanski broj";
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornik = new IzbornikUnosa();
            izbornik.ShowDialog();
            this.Close();
        }
    }
}
