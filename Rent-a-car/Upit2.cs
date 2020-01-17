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
    public partial class Upit2 : Form
    {
        public Upit2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUpit izbornikUpit = new IzbornikUpit();
            izbornikUpit.ShowDialog();
            this.Close();
        }

        private void Upit2_Load(object sender, EventArgs e)
        {
            Gridview();
        }

        private void Gridview()
        {
            string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
            MySqlConnection condatabase = new MySqlConnection(constring);
            condatabase.Open();
            MySqlCommand cmd = new MySqlCommand("select DISTINCT `proizvodac`.`naziv_proizvodaca`, `automobil`.`naziv_automobila` from evidencija, automobil, proizvodac where `automobil`.`ID_automobila`=`evidencija`.`ID_automobila` and `proizvodac`.`ID_proizvodaca`=`automobil`.`ID_proizvodaca` and '2017-02-03' not between `evidencija`.`datum_pocetka_iznajmljivanja` and`evidencija`.`datum_zavrsertka_iznajmljivanja` ; ", condatabase);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewUpit2.DataSource = dt;
            condatabase.Close();
            dataGridViewUpit2.Columns[0].HeaderText = "Proizvođač";
            dataGridViewUpit2.Columns[1].HeaderText = "Naziv automobila";
        }
    }
}
