namespace Rent_a_car
{
    partial class IspisKlasa
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
            this.NatragKlasa = new System.Windows.Forms.Button();
            this.GridViewKlasa = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKlasa)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragKlasa
            // 
            this.NatragKlasa.Location = new System.Drawing.Point(416, 217);
            this.NatragKlasa.Margin = new System.Windows.Forms.Padding(4);
            this.NatragKlasa.Name = "NatragKlasa";
            this.NatragKlasa.Size = new System.Drawing.Size(108, 28);
            this.NatragKlasa.TabIndex = 0;
            this.NatragKlasa.Text = "Izbornik ispisa";
            this.NatragKlasa.UseVisualStyleBackColor = true;
            this.NatragKlasa.Click += new System.EventHandler(this.NatragKlasa_Click);
            // 
            // GridViewKlasa
            // 
            this.GridViewKlasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewKlasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewKlasa.Location = new System.Drawing.Point(13, 13);
            this.GridViewKlasa.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewKlasa.Name = "GridViewKlasa";
            this.GridViewKlasa.Size = new System.Drawing.Size(511, 196);
            this.GridViewKlasa.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 217);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(108, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // IspisKlasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 258);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.GridViewKlasa);
            this.Controls.Add(this.NatragKlasa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisKlasa";
            this.Text = "Ispis klasa automobila";
            this.Load += new System.EventHandler(this.IspisKlasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKlasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragKlasa;
        private System.Windows.Forms.DataGridView GridViewKlasa;
        private System.Windows.Forms.Button buttonUnos;
    }
}