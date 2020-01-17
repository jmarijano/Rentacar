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
    public partial class IspisOsiguravajucihKuca : Form
    {
        public IspisOsiguravajucihKuca()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragOsiguravajuceKuce_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisOsiguravajucihKuca_Load(object sender, EventArgs e)
        {
            GridViewOsigurajuceKuce();
        }
        public void GridViewOsigurajuceKuce()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM osiguravajuca_kuca", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewOsiguravajuceKuce.DataSource = dt;
            condatabase.Close();
            dataGridViewOsiguravajuceKuce.Columns[0].HeaderText = "Šifra osiguravajuće kuće";
            dataGridViewOsiguravajuceKuce.Columns[1].HeaderText = "Naziv osiguravajuće kuće";
            dataGridViewOsiguravajuceKuce.Columns[2].HeaderText = "E - mail adresa";
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornik = new IzbornikUnosa();
            izbornik.ShowDialog();
            this.Close();
        }
    }
}
