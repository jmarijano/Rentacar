namespace Rent_a_car
{
    partial class Upit2
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
            this.dataGridViewUpit2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit2)).BeginInit();
            this.SuspendLayout();
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(587, 292);
            this.Natrag.Margin = new System.Windows.Forms.Padding(4);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(111, 28);
            this.Natrag.TabIndex = 5;
            this.Natrag.Text = "Natrag";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // dataGridViewUpit2
            // 
            this.dataGridViewUpit2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpit2.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUpit2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUpit2.Name = "dataGridViewUpit2";
            this.dataGridViewUpit2.Size = new System.Drawing.Size(685, 259);
            this.dataGridViewUpit2.TabIndex = 4;
            // 
            // Upit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 333);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.dataGridViewUpit2);
            this.Name = "Upit2";
            this.Text = "Upit2";
            this.Load += new System.EventHandler(this.Upit2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Natrag;
        private System.Windows.Forms.DataGridView dataGridViewUpit2;
    }
}