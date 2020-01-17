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
    public partial class Pocetna_stranica : Form
    {
        public Pocetna_stranica()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label3.MaximumSize = new Size(220, 0);
            label3.AutoSize = true;
            pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
            Izlaz_iz_baze_podataka.Left = (this.ClientSize.Width - Izlaz_iz_baze_podataka.Width) / 2;
            Izlaz_iz_baze_podataka.Top = (this.ClientSize.Height - Izlaz_iz_baze_podataka.Height + panel1.Height-100) / 2;
            izbornik_ispisa.Top = (this.ClientSize.Height - izbornik_ispisa.Height + panel1.Height) / 2;
            IzbornikUnosa.Top = (this.ClientSize.Height - IzbornikUnosa.Height + panel1.Height) / 2;
            buttonUpit.Left = (this.ClientSize.Width - buttonUpit.Width) / 2;

        }

        private void Izlaz_iz_baze_podataka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Izbornik_ispisa_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikIspisa novi = new IzbornikIspisa();
            novi.ShowDialog();
            this.Close();
        }

        private void IzbornikUnosa_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUnosa nova = new IzbornikUnosa();
            nova.ShowDialog();
            this.Close();
        }

        private void Pocetna_stranica_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzbornikUpit izbornikUpit = new IzbornikUpit();
            izbornikUpit.ShowDialog();
            this.Close();
        }
    }
}
