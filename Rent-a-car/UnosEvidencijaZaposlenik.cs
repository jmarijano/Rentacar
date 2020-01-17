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
    public partial class UnosEvidencijaZaposlenik : Form
    {
        public UnosEvidencijaZaposlenik()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePickerKraj.Format = DateTimePickerFormat.Custom;
            dateTimePickerKraj.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateTimePickerPocetak.Format = DateTimePickerFormat.Custom;
            dateTimePickerPocetak.CustomFormat = "dd-MM-yyy HH:mm:ss";
        }

        private void ButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornikUnosa = new IzbornikUnosa();
            izbornikUnosa.ShowDialog();
            this.Close();
        }

        private void ButtonZaposlenik_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisEvidencijeZaposlenika ispisEvidencijeZaposlenika = new IspisEvidencijeZaposlenika();
            ispisEvidencijeZaposlenika.ShowDialog();
            this.Close();
        }

        private void UnosEvidencijaZaposlenik_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = new DataTable("zaposlenik");
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;" +
                    "database=rent_a_car;Uid=root;password=");
                string upit = "Select ID_zaposlenika,ime_zaposlenika,prezime_zaposlenika from zaposlenik";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tb.Load(reader);
                tb.Columns.Add("Fullname", typeof(string), "ID_zaposlenika + ' ' + ime_zaposlenika + ' ' + prezime_zaposlenika");
                comboBoxZaposlenik.DisplayMember = "Fullname";
                comboBoxZaposlenik.ValueMember = "ID_zaposlenika";
                comboBoxZaposlenik.DataSource = tb;
                connection.Close();

                connection.Open();
                upit = "select * from evidencija_o_zaposleniku";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxEvidencija.Items.Add(reader.GetString("ID_evidencije"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_evidencije"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "insert into evidencija_o_zaposleniku(ID_evidencije,datum_dolaska," +
                    "datum_odlaska,ID_zaposlenika) values(default,'" 
                    +this.dateTimePickerPocetak.Value.ToString("yyyy-MM-dd HH:mm:ss")+ 
                    "','" +this.dateTimePickerKraj.Value.ToString("yyyy-MM-dd HH:mm:ss")+ 
                    "','" +this.comboBoxZaposlenik.SelectedValue+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos nove evidencije o zaposleniku je uspješan!");
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from evidencija_o_zaposleniku where " +
                    "ID_evidencije = '" + this.comboBoxEvidencija.Text + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Evidencija o zaposleniku je izbrisana!");
                while (reader.Read())
                {

                }
                condatabase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "update evidencija_o_zaposleniku set " +
                    "datum_dolaska='" +this.dateTimePickerPocetak.Value.ToString("yyyy-MM-dd HH:mm:ss") 
                    + "', datum_odlaska='" +this.dateTimePickerKraj.Value.ToString("yyyy-MM-dd HH:mm:ss") 
                    + "',ID_zaposlenika='" + 
                    this.comboBoxZaposlenik.SelectedValue+ "' where ID_evidencije='" + 
                    this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Evidencija o zaposlenuku je ažurirana!");
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

        private void ComboBoxAzuriraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=;convert zero datetime=True");
                string upit = "Select * from evidencija_o_zaposleniku where " +
                    "ID_evidencije='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string dolazak = (string)reader["datum_dolaska"].ToString();
                    dateTimePickerPocetak.Value =Convert.ToDateTime(dolazak);
                    string odlazak = (string)reader["datum_odlaska"].ToString();
                    dateTimePickerKraj.Value = Convert.ToDateTime(odlazak);
                    string zaposlenik = (string)reader["ID_zaposlenika"].ToString();
                    comboBoxZaposlenik.Text = zaposlenik;
                    
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
