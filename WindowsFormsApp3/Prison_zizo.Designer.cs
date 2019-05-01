namespace WindowsFormsApp3
{
    partial class Prison
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
            this.Update_prison = new System.Windows.Forms.Button();
            this.Delete_prison = new System.Windows.Forms.Button();
            this.insert_prison = new System.Windows.Forms.Button();
            this.view_one_prison = new System.Windows.Forms.Button();
            this.view_all_prisons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_prison
            // 
            this.Update_prison.Location = new System.Drawing.Point(100, 315);
            this.Update_prison.Name = "Update_prison";
            this.Update_prison.Size = new System.Drawing.Size(154, 35);
            this.Update_prison.TabIndex = 14;
            this.Update_prison.Text = "Update prison";
            this.Update_prison.UseVisualStyleBackColor = true;
            this.Update_prison.Click += new System.EventHandler(this.Update_prison_Click);
            // 
            // Delete_prison
            // 
            this.Delete_prison.Location = new System.Drawing.Point(100, 248);
            this.Delete_prison.Name = "Delete_prison";
            this.Delete_prison.Size = new System.Drawing.Size(154, 35);
            this.Delete_prison.TabIndex = 13;
            this.Delete_prison.Text = "Delete prison";
            this.Delete_prison.UseVisualStyleBackColor = true;
            this.Delete_prison.Click += new System.EventHandler(this.Delete_prison_Click);
            // 
            // insert_prison
            // 
            this.insert_prison.Location = new System.Drawing.Point(100, 185);
            this.insert_prison.Name = "insert_prison";
            this.insert_prison.Size = new System.Drawing.Size(154, 35);
            this.insert_prison.TabIndex = 12;
            this.insert_prison.Text = "Insert prison";
            this.insert_prison.UseVisualStyleBackColor = true;
            this.insert_prison.Click += new System.EventHandler(this.insert_prison_Click);
            // 
            // view_one_prison
            // 
            this.view_one_prison.Location = new System.Drawing.Point(100, 122);
            this.view_one_prison.Name = "view_one_prison";
            this.view_one_prison.Size = new System.Drawing.Size(154, 35);
            this.view_one_prison.TabIndex = 11;
            this.view_one_prison.Text = "view one prison";
            this.view_one_prison.UseVisualStyleBackColor = true;
            this.view_one_prison.Click += new System.EventHandler(this.view_one_prison_Click);
            // 
            // view_all_prisons
            // 
            this.view_all_prisons.Location = new System.Drawing.Point(100, 62);
            this.view_all_prisons.Name = "view_all_prisons";
            this.view_all_prisons.Size = new System.Drawing.Size(154, 35);
            this.view_all_prisons.TabIndex = 10;
            this.view_all_prisons.Text = "view all prisons";
            this.view_all_prisons.UseVisualStyleBackColor = true;
            this.view_all_prisons.Click += new System.EventHandler(this.view_all_prisons_Click);
            // 
            // Prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 403);
            this.Controls.Add(this.Update_prison);
            this.Controls.Add(this.Delete_prison);
            this.Controls.Add(this.insert_prison);
            this.Controls.Add(this.view_one_prison);
            this.Controls.Add(this.view_all_prisons);
            this.Name = "Prison";
            this.Text = "Prison";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_prison;
        private System.Windows.Forms.Button Delete_prison;
        private System.Windows.Forms.Button insert_prison;
        private System.Windows.Forms.Button view_one_prison;
        private System.Windows.Forms.Button view_all_prisons;
    }
}