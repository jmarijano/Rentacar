namespace Rent_a_car
{
    partial class IspisEvidencijeZaposlenika
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
            this.NatragEvidencijaZaposlenika = new System.Windows.Forms.Button();
            this.dataGridViewEvidencijaZaposlenika = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvidencijaZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragEvidencijaZaposlenika
            // 
            this.NatragEvidencijaZaposlenika.Location = new System.Drawing.Point(624, 280);
            this.NatragEvidencijaZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.NatragEvidencijaZaposlenika.Name = "NatragEvidencijaZaposlenika";
            this.NatragEvidencijaZaposlenika.Size = new System.Drawing.Size(111, 28);
            this.NatragEvidencijaZaposlenika.TabIndex = 0;
            this.NatragEvidencijaZaposlenika.Text = "Izbornik ispisa";
            this.NatragEvidencijaZaposlenika.UseVisualStyleBackColor = true;
            this.NatragEvidencijaZaposlenika.Click += new System.EventHandler(this.NatragEvidencijaZaposlenika_Click);
            // 
            // dataGridViewEvidencijaZaposlenika
            // 
            this.dataGridViewEvidencijaZaposlenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvidencijaZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvidencijaZaposlenika.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewEvidencijaZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEvidencijaZaposlenika.Name = "dataGridViewEvidencijaZaposlenika";
            this.dataGridViewEvidencijaZaposlenika.Size = new System.Drawing.Size(722, 259);
            this.dataGridViewEvidencijaZaposlenika.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(12, 283);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(111, 23);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisEvidencijeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewEvidencijaZaposlenika);
            this.Controls.Add(this.NatragEvidencijaZaposlenika);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisEvidencijeZaposlenika";
            this.Text = "Ispis evidencije o zaposleniku";
            this.Load += new System.EventHandler(this.IspisEvidencijeZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvidencijaZaposlenika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragEvidencijaZaposlenika;
        private System.Windows.Forms.DataGridView dataGridViewEvidencijaZaposlenika;
        private System.Windows.Forms.Button buttonUnos;
    }
}