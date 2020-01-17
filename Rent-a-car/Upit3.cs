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
    public partial class Upit3 : Form
    {
        public Upit3()
        {
            InitializeComponent();
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUpit izbornikUpit = new IzbornikUpit();
            izbornikUpit.ShowDialog();
            this.Close();
        }

        private void Upit3_Load(object sender, EventArgs e)
        {
            GridView(); 
        }
        public void GridView()
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT `zaposlenik`.`ID_zaposlenika`,`zaposlenik`.`ime_zaposlenika`,`zaposlenik`.`prezime_zaposlenika`,`zaposlenik`.`satnica`,sec_to_time(sum(timestampdiff(second,`evidencija_o_zaposleniku`.`datum_dolaska`,`evidencija_o_zaposleniku`.`datum_odlaska`))) as Vrijeme_na_poslu,round(sum(timestampdiff(second,`evidencija_o_zaposleniku`.`datum_dolaska`,`evidencija_o_zaposleniku`.`datum_odlaska`)) *`zaposlenik`.`satnica`/ 3600, 2) as Isplatiti from zaposlenik, evidencija_o_zaposleniku where `zaposlenik`.`ID_zaposlenika`=`evidencija_o_zaposleniku`.`ID_zaposlenika` group by 1;", condatabase);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewUpit3.DataSource = dt;
                condatabase.Close();
                dataGridViewUpit3.Columns[4].DefaultCellStyle.Format = "dd\\-hh\\:mm\\:ss";
                dataGridViewUpit3.Columns[0].HeaderText = "Šifra zaposlenika";
                dataGridViewUpit3.Columns[1].HeaderText = "Ime zaposlenika";
                dataGridViewUpit3.Columns[2].HeaderText = "Prezime zaposlenika";
                dataGridViewUpit3.Columns[3].HeaderText = "Satnica zaposlenika";
                dataGridViewUpit3.Columns[4].HeaderText = "Ukupno radno vrijeme";
                dataGridViewUpit3.Columns[5].HeaderText = "Za isplatiti";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
