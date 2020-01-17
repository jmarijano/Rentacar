namespace Rent_a_car
{
    partial class IspisGradova
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
            this.GridViewGradovi = new System.Windows.Forms.DataGridView();
            this.NatragGradovi = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewGradovi
            // 
            this.GridViewGradovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGradovi.Location = new System.Drawing.Point(13, 13);
            this.GridViewGradovi.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewGradovi.Name = "GridViewGradovi";
            this.GridViewGradovi.Size = new System.Drawing.Size(353, 259);
            this.GridViewGradovi.TabIndex = 0;
            // 
            // NatragGradovi
            // 
            this.NatragGradovi.Location = new System.Drawing.Point(250, 280);
            this.NatragGradovi.Margin = new System.Windows.Forms.Padding(4);
            this.NatragGradovi.Name = "NatragGradovi";
            this.NatragGradovi.Size = new System.Drawing.Size(116, 28);
            this.NatragGradovi.TabIndex = 1;
            this.NatragGradovi.Text = "Izbornik ispisa";
            this.NatragGradovi.UseVisualStyleBackColor = true;
            this.NatragGradovi.Click += new System.EventHandler(this.NatragGradovi_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(116, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // IspisGradova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.NatragGradovi);
            this.Controls.Add(this.GridViewGradovi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisGradova";
            this.Text = "Ispis gradova";
            this.Load += new System.EventHandler(this.IspisGradova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGradovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewGradovi;
        private System.Windows.Forms.Button NatragGradovi;
        private System.Windows.Forms.Button buttonUnos;
    }
}