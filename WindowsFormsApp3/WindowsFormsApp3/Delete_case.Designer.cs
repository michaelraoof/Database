namespace WindowsFormsApp3
{
    partial class Delete_case
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
            this.delelte_Case = new System.Windows.Forms.Button();
            this.Crime_box_del = new System.Windows.Forms.TextBox();
            this.Penalty_box_del = new System.Windows.Forms.TextBox();
            this.Case_Type_box_del = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Case_no_delete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // delelte_Case
            // 
            this.delelte_Case.Location = new System.Drawing.Point(332, 247);
            this.delelte_Case.Name = "delelte_Case";
            this.delelte_Case.Size = new System.Drawing.Size(87, 39);
            this.delelte_Case.TabIndex = 34;
            this.delelte_Case.Text = "Delete";
            this.delelte_Case.UseVisualStyleBackColor = true;
            this.delelte_Case.Click += new System.EventHandler(this.delelte_Case_Click);
            // 
            // Crime_box_del
            // 
            this.Crime_box_del.Location = new System.Drawing.Point(202, 199);
            this.Crime_box_del.Name = "Crime_box_del";
            this.Crime_box_del.Size = new System.Drawing.Size(100, 22);
            this.Crime_box_del.TabIndex = 33;
            // 
            // Penalty_box_del
            // 
            this.Penalty_box_del.Location = new System.Drawing.Point(202, 149);
            this.Penalty_box_del.Name = "Penalty_box_del";
            this.Penalty_box_del.Size = new System.Drawing.Size(100, 22);
            this.Penalty_box_del.TabIndex = 31;
            // 
            // Case_Type_box_del
            // 
            this.Case_Type_box_del.Location = new System.Drawing.Point(202, 104);
            this.Case_Type_box_del.Name = "Case_Type_box_del";
            this.Case_Type_box_del.Size = new System.Drawing.Size(100, 22);
            this.Case_Type_box_del.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Case_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Crime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Penalty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Case_Type :";
            // 
            // cmb_Case_no_delete
            // 
            this.cmb_Case_no_delete.FormattingEnabled = true;
            this.cmb_Case_no_delete.Location = new System.Drawing.Point(202, 50);
            this.cmb_Case_no_delete.Name = "cmb_Case_no_delete";
            this.cmb_Case_no_delete.Size = new System.Drawing.Size(100, 24);
            this.cmb_Case_no_delete.TabIndex = 37;
            this.cmb_Case_no_delete.SelectedIndexChanged += new System.EventHandler(this.cmb_Case_no_delete_SelectedIndexChanged);
            // 
            // Delete_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 318);
            this.Controls.Add(this.cmb_Case_no_delete);
            this.Controls.Add(this.delelte_Case);
            this.Controls.Add(this.Crime_box_del);
            this.Controls.Add(this.Penalty_box_del);
            this.Controls.Add(this.Case_Type_box_del);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_case";
            this.Text = "Delete_case";
            this.Load += new System.EventHandler(this.Delete_case_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delelte_Case;
        private System.Windows.Forms.TextBox Crime_box_del;
        private System.Windows.Forms.TextBox Penalty_box_del;
        private System.Windows.Forms.TextBox Case_Type_box_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Case_no_delete;
    }
}