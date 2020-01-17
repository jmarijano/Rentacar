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
    public partial class IzbornikUpit : Form
    {
        public IzbornikUpit()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.MaximumSize = new Size(220, 0);
            label1.AutoSize = true;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
            buttonUpit2.Top = (this.ClientSize.Height - buttonUpit2.Height + panel1.Height) / 2;
            buttonUpit2.Left = (this.ClientSize.Width - buttonUpit2.Width) / 2;
            buttonUpit1.Top = (this.ClientSize.Height - buttonUpit1.Height + panel1.Height) / 2;
            buttonUpit3.Top = (this.ClientSize.Height - buttonUpit3.Height + panel1.Height) / 2;
        }

        private void IzbornikUpit_Load(object sender, EventArgs e)
        {

        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna_stranica pocetna_Stranica = new Pocetna_stranica();
            pocetna_Stranica.ShowDialog();
            this.Close();
        }

        private void ButtonUpit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upit1 upit1 = new Upit1();
            upit1.ShowDialog();
            this.Close();
        }

        private void ButtonUpit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upit2 upit2 = new Upit2();
            upit2.ShowDialog();
            this.Close();
        }

        private void ButtonUpit3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upit3 upit3 = new Upit3();
            upit3.ShowDialog();
            this.Close();
        }
    }
}
