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
    public partial class IzbornikIspisa : Form
    {
        public IzbornikIspisa()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label2.MaximumSize = new Size(220, 0);
            label2.AutoSize = true;
            pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

        private void Ispis_proizvodaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisProizvodaca izbornik = new IspisProizvodaca();
            izbornik.ShowDialog();
            this.Close();
        }

        private void ButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna_stranica pocetna = new Pocetna_stranica();
            pocetna.ShowDialog();
            this.Close();
        }

        private void IspisKlasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisKlasa nova = new IspisKlasa();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonIspisGradova_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisGradova nova = new IspisGradova();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonIspisZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisZaposlenika nova = new IspisZaposlenika();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonIspisKlijenata_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisKlijenta nova = new IspisKlijenta();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonOsiguravajućeKuće_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisOsiguravajucihKuca nova = new IspisOsiguravajucihKuca();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonIspisLokacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisLokacija nova = new IspisLokacija();
            nova.ShowDialog();
            this.Close();
        }

        private void EvidencijaZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisEvidencijeZaposlenika nova = new IspisEvidencijeZaposlenika();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonIspisIznajmljivanja_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisIznajmljivanja nova = new IspisIznajmljivanja();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisAutomobila_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisAutomobila nova = new IspisAutomobila();
            nova.ShowDialog();
            this.Close();
        }

        private void IspisRacuna_Click(object sender, EventArgs e)
        {
            this.Hide();
            IspisRacuna nova = new IspisRacuna();
            nova.ShowDialog();
            this.Close();
        }

        private void IzbornikIspisa_Load(object sender, EventArgs e)
        {

        }
    }
}
