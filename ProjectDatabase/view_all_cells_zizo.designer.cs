namespace WindowsFormsApp3
{
    partial class view_all_cells
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
            this.Viewfor_all_cells = new System.Windows.Forms.Button();
            this.dataGridView_view_all_cells = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_cells)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewfor_all_cells
            // 
            this.Viewfor_all_cells.Location = new System.Drawing.Point(214, 30);
            this.Viewfor_all_cells.Name = "Viewfor_all_cells";
            this.Viewfor_all_cells.Size = new System.Drawing.Size(75, 23);
            this.Viewfor_all_cells.TabIndex = 5;
            this.Viewfor_all_cells.Text = "View";
            this.Viewfor_all_cells.UseVisualStyleBackColor = true;
            this.Viewfor_all_cells.Click += new System.EventHandler(this.Viewfor_all_cells_Click);
            // 
            // dataGridView_view_all_cells
            // 
            this.dataGridView_view_all_cells.AllowUserToAddRows = false;
            this.dataGridView_view_all_cells.AllowUserToDeleteRows = false;
            this.dataGridView_view_all_cells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view_all_cells.Location = new System.Drawing.Point(12, 59);
            this.dataGridView_view_all_cells.Name = "dataGridView_view_all_cells";
            this.dataGridView_view_all_cells.ReadOnly = true;
            this.dataGridView_view_all_cells.RowTemplate.Height = 24;
            this.dataGridView_view_all_cells.Size = new System.Drawing.Size(492, 334);
            this.dataGridView_view_all_cells.TabIndex = 4;
            this.dataGridView_view_all_cells.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_view_all_cells_CellContentClick);
            // 
            // view_all_cells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 405);
            this.Controls.Add(this.Viewfor_all_cells);
            this.Controls.Add(this.dataGridView_view_all_cells);
            this.Name = "view_all_cells";
            this.Text = "view_all_cells";
            this.Load += new System.EventHandler(this.view_all_cells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view_all_cells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Viewfor_all_cells;
        private System.Windows.Forms.DataGridView dataGridView_view_all_cells;
    }
}