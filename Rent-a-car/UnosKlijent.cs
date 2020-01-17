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
    public partial class UnosKlijent : Form
    {
        public UnosKlijent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void UnosKlijent_Load(object sender, EventArgs e)
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
                comboBoxPostanski.DisplayMember = "Sve";
                comboBoxPostanski.ValueMember = "postanski_broj";
                comboBoxPostanski.DataSource = tb;
                connection.Close();

                upit = "Select * from klijent";
                connection.Open();
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSifra.Items.Add(reader.GetString("ID_klijenta"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_klijenta"));

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            IspisKlijenta ispisKlijenta = new IspisKlijenta();
            ispisKlijenta.ShowDialog();
            this.Close();
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "insert into klijent(ID_klijenta,adresa,broj_vozacke_dozvole,ime_klijenta,prezime_klijenta,telefon,email_adresa,postanski_broj) values(default,'" +this.textBoxAdresa.Text+ "','" +this.textBoxVozacka.Text+ "','" +this.textBoxIme.Text+ "','" + this.textBoxPrezime.Text+ "','" + this.textBoxTelefon.Text+ "','" + this.textBoxEmailAdresa.Text+ "','" + this.comboBoxPostanski.SelectedValue+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos novog klijenta uspješan!");
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
                string upit = "delete from klijent where ID_klijenta = '" + this.comboBoxSifra.Text + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Klijent izbrisan!");
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
                string upit = "update klijent set adresa='" +this.textBoxAdresa.Text+ "',broj_vozacke_dozvole='" +this.textBoxVozacka.Text+ "',ime_klijenta='" +this.textBoxIme.Text+ "', prezime_klijenta='" + this.textBoxPrezime.Text+ "',telefon='" + this.textBoxTelefon.Text+ "',email_adresa='" + this.textBoxEmailAdresa.Text+ "',postanski_broj='" + this.comboBoxPostanski.SelectedValue+ "' where ID_klijenta='" + this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Klijent ažuriran!");
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
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "Select * from klijent where ID_klijenta='" +this.comboBoxAzuriraj.Text+ "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string adresa = (string)reader["adresa"].ToString();
                    textBoxAdresa.Text = adresa;
                    string vozacka = (string)reader["broj_vozacke_dozvole"].ToString();
                    textBoxVozacka.Text = vozacka;
                    string ime = (string)reader["ime_klijenta"].ToString();
                    textBoxIme.Text = ime;
                    string prezime = (string)reader["prezime_klijenta"].ToString();
                    textBoxPrezime.Text = prezime;
                    string telefon = (string)reader["telefon"].ToString();
                    textBoxTelefon.Text = telefon;
                    string mail = (string)reader["email_adresa"].ToString();
                    textBoxEmailAdresa.Text = mail;
                    string postanski = (string)reader["postanski_broj"].ToString();
                    comboBoxPostanski.Text = postanski;

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
