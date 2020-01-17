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
    public partial class UnosKlasaAutomobila : Form
    {
        public UnosKlasaAutomobila()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa izbornik = new IzbornikUnosa();
            izbornik.ShowDialog();
            this.Close();
        }

        private void ButtonKlase_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisKlasa ispisKlasa = new IspisKlasa();
            ispisKlasa.ShowDialog();
            this.Close();
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "insert into klasa_automobila(ID_tipa,naziv_tipa) values(default,'" +this.textBoxNaziv.Text+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos nove klase automobila uspješan!");
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
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        private void UnosKlasaAutomobila_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "Select * from klasa_automobila";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSifra.Items.Add(reader.GetString("ID_tipa"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_tipa"));

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from klasa_automobila where ID_tipa = '" + this.comboBoxSifra.Text + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Klasa automobila izbrisana!");
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
                string upit = "update klasa_automobila set naziv_tipa='" +this.textBoxNaziv.Text+ "' where ID_tipa='" +this.comboBoxAzuriraj.Text+ "';";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Klasa automobila je ažurirana!");
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
                string upit = "Select * from klasa_automobila where ID_tipa='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string naziv = (string)reader["naziv_tipa"].ToString();
                    textBoxNaziv.Text = naziv;
                    
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
