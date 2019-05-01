namespace WindowsFormsApp3
{
    partial class Cells
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
            this.Update_cell = new System.Windows.Forms.Button();
            this.View_all_cells = new System.Windows.Forms.Button();
            this.Delete_cell = new System.Windows.Forms.Button();
            this.insert_cell = new System.Windows.Forms.Button();
            this.view_one_cell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_cell
            // 
            this.Update_cell.Location = new System.Drawing.Point(95, 292);
            this.Update_cell.Name = "Update_cell";
            this.Update_cell.Size = new System.Drawing.Size(154, 35);
            this.Update_cell.TabIndex = 19;
            this.Update_cell.Text = "Update Cell";
            this.Update_cell.UseVisualStyleBackColor = true;
            this.Update_cell.Click += new System.EventHandler(this.Update_cell_Click);
            // 
            // View_all_cells
            // 
            this.View_all_cells.Location = new System.Drawing.Point(95, 40);
            this.View_all_cells.Name = "View_all_cells";
            this.View_all_cells.Size = new System.Drawing.Size(154, 35);
            this.View_all_cells.TabIndex = 20;
            this.View_all_cells.Text = "view_all_cells";
            this.View_all_cells.UseVisualStyleBackColor = true;
            this.View_all_cells.Click += new System.EventHandler(this.View_all_cells_Click);
            // 
            // Delete_cell
            // 
            this.Delete_cell.Location = new System.Drawing.Point(95, 229);
            this.Delete_cell.Name = "Delete_cell";
            this.Delete_cell.Size = new System.Drawing.Size(154, 35);
            this.Delete_cell.TabIndex = 23;
            this.Delete_cell.Text = "Delete cell";
            this.Delete_cell.UseVisualStyleBackColor = true;
            this.Delete_cell.Click += new System.EventHandler(this.Delete_cell_Click);
            // 
            // insert_cell
            // 
            this.insert_cell.Location = new System.Drawing.Point(95, 166);
            this.insert_cell.Name = "insert_cell";
            this.insert_cell.Size = new System.Drawing.Size(154, 35);
            this.insert_cell.TabIndex = 22;
            this.insert_cell.Text = "Insert cell";
            this.insert_cell.UseVisualStyleBackColor = true;
            this.insert_cell.Click += new System.EventHandler(this.insert_cell_Click);
            // 
            // view_one_cell
            // 
            this.view_one_cell.Location = new System.Drawing.Point(95, 103);
            this.view_one_cell.Name = "view_one_cell";
            this.view_one_cell.Size = new System.Drawing.Size(154, 35);
            this.view_one_cell.TabIndex = 21;
            this.view_one_cell.Text = "view one cell";
            this.view_one_cell.UseVisualStyleBackColor = true;
            this.view_one_cell.Click += new System.EventHandler(this.view_one_cell_Click);
            // 
            // Cells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 366);
            this.Controls.Add(this.Delete_cell);
            this.Controls.Add(this.insert_cell);
            this.Controls.Add(this.view_one_cell);
            this.Controls.Add(this.View_all_cells);
            this.Controls.Add(this.Update_cell);
            this.Name = "Cells";
            this.Text = "Cells";
            this.Load += new System.EventHandler(this.Cells_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_cell;
        private System.Windows.Forms.Button View_all_cells;
        private System.Windows.Forms.Button Delete_cell;
        private System.Windows.Forms.Button insert_cell;
        private System.Windows.Forms.Button view_one_cell;
    }
}