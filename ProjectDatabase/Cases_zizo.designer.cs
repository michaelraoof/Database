namespace WindowsFormsApp3
{
    partial class Cases
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
            this.Update_case = new System.Windows.Forms.Button();
            this.Delete_case = new System.Windows.Forms.Button();
            this.insert_case = new System.Windows.Forms.Button();
            this.view_one_case = new System.Windows.Forms.Button();
            this.view_all_cases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_case
            // 
            this.Update_case.Location = new System.Drawing.Point(113, 303);
            this.Update_case.Name = "Update_case";
            this.Update_case.Size = new System.Drawing.Size(154, 35);
            this.Update_case.TabIndex = 19;
            this.Update_case.Text = "Update case";
            this.Update_case.UseVisualStyleBackColor = true;
            this.Update_case.Click += new System.EventHandler(this.Update_case_Click);
            // 
            // Delete_case
            // 
            this.Delete_case.Location = new System.Drawing.Point(113, 236);
            this.Delete_case.Name = "Delete_case";
            this.Delete_case.Size = new System.Drawing.Size(154, 35);
            this.Delete_case.TabIndex = 18;
            this.Delete_case.Text = "Delete case";
            this.Delete_case.UseVisualStyleBackColor = true;
            this.Delete_case.Click += new System.EventHandler(this.Delete_case_Click);
            // 
            // insert_case
            // 
            this.insert_case.Location = new System.Drawing.Point(113, 173);
            this.insert_case.Name = "insert_case";
            this.insert_case.Size = new System.Drawing.Size(154, 35);
            this.insert_case.TabIndex = 17;
            this.insert_case.Text = "Insert case";
            this.insert_case.UseVisualStyleBackColor = true;
            this.insert_case.Click += new System.EventHandler(this.insert_case_Click);
            // 
            // view_one_case
            // 
            this.view_one_case.Location = new System.Drawing.Point(113, 110);
            this.view_one_case.Name = "view_one_case";
            this.view_one_case.Size = new System.Drawing.Size(154, 35);
            this.view_one_case.TabIndex = 16;
            this.view_one_case.Text = "view one case";
            this.view_one_case.UseVisualStyleBackColor = true;
            this.view_one_case.Click += new System.EventHandler(this.view_one_case_Click);
            // 
            // view_all_cases
            // 
            this.view_all_cases.Location = new System.Drawing.Point(113, 50);
            this.view_all_cases.Name = "view_all_cases";
            this.view_all_cases.Size = new System.Drawing.Size(154, 35);
            this.view_all_cases.TabIndex = 15;
            this.view_all_cases.Text = "view all Cases";
            this.view_all_cases.UseVisualStyleBackColor = true;
            this.view_all_cases.Click += new System.EventHandler(this.view_all_cases_Click);
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.Update_case);
            this.Controls.Add(this.Delete_case);
            this.Controls.Add(this.insert_case);
            this.Controls.Add(this.view_one_case);
            this.Controls.Add(this.view_all_cases);
            this.Name = "Cases";
            this.Text = "Cases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_case;
        private System.Windows.Forms.Button Delete_case;
        private System.Windows.Forms.Button insert_case;
        private System.Windows.Forms.Button view_one_case;
        private System.Windows.Forms.Button view_all_cases;
    }
}