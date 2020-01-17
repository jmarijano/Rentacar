namespace Rent_a_car
{
    partial class Upit3
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
            this.Natrag = new System.Windows.Forms.Button();
            this.dataGridViewUpit3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit3)).BeginInit();
            this.SuspendLayout();
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(598, 280);
            this.Natrag.Margin = new System.Windows.Forms.Padding(4);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(111, 28);
            this.Natrag.TabIndex = 7;
            this.Natrag.Text = "Natrag";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // dataGridViewUpit3
            // 
            this.dataGridViewUpit3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpit3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpit3.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUpit3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUpit3.Name = "dataGridViewUpit3";
            this.dataGridViewUpit3.Size = new System.Drawing.Size(696, 259);
            this.dataGridViewUpit3.TabIndex = 6;
            // 
            // Upit3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 321);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.dataGridViewUpit3);
            this.Name = "Upit3";
            this.Text = "Upit3";
            this.Load += new System.EventHandler(this.Upit3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Natrag;
        private System.Windows.Forms.DataGridView dataGridViewUpit3;
    }
}