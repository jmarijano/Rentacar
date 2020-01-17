namespace Rent_a_car
{
    partial class Pocetna_stranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna_stranica));
            this.Izlaz_iz_baze_podataka = new System.Windows.Forms.Button();
            this.izbornik_ispisa = new System.Windows.Forms.Button();
            this.IzbornikUnosa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Izlaz_iz_baze_podataka
            // 
            this.Izlaz_iz_baze_podataka.BackColor = System.Drawing.Color.DarkOrange;
            this.Izlaz_iz_baze_podataka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Izlaz_iz_baze_podataka.Location = new System.Drawing.Point(398, 284);
            this.Izlaz_iz_baze_podataka.Margin = new System.Windows.Forms.Padding(4);
            this.Izlaz_iz_baze_podataka.Name = "Izlaz_iz_baze_podataka";
            this.Izlaz_iz_baze_podataka.Size = new System.Drawing.Size(140, 100);
            this.Izlaz_iz_baze_podataka.TabIndex = 2;
            this.Izlaz_iz_baze_podataka.Text = "Izlaz iz aplikacije";
            this.Izlaz_iz_baze_podataka.UseVisualStyleBackColor = false;
            this.Izlaz_iz_baze_podataka.Click += new System.EventHandler(this.Izlaz_iz_baze_podataka_Click);
            // 
            // izbornik_ispisa
            // 
            this.izbornik_ispisa.BackColor = System.Drawing.Color.SteelBlue;
            this.izbornik_ispisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izbornik_ispisa.Location = new System.Drawing.Point(115, 284);
            this.izbornik_ispisa.Margin = new System.Windows.Forms.Padding(4);
            this.izbornik_ispisa.Name = "izbornik_ispisa";
            this.izbornik_ispisa.Size = new System.Drawing.Size(140, 100);
            this.izbornik_ispisa.TabIndex = 1;
            this.izbornik_ispisa.Text = "Izbornik ispisa";
            this.izbornik_ispisa.UseVisualStyleBackColor = false;
            this.izbornik_ispisa.Click += new System.EventHandler(this.Izbornik_ispisa_Click);
            // 
            // IzbornikUnosa
            // 
            this.IzbornikUnosa.BackColor = System.Drawing.Color.SteelBlue;
            this.IzbornikUnosa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IzbornikUnosa.Location = new System.Drawing.Point(620, 284);
            this.IzbornikUnosa.Margin = new System.Windows.Forms.Padding(4);
            this.IzbornikUnosa.Name = "IzbornikUnosa";
            this.IzbornikUnosa.Size = new System.Drawing.Size(140, 100);
            this.IzbornikUnosa.TabIndex = 3;
            this.IzbornikUnosa.Text = "Izbornik unosa,brisanja i ažuriranja";
            this.IzbornikUnosa.UseVisualStyleBackColor = false;
            this.IzbornikUnosa.Click += new System.EventHandler(this.IzbornikUnosa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 192);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(166, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Glavni izbornik";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(638, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(672, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rent - a - car Bambi d.o.o. Ul. Stjepana Vukovića 1 42000 Varaždin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonUpit
            // 
            this.buttonUpit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpit.Location = new System.Drawing.Point(398, 392);
            this.buttonUpit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpit.Name = "buttonUpit";
            this.buttonUpit.Size = new System.Drawing.Size(140, 100);
            this.buttonUpit.TabIndex = 4;
            this.buttonUpit.Text = "Izbornik upita";
            this.buttonUpit.UseVisualStyleBackColor = false;
            this.buttonUpit.Click += new System.EventHandler(this.buttonUpit_Click);
            // 
            // Pocetna_stranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 554);
            this.Controls.Add(this.buttonUpit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.izbornik_ispisa);
            this.Controls.Add(this.IzbornikUnosa);
            this.Controls.Add(this.Izlaz_iz_baze_podataka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pocetna_stranica";
            this.Text = "Početna stranica";
            this.Load += new System.EventHandler(this.Pocetna_stranica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Izlaz_iz_baze_podataka;
        private System.Windows.Forms.Button izbornik_ispisa;
        private System.Windows.Forms.Button IzbornikUnosa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpit;
    }
}

