namespace WindowsFormsApp3
{
    partial class Delete_prison
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
            this.cmb_prison_name_del = new System.Windows.Forms.ComboBox();
            this.No_Of_Prisoners_box_del = new System.Windows.Forms.TextBox();
            this.No_Of_Policemen_box_del = new System.Windows.Forms.TextBox();
            this.Location_box_del = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delelte_prison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_prison_name_del
            // 
            this.cmb_prison_name_del.FormattingEnabled = true;
            this.cmb_prison_name_del.Location = new System.Drawing.Point(252, 35);
            this.cmb_prison_name_del.Name = "cmb_prison_name_del";
            this.cmb_prison_name_del.Size = new System.Drawing.Size(100, 24);
            this.cmb_prison_name_del.TabIndex = 64;
            this.cmb_prison_name_del.SelectedIndexChanged += new System.EventHandler(this.cmb_prison_name_update_SelectedIndexChanged);
            // 
            // No_Of_Prisoners_box_del
            // 
            this.No_Of_Prisoners_box_del.Enabled = false;
            this.No_Of_Prisoners_box_del.Location = new System.Drawing.Point(252, 132);
            this.No_Of_Prisoners_box_del.Name = "No_Of_Prisoners_box_del";
            this.No_Of_Prisoners_box_del.Size = new System.Drawing.Size(100, 22);
            this.No_Of_Prisoners_box_del.TabIndex = 63;
            // 
            // No_Of_Policemen_box_del
            // 
            this.No_Of_Policemen_box_del.Enabled = false;
            this.No_Of_Policemen_box_del.Location = new System.Drawing.Point(252, 183);
            this.No_Of_Policemen_box_del.Name = "No_Of_Policemen_box_del";
            this.No_Of_Policemen_box_del.Size = new System.Drawing.Size(100, 22);
            this.No_Of_Policemen_box_del.TabIndex = 62;
            // 
            // Location_box_del
            // 
            this.Location_box_del.Location = new System.Drawing.Point(252, 88);
            this.Location_box_del.Name = "Location_box_del";
            this.Location_box_del.Size = new System.Drawing.Size(100, 22);
            this.Location_box_del.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Prison_Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "N0_Of_Policemen :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "N0_Of_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Location :";
            // 
            // delelte_prison
            // 
            this.delelte_prison.Location = new System.Drawing.Point(346, 242);
            this.delelte_prison.Name = "delelte_prison";
            this.delelte_prison.Size = new System.Drawing.Size(87, 39);
            this.delelte_prison.TabIndex = 65;
            this.delelte_prison.Text = "Delete";
            this.delelte_prison.UseVisualStyleBackColor = true;
            this.delelte_prison.Click += new System.EventHandler(this.delelte_prison_Click);
            // 
            // Delete_prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 312);
            this.Controls.Add(this.delelte_prison);
            this.Controls.Add(this.cmb_prison_name_del);
            this.Controls.Add(this.No_Of_Prisoners_box_del);
            this.Controls.Add(this.No_Of_Policemen_box_del);
            this.Controls.Add(this.Location_box_del);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_prison";
            this.Text = "Delete_prison";
            this.Load += new System.EventHandler(this.Delete_prison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_prison_name_del;
        private System.Windows.Forms.TextBox No_Of_Prisoners_box_del;
        private System.Windows.Forms.TextBox No_Of_Policemen_box_del;
        private System.Windows.Forms.TextBox Location_box_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delelte_prison;
    }
}