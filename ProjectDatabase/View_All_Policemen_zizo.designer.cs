namespace WindowsFormsApp3
{
    partial class View_All_Policemen
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
            this.Viewfor_all_policemen = new System.Windows.Forms.Button();
            this.dataGridView_all_policemen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_policemen)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewfor_all_policemen
            // 
            this.Viewfor_all_policemen.Location = new System.Drawing.Point(410, 38);
            this.Viewfor_all_policemen.Name = "Viewfor_all_policemen";
            this.Viewfor_all_policemen.Size = new System.Drawing.Size(75, 23);
            this.Viewfor_all_policemen.TabIndex = 3;
            this.Viewfor_all_policemen.Text = "View";
            this.Viewfor_all_policemen.UseVisualStyleBackColor = true;
            this.Viewfor_all_policemen.Click += new System.EventHandler(this.Viewfor_all_policemen_Click);
            // 
            // dataGridView_all_policemen
            // 
            this.dataGridView_all_policemen.AllowUserToAddRows = false;
            this.dataGridView_all_policemen.AllowUserToDeleteRows = false;
            this.dataGridView_all_policemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all_policemen.Location = new System.Drawing.Point(12, 84);
            this.dataGridView_all_policemen.Name = "dataGridView_all_policemen";
            this.dataGridView_all_policemen.ReadOnly = true;
            this.dataGridView_all_policemen.RowTemplate.Height = 24;
            this.dataGridView_all_policemen.Size = new System.Drawing.Size(1104, 334);
            this.dataGridView_all_policemen.TabIndex = 2;
            // 
            // View_All_Policemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 452);
            this.Controls.Add(this.Viewfor_all_policemen);
            this.Controls.Add(this.dataGridView_all_policemen);
            this.Name = "View_All_Policemen";
            this.Text = "View_All_Policemen";
            this.Load += new System.EventHandler(this.View_All_Policemen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_policemen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Viewfor_all_policemen;
        private System.Windows.Forms.DataGridView dataGridView_all_policemen;
    }
}