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
    public partial class IspisIznajmljivanja : Form
    {
        public IspisIznajmljivanja()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NatragIznajmljivanja_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisIznajmljivanja_Load(object sender, EventArgs e)
        {
            GridViewIznajmljivanja();
        }
        public void GridViewIznajmljivanja()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=;;convert zero datetime=True";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM evidencija", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewIznajmljivanja.DataSource = dt;
            condatabase.Close();
            dataGridViewIznajmljivanja.Columns[0].HeaderText = "Šifra evidencije";
            dataGridViewIznajmljivanja.Columns[1].HeaderText = "Šifra klijenta";
            dataGridViewIznajmljivanja.Columns[2].HeaderText = "Šifra automobila";
            dataGridViewIznajmljivanja.Columns[3].HeaderText = "Datum početka iznajmljivanja";
            dataGridViewIznajmljivanja.Columns[4].HeaderText = "Datum završetka iznajmljivanja";
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
