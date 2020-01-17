namespace Rent_a_car
{
    partial class IspisLokacija
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
            this.NatragLokacija = new System.Windows.Forms.Button();
            this.dataGridViewLokacija = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLokacija)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragLokacija
            // 
            this.NatragLokacija.Location = new System.Drawing.Point(704, 280);
            this.NatragLokacija.Margin = new System.Windows.Forms.Padding(4);
            this.NatragLokacija.Name = "NatragLokacija";
            this.NatragLokacija.Size = new System.Drawing.Size(111, 28);
            this.NatragLokacija.TabIndex = 0;
            this.NatragLokacija.Text = "Izbornik ispisa";
            this.NatragLokacija.UseVisualStyleBackColor = true;
            this.NatragLokacija.Click += new System.EventHandler(this.NatragLokacija_Click);
            // 
            // dataGridViewLokacija
            // 
            this.dataGridViewLokacija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLokacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLokacija.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewLokacija.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLokacija.Name = "dataGridViewLokacija";
            this.dataGridViewLokacija.Size = new System.Drawing.Size(802, 259);
            this.dataGridViewLokacija.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(111, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewLokacija);
            this.Controls.Add(this.NatragLokacija);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisLokacija";
            this.Text = "Ispis lokacija";
            this.Load += new System.EventHandler(this.IspisLokacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLokacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragLokacija;
        private System.Windows.Forms.DataGridView dataGridViewLokacija;
        private System.Windows.Forms.Button buttonUnos;
    }
}