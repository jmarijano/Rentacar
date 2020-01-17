namespace Rent_a_car
{
    partial class IspisIznajmljivanja
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
            this.NatragIznajmljivanja = new System.Windows.Forms.Button();
            this.dataGridViewIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.buttonUnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIznajmljivanja)).BeginInit();
            this.SuspendLayout();
            // 
            // NatragIznajmljivanja
            // 
            this.NatragIznajmljivanja.Location = new System.Drawing.Point(1205, 280);
            this.NatragIznajmljivanja.Margin = new System.Windows.Forms.Padding(4);
            this.NatragIznajmljivanja.Name = "NatragIznajmljivanja";
            this.NatragIznajmljivanja.Size = new System.Drawing.Size(113, 28);
            this.NatragIznajmljivanja.TabIndex = 0;
            this.NatragIznajmljivanja.Text = "Izbornik ispisa";
            this.NatragIznajmljivanja.UseVisualStyleBackColor = true;
            this.NatragIznajmljivanja.Click += new System.EventHandler(this.NatragIznajmljivanja_Click);
            // 
            // dataGridViewIznajmljivanja
            // 
            this.dataGridViewIznajmljivanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIznajmljivanja.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewIznajmljivanja.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIznajmljivanja.Name = "dataGridViewIznajmljivanja";
            this.dataGridViewIznajmljivanja.Size = new System.Drawing.Size(1305, 259);
            this.dataGridViewIznajmljivanja.TabIndex = 1;
            // 
            // buttonUnos
            // 
            this.buttonUnos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUnos.Location = new System.Drawing.Point(13, 280);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(113, 28);
            this.buttonUnos.TabIndex = 2;
            this.buttonUnos.Text = "Izbornik unosa";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.ButtonUnos_Click);
            // 
            // IspisIznajmljivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 321);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.dataGridViewIznajmljivanja);
            this.Controls.Add(this.NatragIznajmljivanja);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IspisIznajmljivanja";
            this.Text = "Ispis iznajmljivanja";
            this.Load += new System.EventHandler(this.IspisIznajmljivanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIznajmljivanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NatragIznajmljivanja;
        private System.Windows.Forms.DataGridView dataGridViewIznajmljivanja;
        private System.Windows.Forms.Button buttonUnos;
    }
}