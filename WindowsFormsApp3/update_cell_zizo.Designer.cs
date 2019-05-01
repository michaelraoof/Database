namespace WindowsFormsApp3
{
    partial class update_cell
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
            this.cmb_Cell_no_update = new System.Windows.Forms.ComboBox();
            this.update_cells = new System.Windows.Forms.Button();
            this.No_of_Cell_Prisoners_box_update = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_cell_type_update_cell = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_Cell_no_update
            // 
            this.cmb_Cell_no_update.FormattingEnabled = true;
            this.cmb_Cell_no_update.Location = new System.Drawing.Point(249, 32);
            this.cmb_Cell_no_update.Name = "cmb_Cell_no_update";
            this.cmb_Cell_no_update.Size = new System.Drawing.Size(100, 24);
            this.cmb_Cell_no_update.TabIndex = 53;
            this.cmb_Cell_no_update.SelectedIndexChanged += new System.EventHandler(this.cmb_Cell_no_update_SelectedIndexChanged);
            // 
            // update_cells
            // 
            this.update_cells.Location = new System.Drawing.Point(338, 180);
            this.update_cells.Name = "update_cells";
            this.update_cells.Size = new System.Drawing.Size(87, 39);
            this.update_cells.TabIndex = 52;
            this.update_cells.Text = "Update";
            this.update_cells.UseVisualStyleBackColor = true;
            this.update_cells.Click += new System.EventHandler(this.update_cells_Click);
            // 
            // No_of_Cell_Prisoners_box_update
            // 
            this.No_of_Cell_Prisoners_box_update.Enabled = false;
            this.No_of_Cell_Prisoners_box_update.Location = new System.Drawing.Point(249, 131);
            this.No_of_Cell_Prisoners_box_update.Name = "No_of_Cell_Prisoners_box_update";
            this.No_of_Cell_Prisoners_box_update.Size = new System.Drawing.Size(100, 22);
            this.No_of_Cell_Prisoners_box_update.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cell_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "No_of_Cell_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cell_Type :";
            // 
            // cmb_cell_type_update_cell
            // 
            this.cmb_cell_type_update_cell.FormattingEnabled = true;
            this.cmb_cell_type_update_cell.Location = new System.Drawing.Point(249, 86);
            this.cmb_cell_type_update_cell.Name = "cmb_cell_type_update_cell";
            this.cmb_cell_type_update_cell.Size = new System.Drawing.Size(100, 24);
            this.cmb_cell_type_update_cell.TabIndex = 54;
            // 
            // update_cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 251);
            this.Controls.Add(this.cmb_cell_type_update_cell);
            this.Controls.Add(this.cmb_Cell_no_update);
            this.Controls.Add(this.update_cells);
            this.Controls.Add(this.No_of_Cell_Prisoners_box_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update_cell";
            this.Text = "update_cell";
            this.Load += new System.EventHandler(this.update_cell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Cell_no_update;
        private System.Windows.Forms.Button update_cells;
        private System.Windows.Forms.TextBox No_of_Cell_Prisoners_box_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cell_type_update_cell;
    }
}