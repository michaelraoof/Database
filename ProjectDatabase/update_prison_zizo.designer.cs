namespace WindowsFormsApp3
{
    partial class update_prison
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
            this.Location_box_update = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_cells = new System.Windows.Forms.Button();
            this.No_Of_Prisoners_box_update = new System.Windows.Forms.TextBox();
            this.No_Of_Policemen_box_update = new System.Windows.Forms.TextBox();
            this.cmb_prison_name_update = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Location_box_update
            // 
            this.Location_box_update.Location = new System.Drawing.Point(235, 95);
            this.Location_box_update.Name = "Location_box_update";
            this.Location_box_update.Size = new System.Drawing.Size(100, 22);
            this.Location_box_update.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Prison_Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "N0_Of_Policemen :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "N0_Of_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Location :";
            // 
            // update_cells
            // 
            this.update_cells.Location = new System.Drawing.Point(315, 262);
            this.update_cells.Name = "update_cells";
            this.update_cells.Size = new System.Drawing.Size(87, 39);
            this.update_cells.TabIndex = 53;
            this.update_cells.Text = "Update";
            this.update_cells.UseVisualStyleBackColor = true;
            this.update_cells.Click += new System.EventHandler(this.update_cells_Click);
            // 
            // No_Of_Prisoners_box_update
            // 
            this.No_Of_Prisoners_box_update.Enabled = false;
            this.No_Of_Prisoners_box_update.Location = new System.Drawing.Point(235, 139);
            this.No_Of_Prisoners_box_update.Name = "No_Of_Prisoners_box_update";
            this.No_Of_Prisoners_box_update.Size = new System.Drawing.Size(100, 22);
            this.No_Of_Prisoners_box_update.TabIndex = 55;
            // 
            // No_Of_Policemen_box_update
            // 
            this.No_Of_Policemen_box_update.Enabled = false;
            this.No_Of_Policemen_box_update.Location = new System.Drawing.Point(235, 190);
            this.No_Of_Policemen_box_update.Name = "No_Of_Policemen_box_update";
            this.No_Of_Policemen_box_update.Size = new System.Drawing.Size(100, 22);
            this.No_Of_Policemen_box_update.TabIndex = 54;
            // 
            // cmb_prison_name_update
            // 
            this.cmb_prison_name_update.FormattingEnabled = true;
            this.cmb_prison_name_update.Location = new System.Drawing.Point(235, 42);
            this.cmb_prison_name_update.Name = "cmb_prison_name_update";
            this.cmb_prison_name_update.Size = new System.Drawing.Size(100, 24);
            this.cmb_prison_name_update.TabIndex = 56;
            this.cmb_prison_name_update.SelectedIndexChanged += new System.EventHandler(this.cmb_prison_name_update_SelectedIndexChanged);
            // 
            // update_prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 327);
            this.Controls.Add(this.cmb_prison_name_update);
            this.Controls.Add(this.No_Of_Prisoners_box_update);
            this.Controls.Add(this.No_Of_Policemen_box_update);
            this.Controls.Add(this.update_cells);
            this.Controls.Add(this.Location_box_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update_prison";
            this.Text = "update_prison";
            this.Load += new System.EventHandler(this.update_prison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Location_box_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_cells;
        private System.Windows.Forms.TextBox No_Of_Prisoners_box_update;
        private System.Windows.Forms.TextBox No_Of_Policemen_box_update;
        private System.Windows.Forms.ComboBox cmb_prison_name_update;
    }
}