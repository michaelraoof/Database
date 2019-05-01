namespace WindowsFormsApp3
{
    partial class Update_Visitor
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
            this.cmb_visitorID_update_prisoner = new System.Windows.Forms.ComboBox();
            this.Last_Name_box_update_visitor = new System.Windows.Forms.TextBox();
            this.First_Name_box_update_visitor = new System.Windows.Forms.TextBox();
            this.Realtion_box_update_visitor = new System.Windows.Forms.TextBox();
            this.Gender_box_update_visitor = new System.Windows.Forms.TextBox();
            this.Middle_Initial_box_update_visitor = new System.Windows.Forms.TextBox();
            this.Relation_To_Prisoner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_visitorID_update_prisoner
            // 
            this.cmb_visitorID_update_prisoner.FormattingEnabled = true;
            this.cmb_visitorID_update_prisoner.Location = new System.Drawing.Point(251, 38);
            this.cmb_visitorID_update_prisoner.Name = "cmb_visitorID_update_prisoner";
            this.cmb_visitorID_update_prisoner.Size = new System.Drawing.Size(100, 24);
            this.cmb_visitorID_update_prisoner.TabIndex = 66;
            this.cmb_visitorID_update_prisoner.SelectedIndexChanged += new System.EventHandler(this.cmb_visitorID_update_prisoner_SelectedIndexChanged);
            // 
            // Last_Name_box_update_visitor
            // 
            this.Last_Name_box_update_visitor.Location = new System.Drawing.Point(251, 187);
            this.Last_Name_box_update_visitor.Name = "Last_Name_box_update_visitor";
            this.Last_Name_box_update_visitor.Size = new System.Drawing.Size(100, 22);
            this.Last_Name_box_update_visitor.TabIndex = 65;
            this.Last_Name_box_update_visitor.TextChanged += new System.EventHandler(this.Last_Name_box_update_visitor_TextChanged);
            // 
            // First_Name_box_update_visitor
            // 
            this.First_Name_box_update_visitor.Location = new System.Drawing.Point(251, 89);
            this.First_Name_box_update_visitor.Name = "First_Name_box_update_visitor";
            this.First_Name_box_update_visitor.Size = new System.Drawing.Size(100, 22);
            this.First_Name_box_update_visitor.TabIndex = 64;
            this.First_Name_box_update_visitor.TextChanged += new System.EventHandler(this.First_Name_box_update_visitor_TextChanged);
            // 
            // Realtion_box_update_visitor
            // 
            this.Realtion_box_update_visitor.Location = new System.Drawing.Point(251, 273);
            this.Realtion_box_update_visitor.Name = "Realtion_box_update_visitor";
            this.Realtion_box_update_visitor.Size = new System.Drawing.Size(100, 22);
            this.Realtion_box_update_visitor.TabIndex = 63;
            this.Realtion_box_update_visitor.TextChanged += new System.EventHandler(this.Address_box_update_visitor_TextChanged);
            // 
            // Gender_box_update_visitor
            // 
            this.Gender_box_update_visitor.Location = new System.Drawing.Point(251, 234);
            this.Gender_box_update_visitor.Name = "Gender_box_update_visitor";
            this.Gender_box_update_visitor.Size = new System.Drawing.Size(100, 22);
            this.Gender_box_update_visitor.TabIndex = 62;
            this.Gender_box_update_visitor.TextChanged += new System.EventHandler(this.Gender_box_update_visitor_TextChanged);
            // 
            // Middle_Initial_box_update_visitor
            // 
            this.Middle_Initial_box_update_visitor.Location = new System.Drawing.Point(251, 137);
            this.Middle_Initial_box_update_visitor.Name = "Middle_Initial_box_update_visitor";
            this.Middle_Initial_box_update_visitor.Size = new System.Drawing.Size(100, 22);
            this.Middle_Initial_box_update_visitor.TabIndex = 61;
            this.Middle_Initial_box_update_visitor.TextChanged += new System.EventHandler(this.Middle_Initial_box_update_visitor_TextChanged);
            // 
            // Relation_To_Prisoner
            // 
            this.Relation_To_Prisoner.AutoSize = true;
            this.Relation_To_Prisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relation_To_Prisoner.Location = new System.Drawing.Point(12, 269);
            this.Relation_To_Prisoner.Name = "Relation_To_Prisoner";
            this.Relation_To_Prisoner.Size = new System.Drawing.Size(220, 25);
            this.Relation_To_Prisoner.TabIndex = 60;
            this.Relation_To_Prisoner.Text = "Relation_To_Prisoner";
            this.Relation_To_Prisoner.Click += new System.EventHandler(this.Relation_To_Prisoner_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Visitor_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Last_Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Middle_Initial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "First_Name :";
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(348, 345);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(95, 43);
            this.Update_Button.TabIndex = 67;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Update_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.cmb_visitorID_update_prisoner);
            this.Controls.Add(this.Last_Name_box_update_visitor);
            this.Controls.Add(this.First_Name_box_update_visitor);
            this.Controls.Add(this.Realtion_box_update_visitor);
            this.Controls.Add(this.Gender_box_update_visitor);
            this.Controls.Add(this.Middle_Initial_box_update_visitor);
            this.Controls.Add(this.Relation_To_Prisoner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Visitor";
            this.Text = "Update_Visitor";
            this.Load += new System.EventHandler(this.Update_Visitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_visitorID_update_prisoner;
        private System.Windows.Forms.TextBox Last_Name_box_update_visitor;
        private System.Windows.Forms.TextBox First_Name_box_update_visitor;
        private System.Windows.Forms.TextBox Realtion_box_update_visitor;
        private System.Windows.Forms.TextBox Gender_box_update_visitor;
        private System.Windows.Forms.TextBox Middle_Initial_box_update_visitor;
        private System.Windows.Forms.Label Relation_To_Prisoner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_Button;
    }
}