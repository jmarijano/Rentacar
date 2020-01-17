namespace Rent_a_car
{
    partial class UnosKlasaAutomobila
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonKlase = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSifra = new System.Windows.Forms.ComboBox();
            this.comboBoxAzuriraj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv klase:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(102, 73);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(132, 22);
            this.textBoxNaziv.TabIndex = 2;
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(432, 179);
            this.buttonNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(100, 28);
            this.buttonNatrag.TabIndex = 8;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.ButtonNatrag_Click);
            // 
            // buttonKlase
            // 
            this.buttonKlase.Location = new System.Drawing.Point(13, 179);
            this.buttonKlase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKlase.Name = "buttonKlase";
            this.buttonKlase.Size = new System.Drawing.Size(100, 28);
            this.buttonKlase.TabIndex = 7;
            this.buttonKlase.Text = "Ispis klasa";
            this.buttonKlase.UseVisualStyleBackColor = true;
            this.buttonKlase.Click += new System.EventHandler(this.ButtonKlase_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(102, 103);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(132, 28);
            this.buttonUnos.TabIndex = 3;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(393, 70);
            this.buttonIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(139, 28);
            this.buttonIzbrisi.TabIndex = 6;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.ButtonIzbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Šifra klase:";
            // 
            // comboBoxSifra
            // 
            this.comboBoxSifra.FormattingEnabled = true;
            this.comboBoxSifra.Location = new System.Drawing.Point(393, 39);
            this.comboBoxSifra.Name = "comboBoxSifra";
            this.comboBoxSifra.Size = new System.Drawing.Size(140, 24);
            this.comboBoxSifra.TabIndex = 5;
            // 
            // comboBoxAzuriraj
            // 
            this.comboBoxAzuriraj.FormattingEnabled = true;
            this.comboBoxAzuriraj.Location = new System.Drawing.Point(102, 39);
            this.comboBoxAzuriraj.Name = "comboBoxAzuriraj";
            this.comboBoxAzuriraj.Size = new System.Drawing.Size(132, 24);
            this.comboBoxAzuriraj.TabIndex = 1;
            this.comboBoxAzuriraj.SelectedIndexChanged += new System.EventHandler(this.comboBoxAzuriraj_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Šifra klase:";
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(102, 139);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(132, 28);
            this.buttonAzuriraj.TabIndex = 4;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.ButtonAzuriraj_Click);
            // 
            // UnosKlasaAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 220);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.comboBoxAzuriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSifra);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.buttonKlase);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnosKlasaAutomobila";
            this.Text = "UnosKlasaAutomobila";
            this.Load += new System.EventHandler(this.UnosKlasaAutomobila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonKlase;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSifra;
        private System.Windows.Forms.ComboBox comboBoxAzuriraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAzuriraj;
    }
}