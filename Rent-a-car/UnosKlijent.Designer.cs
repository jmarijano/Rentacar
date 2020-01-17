namespace Rent_a_car
{
    partial class UnosKlijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPostanski = new System.Windows.Forms.ComboBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxVozacka = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmailAdresa = new System.Windows.Forms.TextBox();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.comboBoxSifra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.comboBoxAzuriraj = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(584, 360);
            this.buttonNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(109, 28);
            this.buttonNatrag.TabIndex = 14;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.ButtonNatrag_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(13, 360);
            this.buttonIspis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(109, 28);
            this.buttonIspis.TabIndex = 13;
            this.buttonIspis.Text = "Ispis klijenata";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.ButtonIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj vozačke dozvole:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "E - mail adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poštanski broj:";
            // 
            // comboBoxPostanski
            // 
            this.comboBoxPostanski.FormattingEnabled = true;
            this.comboBoxPostanski.Location = new System.Drawing.Point(173, 251);
            this.comboBoxPostanski.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPostanski.Name = "comboBoxPostanski";
            this.comboBoxPostanski.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPostanski.TabIndex = 8;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(173, 71);
            this.textBoxAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(160, 22);
            this.textBoxAdresa.TabIndex = 2;
            // 
            // textBoxVozacka
            // 
            this.textBoxVozacka.Location = new System.Drawing.Point(173, 101);
            this.textBoxVozacka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVozacka.Name = "textBoxVozacka";
            this.textBoxVozacka.Size = new System.Drawing.Size(160, 22);
            this.textBoxVozacka.TabIndex = 3;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(173, 131);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(160, 22);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(173, 161);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(160, 22);
            this.textBoxPrezime.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(173, 191);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(160, 22);
            this.textBoxTelefon.TabIndex = 6;
            // 
            // textBoxEmailAdresa
            // 
            this.textBoxEmailAdresa.Location = new System.Drawing.Point(173, 221);
            this.textBoxEmailAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailAdresa.Name = "textBoxEmailAdresa";
            this.textBoxEmailAdresa.Size = new System.Drawing.Size(160, 22);
            this.textBoxEmailAdresa.TabIndex = 7;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(173, 283);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(160, 28);
            this.buttonUnos.TabIndex = 9;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // comboBoxSifra
            // 
            this.comboBoxSifra.FormattingEnabled = true;
            this.comboBoxSifra.Location = new System.Drawing.Point(529, 37);
            this.comboBoxSifra.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSifra.Name = "comboBoxSifra";
            this.comboBoxSifra.Size = new System.Drawing.Size(164, 24);
            this.comboBoxSifra.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Šifra klijenta:";
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(529, 69);
            this.buttonIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(164, 28);
            this.buttonIzbrisi.TabIndex = 12;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.ButtonIzbrisi_Click);
            // 
            // comboBoxAzuriraj
            // 
            this.comboBoxAzuriraj.FormattingEnabled = true;
            this.comboBoxAzuriraj.Location = new System.Drawing.Point(173, 39);
            this.comboBoxAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAzuriraj.Name = "comboBoxAzuriraj";
            this.comboBoxAzuriraj.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAzuriraj.TabIndex = 1;
            this.comboBoxAzuriraj.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAzuriraj_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Šifra klijenta:";
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(173, 319);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(160, 28);
            this.buttonAzuriraj.TabIndex = 10;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.ButtonAzuriraj_Click);
            // 
            // UnosKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 401);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.comboBoxAzuriraj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.comboBoxSifra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.textBoxEmailAdresa);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxVozacka);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.comboBoxPostanski);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonNatrag);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnosKlijent";
            this.Text = "UnosKlijent";
            this.Load += new System.EventHandler(this.UnosKlijent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPostanski;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxVozacka;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxEmailAdresa;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.ComboBox comboBoxSifra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.ComboBox comboBoxAzuriraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAzuriraj;
    }
}