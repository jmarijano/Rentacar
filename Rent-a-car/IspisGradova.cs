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
    public partial class IspisGradova : Form
    {
        public IspisGradova()
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

        private void IspisGradova_Load(object sender, EventArgs e)
        {
            GridIspisGradova();
        }
        public void GridIspisGradova()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM grad", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridViewGradovi.DataSource = dt;
            condatabase.Close();
            GridViewGradovi.Columns[0].HeaderText = "Poštanski broj";
            GridViewGradovi.Columns[1].HeaderText = "Naziv grada";
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornikUnosa = new IzbornikUnosa();
            izbornikUnosa.ShowDialog();
            this.Close();
        }
    }
}
