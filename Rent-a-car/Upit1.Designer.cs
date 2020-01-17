namespace Rent_a_car
{
    partial class Upit1
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
            this.dataGridViewUpit1 = new System.Windows.Forms.DataGridView();
            this.Natrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUpit1
            // 
            this.dataGridViewUpit1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpit1.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUpit1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUpit1.Name = "dataGridViewUpit1";
            this.dataGridViewUpit1.Size = new System.Drawing.Size(678, 259);
            this.dataGridViewUpit1.TabIndex = 2;
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(580, 280);
            this.Natrag.Margin = new System.Windows.Forms.Padding(4);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(111, 28);
            this.Natrag.TabIndex = 3;
            this.Natrag.Text = "Natrag";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // Upit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.dataGridViewUpit1);
            this.Name = "Upit1";
            this.Text = "Upit1";
            this.Load += new System.EventHandler(this.Upit1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUpit1;
        private System.Windows.Forms.Button Natrag;
    }
}