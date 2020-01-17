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
    public partial class UnosLokacija : Form
    {
        public UnosLokacija()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            IspisLokacija ispisLokacija = new IspisLokacija();
            ispisLokacija.ShowDialog();
            this.Close();
        }

        private void UnosLokacija_Load(object sender, EventArgs e)
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
                DataTable dataTable = new DataTable("osiguravajuca_kuca");
                upit = "Select * from osiguravajuca_kuca";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                comboBoxSifraKuce.DisplayMember = "naziv_kuce";
                comboBoxSifraKuce.ValueMember = "ID_kuce";
                comboBoxSifraKuce.DataSource = dataTable;
                connection.Close();

                connection.Open();
                upit = "Select * from lokacija";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxIzbrisiLokacija.Items.Add(reader.GetString("lokacija"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("lokacija"));
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
                string Upit = "insert into lokacija(ID_kuce,postanski_broj,lokacija) values('" +this.comboBoxSifraKuce.SelectedValue+ "','" + this.comboBoxPostanskiBroj.SelectedValue+ "','" + this.textBoxLokacija.Text+ "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Unos nove lokacije uspješan!");
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
                string upit = "delete from lokacija where lokacija = '" +this.comboBoxIzbrisiLokacija.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Lokacija izbrisana!");
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
                string upit = "update lokacija set ID_kuce='" +this.comboBoxSifraKuce.SelectedValue+ "',postanski_broj='" + this.comboBoxPostanskiBroj.SelectedValue+ "'where lokacija='" + this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Lokacija je ažurirana!");
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
                string upit = "Select * from lokacija where lokacija='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string kuca = (string)reader["ID_kuce"].ToString();
                    comboBoxSifraKuce.Text = kuca;
                    string postanski= (string)reader["postanski_broj"].ToString();
                    comboBoxPostanskiBroj.Text = postanski;
                    
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
