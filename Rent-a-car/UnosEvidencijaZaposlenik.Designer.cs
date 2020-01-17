namespace Rent_a_car
{
    partial class UnosEvidencijaZaposlenik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxZaposlenik = new System.Windows.Forms.ComboBox();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonZaposlenik = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.comboBoxEvidencija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.comboBoxAzuriraj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.dateTimePickerKraj = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrijeme dolaska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrijeme odlaska:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Šifra zaposlenika:";
            // 
            // comboBoxZaposlenik
            // 
            this.comboBoxZaposlenik.FormattingEnabled = true;
            this.comboBoxZaposlenik.Location = new System.Drawing.Point(141, 133);
            this.comboBoxZaposlenik.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxZaposlenik.Name = "comboBoxZaposlenik";
            this.comboBoxZaposlenik.Size = new System.Drawing.Size(178, 24);
            this.comboBoxZaposlenik.TabIndex = 5;
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(526, 275);
            this.buttonNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(148, 47);
            this.buttonNatrag.TabIndex = 11;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.ButtonNatrag_Click);
            // 
            // buttonZaposlenik
            // 
            this.buttonZaposlenik.Location = new System.Drawing.Point(13, 275);
            this.buttonZaposlenik.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZaposlenik.Name = "buttonZaposlenik";
            this.buttonZaposlenik.Size = new System.Drawing.Size(149, 47);
            this.buttonZaposlenik.TabIndex = 10;
            this.buttonZaposlenik.Text = "Ispis evidencija o zaposleniku";
            this.buttonZaposlenik.UseVisualStyleBackColor = true;
            this.buttonZaposlenik.Click += new System.EventHandler(this.ButtonZaposlenik_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(141, 165);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(178, 30);
            this.buttonUnos.TabIndex = 6;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // comboBoxEvidencija
            // 
            this.comboBoxEvidencija.FormattingEnabled = true;
            this.comboBoxEvidencija.Location = new System.Drawing.Point(504, 43);
            this.comboBoxEvidencija.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEvidencija.Name = "comboBoxEvidencija";
            this.comboBoxEvidencija.Size = new System.Drawing.Size(170, 24);
            this.comboBoxEvidencija.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Šifra evidencije:";
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(504, 75);
            this.buttonIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(170, 30);
            this.buttonIzbrisi.TabIndex = 9;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxAzuriraj
            // 
            this.comboBoxAzuriraj.FormattingEnabled = true;
            this.comboBoxAzuriraj.Location = new System.Drawing.Point(141, 43);
            this.comboBoxAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAzuriraj.Name = "comboBoxAzuriraj";
            this.comboBoxAzuriraj.Size = new System.Drawing.Size(178, 24);
            this.comboBoxAzuriraj.TabIndex = 1;
            this.comboBoxAzuriraj.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAzuriraj_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Šifra evidencije:";
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(141, 203);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(178, 30);
            this.buttonAzuriraj.TabIndex = 7;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.ButtonAzuriraj_Click);
            // 
            // dateTimePickerKraj
            // 
            this.dateTimePickerKraj.Location = new System.Drawing.Point(141, 104);
            this.dateTimePickerKraj.Name = "dateTimePickerKraj";
            this.dateTimePickerKraj.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerKraj.TabIndex = 3;
            // 
            // dateTimePickerPocetak
            // 
            this.dateTimePickerPocetak.Location = new System.Drawing.Point(141, 74);
            this.dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            this.dateTimePickerPocetak.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerPocetak.TabIndex = 2;
            // 
            // UnosEvidencijaZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 335);
            this.Controls.Add(this.dateTimePickerKraj);
            this.Controls.Add(this.dateTimePickerPocetak);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.comboBoxAzuriraj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.comboBoxEvidencija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.buttonZaposlenik);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.comboBoxZaposlenik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnosEvidencijaZaposlenik";
            this.Text = "UnosEvidencijaZaposlenik";
            this.Load += new System.EventHandler(this.UnosEvidencijaZaposlenik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxZaposlenik;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonZaposlenik;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.ComboBox comboBoxEvidencija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.ComboBox comboBoxAzuriraj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.DateTimePicker dateTimePickerKraj;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetak;
    }
}