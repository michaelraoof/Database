namespace WindowsFormsApp3
{
    partial class insert_cell
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
            this.cmb_No_of_prisoners_for_insert_cell = new System.Windows.Forms.ComboBox();
            this.Save_add_Cell = new System.Windows.Forms.Button();
            this.Cell_NO_box_insert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_cell_type_for_insert_cell = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_No_of_prisoners_for_insert_cell
            // 
            this.cmb_No_of_prisoners_for_insert_cell.FormattingEnabled = true;
            this.cmb_No_of_prisoners_for_insert_cell.Location = new System.Drawing.Point(255, 130);
            this.cmb_No_of_prisoners_for_insert_cell.Name = "cmb_No_of_prisoners_for_insert_cell";
            this.cmb_No_of_prisoners_for_insert_cell.Size = new System.Drawing.Size(100, 24);
            this.cmb_No_of_prisoners_for_insert_cell.TabIndex = 43;
            // 
            // Save_add_Cell
            // 
            this.Save_add_Cell.Location = new System.Drawing.Point(373, 185);
            this.Save_add_Cell.Name = "Save_add_Cell";
            this.Save_add_Cell.Size = new System.Drawing.Size(87, 39);
            this.Save_add_Cell.TabIndex = 42;
            this.Save_add_Cell.Text = "Save";
            this.Save_add_Cell.UseVisualStyleBackColor = true;
            this.Save_add_Cell.Click += new System.EventHandler(this.Save_add_Cell_Click);
            // 
            // Cell_NO_box_insert
            // 
            this.Cell_NO_box_insert.Enabled = false;
            this.Cell_NO_box_insert.Location = new System.Drawing.Point(255, 38);
            this.Cell_NO_box_insert.Name = "Cell_NO_box_insert";
            this.Cell_NO_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Cell_NO_box_insert.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cell_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "No_of_Cell_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cell_Type :";
            // 
            // cmb_cell_type_for_insert_cell
            // 
            this.cmb_cell_type_for_insert_cell.FormattingEnabled = true;
            this.cmb_cell_type_for_insert_cell.Location = new System.Drawing.Point(255, 89);
            this.cmb_cell_type_for_insert_cell.Name = "cmb_cell_type_for_insert_cell";
            this.cmb_cell_type_for_insert_cell.Size = new System.Drawing.Size(100, 24);
            this.cmb_cell_type_for_insert_cell.TabIndex = 44;
            // 
            // insert_cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 279);
            this.Controls.Add(this.cmb_cell_type_for_insert_cell);
            this.Controls.Add(this.cmb_No_of_prisoners_for_insert_cell);
            this.Controls.Add(this.Save_add_Cell);
            this.Controls.Add(this.Cell_NO_box_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert_cell";
            this.Text = "insert_cell";
            this.Load += new System.EventHandler(this.insert_cell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_No_of_prisoners_for_insert_cell;
        private System.Windows.Forms.Button Save_add_Cell;
        private System.Windows.Forms.TextBox Cell_NO_box_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cell_type_for_insert_cell;
    }
}