namespace Rent_a_car
{
    partial class IspisProizvodaca
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
            this.gridViewProizvodaci = new System.Windows.Forms.DataGridView();
            this.Natrag = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProizvodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewProizvodaci
            // 
            this.gridViewProizvodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProizvodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProizvodaci.Location = new System.Drawing.Point(13, 13);
            this.gridViewProizvodaci.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewProizvodaci.Name = "gridViewProizvodaci";
            this.gridViewProizvodaci.Size = new System.Drawing.Size(583, 322);
            this.gridViewProizvodaci.TabIndex = 0;
            this.gridViewProizvodaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProizvodaci_CellContentClick);
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(485, 345);
            this.Natrag.Margin = new System.Windows.Forms.Padding(4);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(111, 28);
            this.Natrag.TabIndex = 1;
            this.Natrag.Text = "Izbornik ispisa";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 345);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(111, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisProizvodaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 386);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.gridViewProizvodaci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisProizvodaca";
            this.Text = "Ispis proizvođača";
            this.Load += new System.EventHandler(this.IspisProizvodaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProizvodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewProizvodaci;
        private System.Windows.Forms.Button Natrag;
        private System.Windows.Forms.Button buttonUnos;
    }
}