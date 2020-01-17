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
    public partial class UnosEvidencija : Form
    {
        public UnosEvidencija()
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

        private void ButtonEvidencije_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisIznajmljivanja ispisIznajmljivanja = new IspisIznajmljivanja();
            ispisIznajmljivanja.ShowDialog();
            this.Close();
        }

        private void UnosEvidencija_Load(object sender, EventArgs e)
        {
            dateTimePickerKraj.Format = DateTimePickerFormat.Custom;
            dateTimePickerKraj.CustomFormat = "dd-MM-yyyy";
            dateTimePickerPocetak.Format = DateTimePickerFormat.Custom;
            dateTimePickerPocetak.CustomFormat = "dd-MM-yyyy";
            try
            {
                DataTable tb = new DataTable("klijent");
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=");
                string upit = "Select ID_klijenta,ime_klijenta,prezime_klijenta from klijent";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tb.Load(reader);
                tb.Columns.Add("Fullname", typeof(string), "ID_klijenta + ' ' + ime_klijenta + ' ' + prezime_klijenta");
                comboBoxKlijent.DisplayMember = "Fullname";
                comboBoxKlijent.ValueMember = "ID_klijenta";
                comboBoxKlijent.DataSource = tb;
                connection.Close();

                connection.Open();
                DataTable dataTable = new DataTable("automobil");
                upit = "Select ID_automobila, naziv_automobila from automobil";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                comboBoxAutomobil.DisplayMember = "naziv_automobila";
                comboBoxAutomobil.ValueMember = "ID_automobila";
                comboBoxAutomobil.DataSource = dataTable;
                connection.Close();

                connection.Open();
                upit = "SELECT * from evidencija";
                command = new MySqlCommand(upit, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxEvidencija.Items.Add(reader.GetString("ID_evidencije"));
                    comboBoxAzuriraj.Items.Add(reader.GetString("ID_evidencije"));
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
                string Upit = "insert into evidencija(ID_evidencije,ID_klijenta,ID_automobila,datum_pocetka_iznajmljivanja,datum_zavrsertka_iznajmljivanja) values (default,'" +this.comboBoxKlijent.SelectedValue+ "','" +this.comboBoxAutomobil.SelectedValue+ "','" +this.dateTimePickerPocetak.Value.Date.ToString("yyyy-MM-dd") + "','" +this.dateTimePickerKraj.Value.Date.ToString("yyyy-MM-dd") + "');";
                MySqlCommand komanda = new MySqlCommand(Upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Nova evidencija unesena!");
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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "delete from evidencija where ID_evidencije = '" + this.comboBoxEvidencija.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Evidencija izbrisana!");
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

        private void ButtonAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;database=rent_a_car;Uid=root;password=";
                string upit = "update evidencija set ID_klijenta='" +this.comboBoxKlijent.SelectedValue+ "',ID_automobila='" + this.comboBoxAutomobil.SelectedValue+ "',datum_pocetka_iznajmljivanja='" + this.dateTimePickerPocetak.Value.Date.ToString("yyyy-MM-dd") + "',datum_zavrsertka_iznajmljivanja='" + this.dateTimePickerKraj.Value.Date.ToString("yyyy-MM-dd") + "'where ID_evidencije='" + this.comboBoxAzuriraj.Text+ "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                condatabase.Open();
                MySqlCommand komanda = new MySqlCommand(upit, condatabase);
                MySqlDataReader reader;
                reader = komanda.ExecuteReader();
                MessageBox.Show("Evidencija ažurirana!");
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
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=rent_a_car;Uid=root;password=;");
                string upit = "Select * from evidencija where ID_evidencije='" + this.comboBoxAzuriraj.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(upit, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string klijent = (string)reader["ID_klijenta"].ToString();
                    comboBoxKlijent.Text = klijent;
                    string automobil = (string)reader["ID_automobila"].ToString();
                    comboBoxAutomobil.Text = automobil;
                    string datumPocetak = (string)reader["datum_pocetka_iznajmljivanja"].ToString();
                    dateTimePickerPocetak.Value = Convert.ToDateTime(datumPocetak);
                    string datumKraja = (string)reader["datum_zavrsertka_iznajmljivanja"].ToString();
                    dateTimePickerKraj.Value = Convert.ToDateTime(datumKraja);
                    
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
