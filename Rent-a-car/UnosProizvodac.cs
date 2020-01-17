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
    public partial class UnosProizvodac : Form
    {
        public UnosProizvodac()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void UnosProizvodac_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
            string upit = "Select * from proizvodac";
            connection.Open();
            MySqlCommand command = new MySqlCommand(upit, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxSifra.Items.Add(reader.GetString("ID_proizvodaca"));
                comboBoxAzuriraj.Items.Add(reader.GetString("ID_proizvodaca"));

            }
            connection.Close();
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
            IspisProizvodaca ispisProizvodaca = new IspisProizvodaca();
            ispisProizvodaca.ShowDialog();
            this.Close();
        }

        private void ButtonUnos_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                string Upit = "insert into proizvodac(ID_proizvodaca,naziv_proizvodaca) values(default,'" +this.textBoxNaziv.Text+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos novog proizvođača automobila uspješan!");
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
                string upit = "delete from proizvodac where ID_proizvodaca = '" +this.comboBoxSifra.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Proizvođač izbrisan!");
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
                string upit = "update proizvodac set naziv_proizvodaca='" +this.textBoxNaziv.Text+ "'where ID_proizvodaca='" +this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Proizvođač automobila je ažuriran!");
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
                string upit = "Select * from proizvodac where ID_proizvodaca='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string naziv = (string)reader["naziv_proizvodaca"].ToString();
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
