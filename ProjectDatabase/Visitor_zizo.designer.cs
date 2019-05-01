namespace WindowsFormsApp3
{
    partial class Visitor
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
            this.Update_Visitor = new System.Windows.Forms.Button();
            this.Delete_Visitor = new System.Windows.Forms.Button();
            this.insert_Visitor = new System.Windows.Forms.Button();
            this.view_one_visitor = new System.Windows.Forms.Button();
            this.view_all_visitors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_Visitor
            // 
            this.Update_Visitor.Location = new System.Drawing.Point(133, 298);
            this.Update_Visitor.Name = "Update_Visitor";
            this.Update_Visitor.Size = new System.Drawing.Size(131, 35);
            this.Update_Visitor.TabIndex = 9;
            this.Update_Visitor.Text = "Update Visitor";
            this.Update_Visitor.UseVisualStyleBackColor = true;
            this.Update_Visitor.Click += new System.EventHandler(this.Update_Visitor_Click);
            // 
            // Delete_Visitor
            // 
            this.Delete_Visitor.Location = new System.Drawing.Point(133, 231);
            this.Delete_Visitor.Name = "Delete_Visitor";
            this.Delete_Visitor.Size = new System.Drawing.Size(131, 35);
            this.Delete_Visitor.TabIndex = 8;
            this.Delete_Visitor.Text = "Delete Visitor";
            this.Delete_Visitor.UseVisualStyleBackColor = true;
            this.Delete_Visitor.Click += new System.EventHandler(this.Delete_Visitor_Click);
            // 
            // insert_Visitor
            // 
            this.insert_Visitor.Location = new System.Drawing.Point(133, 168);
            this.insert_Visitor.Name = "insert_Visitor";
            this.insert_Visitor.Size = new System.Drawing.Size(131, 35);
            this.insert_Visitor.TabIndex = 7;
            this.insert_Visitor.Text = "Insert Visitor";
            this.insert_Visitor.UseVisualStyleBackColor = true;
            this.insert_Visitor.Click += new System.EventHandler(this.insert_Visitor_Click);
            // 
            // view_one_visitor
            // 
            this.view_one_visitor.Location = new System.Drawing.Point(133, 105);
            this.view_one_visitor.Name = "view_one_visitor";
            this.view_one_visitor.Size = new System.Drawing.Size(131, 35);
            this.view_one_visitor.TabIndex = 6;
            this.view_one_visitor.Text = "view one prisoner";
            this.view_one_visitor.UseVisualStyleBackColor = true;
            this.view_one_visitor.Click += new System.EventHandler(this.view_one_visitor_Click);
            // 
            // view_all_visitors
            // 
            this.view_all_visitors.Location = new System.Drawing.Point(133, 45);
            this.view_all_visitors.Name = "view_all_visitors";
            this.view_all_visitors.Size = new System.Drawing.Size(131, 35);
            this.view_all_visitors.TabIndex = 5;
            this.view_all_visitors.Text = "view all Visitors";
            this.view_all_visitors.UseVisualStyleBackColor = true;
            this.view_all_visitors.Click += new System.EventHandler(this.view_all_visitors_Click);
            // 
            // Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 403);
            this.Controls.Add(this.Update_Visitor);
            this.Controls.Add(this.Delete_Visitor);
            this.Controls.Add(this.insert_Visitor);
            this.Controls.Add(this.view_one_visitor);
            this.Controls.Add(this.view_all_visitors);
            this.Name = "Visitor";
            this.Text = "Visitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_Visitor;
        private System.Windows.Forms.Button Delete_Visitor;
        private System.Windows.Forms.Button insert_Visitor;
        private System.Windows.Forms.Button view_one_visitor;
        private System.Windows.Forms.Button view_all_visitors;
    }
}