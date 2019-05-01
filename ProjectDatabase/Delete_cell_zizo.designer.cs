namespace WindowsFormsApp3
{
    partial class Delete_cell
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
            this.cmb_Cell_no_delete = new System.Windows.Forms.ComboBox();
            this.delelte_Cell = new System.Windows.Forms.Button();
            this.No_of_Cell_Prisoners_box_del = new System.Windows.Forms.TextBox();
            this.Cell_Type_box_del = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Cell_no_delete
            // 
            this.cmb_Cell_no_delete.FormattingEnabled = true;
            this.cmb_Cell_no_delete.Location = new System.Drawing.Point(252, 31);
            this.cmb_Cell_no_delete.Name = "cmb_Cell_no_delete";
            this.cmb_Cell_no_delete.Size = new System.Drawing.Size(100, 24);
            this.cmb_Cell_no_delete.TabIndex = 46;
            this.cmb_Cell_no_delete.SelectedIndexChanged += new System.EventHandler(this.cmb_Cell_no_delete_SelectedIndexChanged);
            // 
            // delelte_Cell
            // 
            this.delelte_Cell.Location = new System.Drawing.Point(341, 179);
            this.delelte_Cell.Name = "delelte_Cell";
            this.delelte_Cell.Size = new System.Drawing.Size(87, 39);
            this.delelte_Cell.TabIndex = 45;
            this.delelte_Cell.Text = "Delete";
            this.delelte_Cell.UseVisualStyleBackColor = true;
            this.delelte_Cell.Click += new System.EventHandler(this.delelte_Cell_Click);
            // 
            // No_of_Cell_Prisoners_box_del
            // 
            this.No_of_Cell_Prisoners_box_del.Location = new System.Drawing.Point(252, 130);
            this.No_of_Cell_Prisoners_box_del.Name = "No_of_Cell_Prisoners_box_del";
            this.No_of_Cell_Prisoners_box_del.Size = new System.Drawing.Size(100, 22);
            this.No_of_Cell_Prisoners_box_del.TabIndex = 43;
            // 
            // Cell_Type_box_del
            // 
            this.Cell_Type_box_del.Location = new System.Drawing.Point(252, 84);
            this.Cell_Type_box_del.Name = "Cell_Type_box_del";
            this.Cell_Type_box_del.Size = new System.Drawing.Size(100, 22);
            this.Cell_Type_box_del.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cell_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "No_of_Cell_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cell_Type :";
            // 
            // Delete_cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 242);
            this.Controls.Add(this.cmb_Cell_no_delete);
            this.Controls.Add(this.delelte_Cell);
            this.Controls.Add(this.No_of_Cell_Prisoners_box_del);
            this.Controls.Add(this.Cell_Type_box_del);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_cell";
            this.Text = "Delete_cell";
            this.Load += new System.EventHandler(this.Delete_cell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Cell_no_delete;
        private System.Windows.Forms.Button delelte_Cell;
        private System.Windows.Forms.TextBox No_of_Cell_Prisoners_box_del;
        private System.Windows.Forms.TextBox Cell_Type_box_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}