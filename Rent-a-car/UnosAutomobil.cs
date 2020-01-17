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
    public partial class UnosAutomobil : Form
    {
        public UnosAutomobil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            

        }

        private void ButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa nova = new IzbornikUnosa();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonAutomobil_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisAutomobila ispisAutomobila = new IspisAutomobila();
            ispisAutomobila.ShowDialog();
            this.Close();
        }

        private void UnosAutomobil_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            try
            {
                DataTable tb = new DataTable("proizvodac");
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "Select ID_proizvodaca,naziv_proizvodaca from proizvodac";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tb.Load(reader);
                comboBoxProizvodac.DisplayMember = "naziv_proizvodaca";
                comboBoxProizvodac.ValueMember = "ID_proizvodaca";
                comboBoxProizvodac.DataSource = tb;
                connection.Close();

                connection.Open();
                DataTable dataTable = new DataTable("klasa_automobila");
                upit = "Select ID_tipa, naziv_tipa from klasa_automobila";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                comboBoxKlasa.DisplayMember = "naziv_tipa";
                comboBoxKlasa.ValueMember = "ID_tipa";
                comboBoxKlasa.DataSource = dataTable;
                connection.Close();

                connection.Open();
                DataTable kuca = new DataTable("osiguravajuca_kuca");
                upit = "Select ID_kuce,naziv_kuce from osiguravajuca_kuca";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                kuca.Load(reader);
                comboBoxKuca.DisplayMember = "naziv_kuce";
                comboBoxKuca.ValueMember = "ID_kuce";
                comboBoxKuca.DataSource = kuca;
                connection.Close();

                connection.Open();
                upit = "select * from automobil";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxAutomobil.Items.Add(reader.GetString("ID_automobila"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_automobila"));
                    
                }
                connection.Close();
                

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxKuca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "insert into automobil(ID_automobila,ID_kuce,ID_tipa,ID_proizvodaca,boja_automobila,potrosnja_automobila," +
                "datum_kupnje,vrsta_pogona,registracijski_broj,naziv_automobila,cijena_iznajmljivanja)values" +
                "(default,'" +this.comboBoxKuca.SelectedValue+ "','" +this.comboBoxKlasa.SelectedValue+ "','"
                +this.comboBoxProizvodac.SelectedValue+ "','" +this.textBoxBoja.Text+ "','" +this.textBoxPotrosnja.Text+ "','" 
                +this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + this.textBoxVrstaPogona.Text + "','" +
                this.textBoxRegistracijskaOznaka.Text + "','" + this.textBoxNaziv.Text + "','" 
                + this.textBoxCijena + "')";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Novi automobil je unesen!");
                while (reader.Read())
                {

                }
                condatabase.Close();
                foreach(Control c in Controls)
                {
                    if(c is TextBox || c is ComboBox)
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

        private void ButtonIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from automobil where ID_automobila = '" +this.comboBoxAutomobil.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Automobil izbrisan!");
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

        private void ButtonAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "update automobil set ID_kuce='" +this.comboBoxKuca.SelectedValue+ "',ID_tipa='" + this.comboBoxKlasa.SelectedValue+ "',ID_proizvodaca='" + this.comboBoxProizvodac.SelectedValue+ "',boja_automobila='" + this.textBoxBoja.Text+ "',potrosnja_automobila='" + this.textBoxPotrosnja.Text+ "',datum_kupnje='" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "',vrsta_pogona='" + this.textBoxVrstaPogona.Text+ "',registracijski_broj='" + this.textBoxRegistracijskaOznaka.Text+ "',naziv_automobila='" + this.textBoxNaziv.Text+ "',cijena_iznajmljivanja='" + this.textBoxCijena.Text+ "' where ID_automobila='" + this.comboBoxAzuriraj.Text+ "';";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Automobil ažuriran!");
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
                string upit = "Select * from automobil where ID_automobila='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string kuca = (string)reader["ID_kuce"].ToString();
                    comboBoxKuca.Text = kuca;
                    string klasa = (string)reader["ID_tipa"].ToString();
                    comboBoxKlasa.Text = klasa;
                    string proizvodac = (string)reader["ID_proizvodaca"].ToString();
                    comboBoxProizvodac.Text = proizvodac;
                    string boja = (string)reader["boja_automobila"].ToString();
                    textBoxBoja.Text = boja;
                    string potrosnja = (string)reader["potrosnja_automobila"].ToString();
                    textBoxPotrosnja.Text= potrosnja;
                    string datum = (string)reader["datum_kupnje"].ToString();
                    dateTimePicker1.Value= Convert.ToDateTime(datum);
                    string vrsta_pogona = (string)reader["vrsta_pogona"].ToString();
                    textBoxVrstaPogona.Text = vrsta_pogona;
                    string registracija = (string)reader["registracijski_broj"].ToString();
                    textBoxRegistracijskaOznaka.Text = registracija;
                    string naziv = (string)reader["naziv_automobila"].ToString();
                    textBoxNaziv.Text = naziv;
                    string cijena = (string)reader["cijena_iznajmljivanja"].ToString();
                    textBoxCijena.Text = cijena;

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
