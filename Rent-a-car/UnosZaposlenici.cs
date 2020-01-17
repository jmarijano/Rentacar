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
    public partial class UnosZaposlenici : Form
    {
        public UnosZaposlenici()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void NatragZaposlenik_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa nova = new IzbornikUnosa();
            nova.ShowDialog();
            this.Close();
        }

        private void UnosZaposlenici_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = new DataTable("grad");
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "Select * from grad";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tb.Load(reader);
                tb.Columns.Add("Sve", typeof(string), "postanski_broj + ' ' + grad");
                comboBoxPostanskiBroj.DisplayMember = "Sve";
                comboBoxPostanskiBroj.ValueMember = "postanski_broj";
                comboBoxPostanskiBroj.DataSource = tb;
                connection.Close();

                connection.Open();
                upit = "select * from zaposlenik";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxZaposlenik.Items.Add(reader.GetString("ID_zaposlenika"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_zaposlenika"));
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonIspis_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisZaposlenika ispisZaposlenika = new IspisZaposlenika();
            ispisZaposlenika.ShowDialog();
            this.Close();
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "INSERT INTO zaposlenik(ID_zaposlenika,ime_zaposlenika,prezime_zaposlenika,OIB_zaposlenika," +
                    "godina_rodenja,spol,djelatnost,obrazovanje,radni_staz,postanski_broj,satnica) values" +
                    " (default,'" +this.textBoxIme.Text+ "','" +this.textBoxPrezime.Text+ "','" 
                    +this.textBoxOIB.Text+ "','" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" +this.textBoxSpol.Text+ "','" 
                    +this.textBoxDjelatnost.Text+ "','" +this.textBoxObrazovanje.Text+ "','" +this.textBoxRadniStaz.Text+ "','" 
                    +this.comboBoxPostanskiBroj.SelectedValue+ "','" +this.textBoxSatnica.Text+ "')";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Novi zaposlenik je unesen!");
                while (reader.Read())
                {

                }
                condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ButtonIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from zaposlenik where ID_zaposlenika = '" + this.comboBoxZaposlenik.Text + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Zaposlenik izbrisan!");
                while (reader.Read())
                {

                }
                condatabase.Close();
                foreach (Control c in Controls)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "update zaposlenik set ime_zaposlenika='" +this.textBoxIme.Text+ "',prezime_zaposlenika='" +this.textBoxPrezime.Text+ "',OIB_zaposlenika='" + this.textBoxOIB.Text+ "',godina_rodenja='" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")+ "',spol='" + this.textBoxSpol.Text+ "',djelatnost='" + this.textBoxDjelatnost.Text+ "',obrazovanje='" + this.textBoxObrazovanje.Text+ "',radni_staz='" + this.textBoxRadniStaz.Text+ "',postanski_broj='" + this.comboBoxPostanskiBroj.SelectedValue+ "',satnica='" + this.textBoxSatnica.Text+ "' where ID_zaposlenika='" + this.comboBoxAzuriraj.Text+ "';";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Zaposlenik ažuriran!");
                while (reader.Read())
                {

                }
                condatabase.Close();
                foreach (Control c in Controls)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxAzuriraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=;convert zero datetime=True");
                string upit = "Select * from zaposlenik where ID_zaposlenika='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ime = (string)reader["ime_zaposlenika"].ToString();
                    textBoxIme.Text = ime;
                    string prezime = (string)reader["prezime_zaposlenika"].ToString();
                    textBoxPrezime.Text = prezime;
                    string oib = (string)reader["OIB_zaposlenika"].ToString();
                    textBoxOIB.Text = oib;
                    string godina = (string)reader["godina_rodenja"].ToString();
                    dateTimePicker1.Value =Convert.ToDateTime(godina);
                    string spol = (string)reader["spol"].ToString();
                    textBoxSpol.Text = spol;
                    string djelatnost = (string)reader["djelatnost"].ToString();
                    textBoxDjelatnost.Text = djelatnost;
                    string obrazovanje = (string)reader["obrazovanje"].ToString();
                    textBoxObrazovanje.Text = obrazovanje;
                    string radniStaz = (string)reader["radni_staz"].ToString();
                    textBoxRadniStaz.Text = radniStaz;
                    string postanski = (string)reader["postanski_broj"].ToString();
                    comboBoxPostanskiBroj.Text = postanski;
                    string satnica = (string)reader["satnica"].ToString();
                    textBoxSatnica.Text = satnica;
                    
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
