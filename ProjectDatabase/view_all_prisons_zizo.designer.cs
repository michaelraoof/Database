namespace WindowsFormsApp3
{
    partial class view_all_prison
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
            this.dataGridView_view_all_prisons = new System.Windows.Forms.DataGridView();
            this.Viewfor_all_Prisons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_prisons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_view_all_prisons
            // 
            this.dataGridView_view_all_prisons.AllowUserToAddRows = false;
            this.dataGridView_view_all_prisons.AllowUserToDeleteRows = false;
            this.dataGridView_view_all_prisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view_all_prisons.Location = new System.Drawing.Point(27, 78);
            this.dataGridView_view_all_prisons.Name = "dataGridView_view_all_prisons";
            this.dataGridView_view_all_prisons.ReadOnly = true;
            this.dataGridView_view_all_prisons.RowTemplate.Height = 24;
            this.dataGridView_view_all_prisons.Size = new System.Drawing.Size(629, 334);
            this.dataGridView_view_all_prisons.TabIndex = 4;
            // 
            // Viewfor_all_Prisons
            // 
            this.Viewfor_all_Prisons.Location = new System.Drawing.Point(306, 30);
            this.Viewfor_all_Prisons.Name = "Viewfor_all_Prisons";
            this.Viewfor_all_Prisons.Size = new System.Drawing.Size(75, 23);
            this.Viewfor_all_Prisons.TabIndex = 5;
            this.Viewfor_all_Prisons.Text = "View";
            this.Viewfor_all_Prisons.UseVisualStyleBackColor = true;
            this.Viewfor_all_Prisons.Click += new System.EventHandler(this.Viewfor_all_Prisons_Click);
            // 
            // view_all_prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.Viewfor_all_Prisons);
            this.Controls.Add(this.dataGridView_view_all_prisons);
            this.Name = "view_all_prison";
            this.Text = "view_all_prison";
            this.Load += new System.EventHandler(this.view_all_prison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_prisons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_view_all_prisons;
        private System.Windows.Forms.Button Viewfor_all_Prisons;
    }
}