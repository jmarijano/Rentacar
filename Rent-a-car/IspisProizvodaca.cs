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
    public partial class IspisProizvodaca : Form
    {
        public IspisProizvodaca()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void IspisProizvodaca_Load(object sender, EventArgs e)
        {
            GridIspisProizvodaca();
        }
        public void GridIspisProizvodaca()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM proizvodac", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            gridViewProizvodaci.DataSource = dt;
            condatabase.Close();
            gridViewProizvodaci.Columns[0].HeaderText = "Šifra proizvođača";
            gridViewProizvodaci.Columns[1].HeaderText = "Naziv proizvođača";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa nova = new IzbornikIspisa();
            nova.ShowDialog();
            this.Close();
        }

        private void gridViewProizvodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
