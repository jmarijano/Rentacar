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
    public partial class Upit1 : Form
    {
        public Upit1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Upit1_Load(object sender, EventArgs e)
        {
            Gridview1();
        }

        private void Gridview1()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ime_zaposlenika,prezime_zaposlenika,djelatnost,radni_staz FROM zaposlenik order by radni_staz desc;", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewUpit1.DataSource = dt;
            condatabase.Close();
            dataGridViewUpit1.Columns[0].HeaderText = "Ime zaposlenika";
            dataGridViewUpit1.Columns[1].HeaderText = "Prezime zaposlenika";
            dataGridViewUpit1.Columns[2].HeaderText = "Djelatnost";
            dataGridViewUpit1.Columns[3].HeaderText = "Radni staž";
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUpit izbornikUpit = new IzbornikUpit();
            izbornikUpit.ShowDialog();
            this.Close();
        }
    }
}
