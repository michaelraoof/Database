namespace WindowsFormsApp3
{
    partial class view_all_cases
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
            this.Viewfor_all_cases = new System.Windows.Forms.Button();
            this.dataGridView_view_all_cases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_cases)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewfor_all_cases
            // 
            this.Viewfor_all_cases.Location = new System.Drawing.Point(329, 36);
            this.Viewfor_all_cases.Name = "Viewfor_all_cases";
            this.Viewfor_all_cases.Size = new System.Drawing.Size(75, 23);
            this.Viewfor_all_cases.TabIndex = 3;
            this.Viewfor_all_cases.Text = "View";
            this.Viewfor_all_cases.UseVisualStyleBackColor = true;
            this.Viewfor_all_cases.Click += new System.EventHandler(this.Viewfor_all_cases_Click);
            // 
            // dataGridView_view_all_cases
            // 
            this.dataGridView_view_all_cases.AllowUserToAddRows = false;
            this.dataGridView_view_all_cases.AllowUserToDeleteRows = false;
            this.dataGridView_view_all_cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view_all_cases.Location = new System.Drawing.Point(23, 90);
            this.dataGridView_view_all_cases.Name = "dataGridView_view_all_cases";
            this.dataGridView_view_all_cases.ReadOnly = true;
            this.dataGridView_view_all_cases.RowTemplate.Height = 24;
            this.dataGridView_view_all_cases.Size = new System.Drawing.Size(629, 334);
            this.dataGridView_view_all_cases.TabIndex = 2;
            this.dataGridView_view_all_cases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_view_all_cases_CellContentClick);
            // 
            // view_all_cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 473);
            this.Controls.Add(this.Viewfor_all_cases);
            this.Controls.Add(this.dataGridView_view_all_cases);
            this.Name = "view_all_cases";
            this.Text = "view_all_cases";
            this.Load += new System.EventHandler(this.view_all_cases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_cases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Viewfor_all_cases;
        private System.Windows.Forms.DataGridView dataGridView_view_all_cases;
    }
}