namespace Rent_a_car
{
    partial class IspisAutomobila
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
            this.NatragIspisAutomobila = new System.Windows.Forms.Button();
            this.dataGridViewAutomobil = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomobil)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragIspisAutomobila
            // 
            this.NatragIspisAutomobila.Location = new System.Drawing.Point(1566, 280);
            this.NatragIspisAutomobila.Margin = new System.Windows.Forms.Padding(4);
            this.NatragIspisAutomobila.Name = "NatragIspisAutomobila";
            this.NatragIspisAutomobila.Size = new System.Drawing.Size(126, 28);
            this.NatragIspisAutomobila.TabIndex = 0;
            this.NatragIspisAutomobila.Text = "Izbornik ispisa";
            this.NatragIspisAutomobila.UseVisualStyleBackColor = true;
            this.NatragIspisAutomobila.Click += new System.EventHandler(this.NatragIspisAutomobila_Click);
            // 
            // dataGridViewAutomobil
            // 
            this.dataGridViewAutomobil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAutomobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutomobil.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAutomobil.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAutomobil.Name = "dataGridViewAutomobil";
            this.dataGridViewAutomobil.Size = new System.Drawing.Size(1679, 257);
            this.dataGridViewAutomobil.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(126, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewAutomobil);
            this.Controls.Add(this.NatragIspisAutomobila);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisAutomobila";
            this.Text = "IspisAutomobila";
            this.Load += new System.EventHandler(this.IspisAutomobila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomobil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragIspisAutomobila;
        private System.Windows.Forms.DataGridView dataGridViewAutomobil;
        private System.Windows.Forms.Button buttonUnos;
    }
}