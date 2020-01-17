namespace Rent_a_car
{
    partial class UnosProizvodac
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxSifra = new System.Windows.Forms.ComboBox();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.comboBoxAzuriraj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(552, 186);
            this.buttonNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(144, 28);
            this.buttonNatrag.TabIndex = 8;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.ButtonNatrag_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(13, 186);
            this.buttonIspis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(144, 28);
            this.buttonIspis.TabIndex = 7;
            this.buttonIspis.Text = "Ispis proizvođača";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.ButtonIspis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv proizvođača:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(165, 79);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(147, 22);
            this.textBoxNaziv.TabIndex = 2;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(165, 109);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(147, 28);
            this.buttonUnos.TabIndex = 3;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(547, 77);
            this.buttonIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(148, 28);
            this.buttonIzbrisi.TabIndex = 6;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.ButtonIzbrisi_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(395, 49);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 16);
            this.label.TabIndex = 7;
            this.label.Text = "Šifra proizvođača:";
            // 
            // comboBoxSifra
            // 
            this.comboBoxSifra.FormattingEnabled = true;
            this.comboBoxSifra.Location = new System.Drawing.Point(547, 46);
            this.comboBoxSifra.Name = "comboBoxSifra";
            this.comboBoxSifra.Size = new System.Drawing.Size(148, 24);
            this.comboBoxSifra.TabIndex = 5;
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(165, 145);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(147, 28);
            this.buttonAzuriraj.TabIndex = 4;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.ButtonAzuriraj_Click);
            // 
            // comboBoxAzuriraj
            // 
            this.comboBoxAzuriraj.FormattingEnabled = true;
            this.comboBoxAzuriraj.Location = new System.Drawing.Point(165, 46);
            this.comboBoxAzuriraj.Name = "comboBoxAzuriraj";
            this.comboBoxAzuriraj.Size = new System.Drawing.Size(148, 24);
            this.comboBoxAzuriraj.TabIndex = 1;
            this.comboBoxAzuriraj.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAzuriraj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Šifra proizvođača:";
            // 
            // UnosProizvodac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 227);
            this.Controls.Add(this.comboBoxAzuriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.comboBoxSifra);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonNatrag);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnosProizvodac";
            this.Text = "Unos proizvođača";
            this.Load += new System.EventHandler(this.UnosProizvodac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxSifra;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.ComboBox comboBoxAzuriraj;
        private System.Windows.Forms.Label label1;
    }
}