namespace Rent_a_car
{
    partial class IspisOsiguravajucihKuca
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
            this.NatragOsiguravajuceKuce = new System.Windows.Forms.Button();
            this.dataGridViewOsiguravajuceKuce = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsiguravajuceKuce)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragOsiguravajuceKuce
            // 
            this.NatragOsiguravajuceKuce.Location = new System.Drawing.Point(679, 280);
            this.NatragOsiguravajuceKuce.Margin = new System.Windows.Forms.Padding(4);
            this.NatragOsiguravajuceKuce.Name = "NatragOsiguravajuceKuce";
            this.NatragOsiguravajuceKuce.Size = new System.Drawing.Size(112, 28);
            this.NatragOsiguravajuceKuce.TabIndex = 0;
            this.NatragOsiguravajuceKuce.Text = "Izbornik ispisa";
            this.NatragOsiguravajuceKuce.UseVisualStyleBackColor = true;
            this.NatragOsiguravajuceKuce.Click += new System.EventHandler(this.NatragOsiguravajuceKuce_Click);
            // 
            // dataGridViewOsiguravajuceKuce
            // 
            this.dataGridViewOsiguravajuceKuce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOsiguravajuceKuce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsiguravajuceKuce.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewOsiguravajuceKuce.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOsiguravajuceKuce.Name = "dataGridViewOsiguravajuceKuce";
            this.dataGridViewOsiguravajuceKuce.Size = new System.Drawing.Size(778, 259);
            this.dataGridViewOsiguravajuceKuce.TabIndex = 1;
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
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // IspisOsiguravajucihKuca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewOsiguravajuceKuce);
            this.Controls.Add(this.NatragOsiguravajuceKuce);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisOsiguravajucihKuca";
            this.Text = "Ispis osiguravajućih kuća";
            this.Load += new System.EventHandler(this.IspisOsiguravajucihKuca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsiguravajuceKuce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragOsiguravajuceKuce;
        private System.Windows.Forms.DataGridView dataGridViewOsiguravajuceKuce;
        private System.Windows.Forms.Button buttonUnos;
    }
}