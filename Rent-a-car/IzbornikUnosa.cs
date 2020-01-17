using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_car
{
    public partial class IzbornikUnosa : Form
    {
        public IzbornikUnosa()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
            label1.MaximumSize = new Size(220, 0);
            label1.AutoSize = true;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
        }

        private void NatragUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna_stranica nova = new Pocetna_stranica();
            nova.ShowDialog();
            this.Close();
        }

        private void UnosGrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosGrada nova = new UnosGrada();
            nova.ShowDialog();
            this.Close();
        }

        private void UnosZaposlenik_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosZaposlenici nova = new UnosZaposlenici();
            nova.ShowDialog();
            this.Close();
        }

        private void IzbornikUnosa_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAutomobil_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosAutomobil nova = new UnosAutomobil();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonLokacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosLokacija nova = new UnosLokacija();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonEvidencija_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosEvidencija nova = new UnosEvidencija();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonEvidencijaZaposlenik_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosEvidencijaZaposlenik nova = new UnosEvidencijaZaposlenik();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonKlasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosKlasaAutomobila nova = new UnosKlasaAutomobila();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonKlijent_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosKlijent nova = new UnosKlijent();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonRacun_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosRacun nova = new UnosRacun();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonOsiguravajucaKuca_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosOsiguravajucaKuca nova = new UnosOsiguravajucaKuca();
            nova.ShowDialog();
            this.Close();
        }

        private void ButtonProizvodac_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosProizvodac nova = new UnosProizvodac();
            nova.ShowDialog();
            this.Close();
        }
    }
}
