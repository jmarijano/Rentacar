namespace Rent_a_car
{
    partial class IspisZaposlenika
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
            this.NatragGradovi = new System.Windows.Forms.Button();
            this.dataGridViewZaposlenici = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragGradovi
            // 
            this.NatragGradovi.Location = new System.Drawing.Point(1412, 209);
            this.NatragGradovi.Margin = new System.Windows.Forms.Padding(4);
            this.NatragGradovi.Name = "NatragGradovi";
            this.NatragGradovi.Size = new System.Drawing.Size(115, 28);
            this.NatragGradovi.TabIndex = 0;
            this.NatragGradovi.Text = "Izbornik ispisa";
            this.NatragGradovi.UseVisualStyleBackColor = true;
            this.NatragGradovi.Click += new System.EventHandler(this.NatragGradovi_Click);
            // 
            // dataGridViewZaposlenici
            // 
            this.dataGridViewZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenici.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewZaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewZaposlenici.Name = "dataGridViewZaposlenici";
            this.dataGridViewZaposlenici.Size = new System.Drawing.Size(1514, 188);
            this.dataGridViewZaposlenici.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 209);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(115, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 250);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewZaposlenici);
            this.Controls.Add(this.NatragGradovi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisZaposlenika";
            this.Text = "Ispis zaposlenika";
            this.Load += new System.EventHandler(this.IspisZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragGradovi;
        private System.Windows.Forms.DataGridView dataGridViewZaposlenici;
        private System.Windows.Forms.Button buttonUnos;
    }
}