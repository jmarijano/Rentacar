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
    public partial class IspisLokacija : Form
    {
        public IspisLokacija()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragLokacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisLokacija_Load(object sender, EventArgs e)
        {
            GridViewLokacija();
        }
        public void GridViewLokacija()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lokacija", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewLokacija.DataSource = dt;
            condatabase.Close();
            dataGridViewLokacija.Columns[0].HeaderText = "Šifra osiguravajuće kuće";
            dataGridViewLokacija.Columns[1].HeaderText = "Poštanski broj";
            dataGridViewLokacija.Columns[2].HeaderText = "Lokacija";
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
