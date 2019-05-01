namespace WindowsFormsApp3
{
    partial class Prisoners
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
            this.view_all_prisoners = new System.Windows.Forms.Button();
            this.view_one_prisoner = new System.Windows.Forms.Button();
            this.insert_prisoner = new System.Windows.Forms.Button();
            this.Delete_prisoner = new System.Windows.Forms.Button();
            this.Update_prisoner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_all_prisoners
            // 
            this.view_all_prisoners.Location = new System.Drawing.Point(169, 41);
            this.view_all_prisoners.Name = "view_all_prisoners";
            this.view_all_prisoners.Size = new System.Drawing.Size(131, 35);
            this.view_all_prisoners.TabIndex = 0;
            this.view_all_prisoners.Text = "view all prisoners";
            this.view_all_prisoners.UseVisualStyleBackColor = true;
            this.view_all_prisoners.Click += new System.EventHandler(this.view_all_prisoners_Click);
            // 
            // view_one_prisoner
            // 
            this.view_one_prisoner.Location = new System.Drawing.Point(169, 101);
            this.view_one_prisoner.Name = "view_one_prisoner";
            this.view_one_prisoner.Size = new System.Drawing.Size(131, 35);
            this.view_one_prisoner.TabIndex = 1;
            this.view_one_prisoner.Text = "view one prisoner";
            this.view_one_prisoner.UseVisualStyleBackColor = true;
            this.view_one_prisoner.Click += new System.EventHandler(this.view_one_prisoner_Click);
            // 
            // insert_prisoner
            // 
            this.insert_prisoner.Location = new System.Drawing.Point(169, 164);
            this.insert_prisoner.Name = "insert_prisoner";
            this.insert_prisoner.Size = new System.Drawing.Size(131, 35);
            this.insert_prisoner.TabIndex = 2;
            this.insert_prisoner.Text = "Insert prisoner";
            this.insert_prisoner.UseVisualStyleBackColor = true;
            this.insert_prisoner.Click += new System.EventHandler(this.insert_prisoner_Click);
            // 
            // Delete_prisoner
            // 
            this.Delete_prisoner.Location = new System.Drawing.Point(169, 227);
            this.Delete_prisoner.Name = "Delete_prisoner";
            this.Delete_prisoner.Size = new System.Drawing.Size(131, 35);
            this.Delete_prisoner.TabIndex = 3;
            this.Delete_prisoner.Text = "Delete prisoner";
            this.Delete_prisoner.UseVisualStyleBackColor = true;
            this.Delete_prisoner.Click += new System.EventHandler(this.Delete_prisoner_Click);
            // 
            // Update_prisoner
            // 
            this.Update_prisoner.Location = new System.Drawing.Point(169, 294);
            this.Update_prisoner.Name = "Update_prisoner";
            this.Update_prisoner.Size = new System.Drawing.Size(131, 35);
            this.Update_prisoner.TabIndex = 4;
            this.Update_prisoner.Text = "Update prisoner";
            this.Update_prisoner.UseVisualStyleBackColor = true;
            this.Update_prisoner.Click += new System.EventHandler(this.Update_prisoner_Click);
            // 
            // Prisoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 399);
            this.Controls.Add(this.Update_prisoner);
            this.Controls.Add(this.Delete_prisoner);
            this.Controls.Add(this.insert_prisoner);
            this.Controls.Add(this.view_one_prisoner);
            this.Controls.Add(this.view_all_prisoners);
            this.Name = "Prisoners";
            this.Text = "Prisoners";
            this.Load += new System.EventHandler(this.Prisoners_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_all_prisoners;
        private System.Windows.Forms.Button view_one_prisoner;
        private System.Windows.Forms.Button insert_prisoner;
        private System.Windows.Forms.Button Delete_prisoner;
        private System.Windows.Forms.Button Update_prisoner;
    }
}