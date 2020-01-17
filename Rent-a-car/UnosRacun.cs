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
    public partial class UnosRacun : Form
    {
        public UnosRacun()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void ButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornikUnosa = new IzbornikUnosa();
            izbornikUnosa.ShowDialog();
            this.Close();
        }

        private void ButtonIspis_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisRacuna ispisRacuna = new IspisRacuna();
            ispisRacuna.ShowDialog();
            this.Close();
        }

        private void UnosRacun_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = new DataTable("klijent");
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "select evidencija.ID_evidencije, automobil.naziv_automobila,klijent.ime_klijenta,klijent.prezime_klijenta from evidencija,klijent,automobil where evidencija.ID_klijenta= klijent.ID_klijenta and evidencija.ID_automobila= automobil.ID_automobila;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tb.Load(reader);
                tb.Columns.Add("Fullname", typeof(string), "ID_evidencije + '| ' + naziv_automobila + ' | ' + ime_klijenta + ' ' + prezime_klijenta");
                comboBoxSifra.DisplayMember = "Fullname";
                comboBoxSifra.ValueMember = "ID_evidencije";
                comboBoxSifra.DataSource = tb;
                connection.Close();

                connection.Open();
                upit = "select * from racun";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRacun.Items.Add(reader.GetString("ID_racuna"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_racuna"));
                }
                connection.Close();
            }
            catch(Exception ex)
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
                string Upit = "insert into racun(ID_racuna,datum_izdavanja,nacin_placanja,ID_evidencije) values(default,'" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")+ "','" +this.textBoxNacin.Text+ "','" +this.comboBoxSifra.SelectedValue+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos novog računa uspješan!");
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

        private void ButtonIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from racun where ID_racuna = '" + this.comboBoxRacun.Text + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Račun je izbrisan!");
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
                string upit = "update racun set datum_izdavanja='" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "',nacin_placanja='" + this.textBoxNacin.Text+ "',ID_evidencije='" + this.comboBoxSifra.SelectedValue+ "'where ID_racuna='" + this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Račun je ažuriran!");
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

        private void comboBoxAzuriraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=;convert zero datetime=True");
                string upit = "Select * from racun where ID_racuna='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string datum = (string)reader["datum_izdavanja"].ToString();
                    dateTimePicker1.Value =Convert.ToDateTime(datum);
                    string nacin = (string)reader["nacin_placanja"].ToString();
                    textBoxNacin.Text = nacin;
                    string evidencija = (string)reader["ID_evidencije"].ToString();
                    comboBoxSifra.Text = evidencija;
                    

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
