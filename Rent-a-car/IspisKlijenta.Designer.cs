namespace Rent_a_car
{
    partial class IspisKlijenta
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
            this.NatragKlijenti = new System.Windows.Forms.Button();
            this.dataGridViewKlijent = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijent)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragKlijenti
            // 
            this.NatragKlijenti.Location = new System.Drawing.Point(936, 280);
            this.NatragKlijenti.Margin = new System.Windows.Forms.Padding(4);
            this.NatragKlijenti.Name = "NatragKlijenti";
            this.NatragKlijenti.Size = new System.Drawing.Size(112, 28);
            this.NatragKlijenti.TabIndex = 0;
            this.NatragKlijenti.Text = "Izbornik ispisa";
            this.NatragKlijenti.UseVisualStyleBackColor = true;
            this.NatragKlijenti.Click += new System.EventHandler(this.NatragKlijenti_Click);
            // 
            // dataGridViewKlijent
            // 
            this.dataGridViewKlijent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlijent.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewKlijent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKlijent.Name = "dataGridViewKlijent";
            this.dataGridViewKlijent.Size = new System.Drawing.Size(1035, 259);
            this.dataGridViewKlijent.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(112, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewKlijent);
            this.Controls.Add(this.NatragKlijenti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisKlijenta";
            this.Text = "Ispis klijenata";
            this.Load += new System.EventHandler(this.IspisKlijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragKlijenti;
        private System.Windows.Forms.DataGridView dataGridViewKlijent;
        private System.Windows.Forms.Button buttonUnos;
    }
}