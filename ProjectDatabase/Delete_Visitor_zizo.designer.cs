namespace WindowsFormsApp3
{
    partial class Delete_Visitor
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
            this.cmb_VisitorID_delete_prisoner = new System.Windows.Forms.ComboBox();
            this.Last_Name_box_del_visitor = new System.Windows.Forms.TextBox();
            this.First_Name_box_del_visitor = new System.Windows.Forms.TextBox();
            this.Relation_box_del_visitor = new System.Windows.Forms.TextBox();
            this.Gender_box_del_visitor = new System.Windows.Forms.TextBox();
            this.Middle_Initial_box_del_visitor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_VisitorID_delete_prisoner
            // 
            this.cmb_VisitorID_delete_prisoner.FormattingEnabled = true;
            this.cmb_VisitorID_delete_prisoner.Location = new System.Drawing.Point(255, 37);
            this.cmb_VisitorID_delete_prisoner.Name = "cmb_VisitorID_delete_prisoner";
            this.cmb_VisitorID_delete_prisoner.Size = new System.Drawing.Size(100, 24);
            this.cmb_VisitorID_delete_prisoner.TabIndex = 48;
            this.cmb_VisitorID_delete_prisoner.SelectedIndexChanged += new System.EventHandler(this.cmb_VisitorID_delete_prisoner_SelectedIndexChanged);
            // 
            // Last_Name_box_del_visitor
            // 
            this.Last_Name_box_del_visitor.Location = new System.Drawing.Point(255, 186);
            this.Last_Name_box_del_visitor.Name = "Last_Name_box_del_visitor";
            this.Last_Name_box_del_visitor.ReadOnly = true;
            this.Last_Name_box_del_visitor.Size = new System.Drawing.Size(100, 22);
            this.Last_Name_box_del_visitor.TabIndex = 47;
            // 
            // First_Name_box_del_visitor
            // 
            this.First_Name_box_del_visitor.Location = new System.Drawing.Point(255, 88);
            this.First_Name_box_del_visitor.Name = "First_Name_box_del_visitor";
            this.First_Name_box_del_visitor.ReadOnly = true;
            this.First_Name_box_del_visitor.Size = new System.Drawing.Size(100, 22);
            this.First_Name_box_del_visitor.TabIndex = 46;
            // 
            // Relation_box_del_visitor
            // 
            this.Relation_box_del_visitor.Location = new System.Drawing.Point(255, 272);
            this.Relation_box_del_visitor.Name = "Relation_box_del_visitor";
            this.Relation_box_del_visitor.ReadOnly = true;
            this.Relation_box_del_visitor.Size = new System.Drawing.Size(100, 22);
            this.Relation_box_del_visitor.TabIndex = 45;
            // 
            // Gender_box_del_visitor
            // 
            this.Gender_box_del_visitor.Location = new System.Drawing.Point(255, 233);
            this.Gender_box_del_visitor.Name = "Gender_box_del_visitor";
            this.Gender_box_del_visitor.ReadOnly = true;
            this.Gender_box_del_visitor.Size = new System.Drawing.Size(100, 22);
            this.Gender_box_del_visitor.TabIndex = 44;
            // 
            // Middle_Initial_box_del_visitor
            // 
            this.Middle_Initial_box_del_visitor.Location = new System.Drawing.Point(255, 136);
            this.Middle_Initial_box_del_visitor.Name = "Middle_Initial_box_del_visitor";
            this.Middle_Initial_box_del_visitor.ReadOnly = true;
            this.Middle_Initial_box_del_visitor.Size = new System.Drawing.Size(100, 22);
            this.Middle_Initial_box_del_visitor.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Relation_To_Prisoner:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Visitor_ID ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Last_Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Middle_Initial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "First_Name :";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(369, 322);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(101, 37);
            this.Delete_Button.TabIndex = 49;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Delete_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 389);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.cmb_VisitorID_delete_prisoner);
            this.Controls.Add(this.Last_Name_box_del_visitor);
            this.Controls.Add(this.First_Name_box_del_visitor);
            this.Controls.Add(this.Relation_box_del_visitor);
            this.Controls.Add(this.Gender_box_del_visitor);
            this.Controls.Add(this.Middle_Initial_box_del_visitor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Visitor";
            this.Text = "Delete_Visitor";
            this.Load += new System.EventHandler(this.Delete_Visitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_VisitorID_delete_prisoner;
        private System.Windows.Forms.TextBox Last_Name_box_del_visitor;
        private System.Windows.Forms.TextBox First_Name_box_del_visitor;
        private System.Windows.Forms.TextBox Relation_box_del_visitor;
        private System.Windows.Forms.TextBox Gender_box_del_visitor;
        private System.Windows.Forms.TextBox Middle_Initial_box_del_visitor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
    }
}