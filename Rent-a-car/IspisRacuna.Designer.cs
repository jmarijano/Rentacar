namespace Rent_a_car
{
    partial class IspisRacuna
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
            this.NatragRacun = new System.Windows.Forms.Button();
            this.dataGridViewRacun = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragRacun
            // 
            this.NatragRacun.Location = new System.Drawing.Point(661, 280);
            this.NatragRacun.Margin = new System.Windows.Forms.Padding(4);
            this.NatragRacun.Name = "NatragRacun";
            this.NatragRacun.Size = new System.Drawing.Size(109, 28);
            this.NatragRacun.TabIndex = 0;
            this.NatragRacun.Text = "Izbornik ispisa";
            this.NatragRacun.UseVisualStyleBackColor = true;
            this.NatragRacun.Click += new System.EventHandler(this.NatragRacun_Click);
            // 
            // dataGridViewRacun
            // 
            this.dataGridViewRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacun.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewRacun.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRacun.Name = "dataGridViewRacun";
            this.dataGridViewRacun.Size = new System.Drawing.Size(753, 259);
            this.dataGridViewRacun.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(109, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewRacun);
            this.Controls.Add(this.NatragRacun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisRacuna";
            this.Text = "IspisRacuna";
            this.Load += new System.EventHandler(this.IspisRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragRacun;
        private System.Windows.Forms.DataGridView dataGridViewRacun;
        private System.Windows.Forms.Button buttonUnos;
    }
}