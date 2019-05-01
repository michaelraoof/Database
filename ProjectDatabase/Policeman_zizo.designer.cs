namespace WindowsFormsApp3
{
    partial class Policeman
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
            this.Update_policman = new System.Windows.Forms.Button();
            this.Delete_policeman = new System.Windows.Forms.Button();
            this.insert_policeman = new System.Windows.Forms.Button();
            this.view_one_policeman = new System.Windows.Forms.Button();
            this.view_all_policeman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_policman
            // 
            this.Update_policman.Location = new System.Drawing.Point(116, 291);
            this.Update_policman.Name = "Update_policman";
            this.Update_policman.Size = new System.Drawing.Size(154, 35);
            this.Update_policman.TabIndex = 9;
            this.Update_policman.Text = "Update policeman";
            this.Update_policman.UseVisualStyleBackColor = true;
            this.Update_policman.Click += new System.EventHandler(this.Update_policman_Click);
            // 
            // Delete_policeman
            // 
            this.Delete_policeman.Location = new System.Drawing.Point(116, 224);
            this.Delete_policeman.Name = "Delete_policeman";
            this.Delete_policeman.Size = new System.Drawing.Size(154, 35);
            this.Delete_policeman.TabIndex = 8;
            this.Delete_policeman.Text = "Delete policeman";
            this.Delete_policeman.UseVisualStyleBackColor = true;
            this.Delete_policeman.Click += new System.EventHandler(this.Delete_policeman_Click);
            // 
            // insert_policeman
            // 
            this.insert_policeman.Location = new System.Drawing.Point(116, 161);
            this.insert_policeman.Name = "insert_policeman";
            this.insert_policeman.Size = new System.Drawing.Size(154, 35);
            this.insert_policeman.TabIndex = 7;
            this.insert_policeman.Text = "Insert policeman";
            this.insert_policeman.UseVisualStyleBackColor = true;
            this.insert_policeman.Click += new System.EventHandler(this.insert_policeman_Click);
            // 
            // view_one_policeman
            // 
            this.view_one_policeman.Location = new System.Drawing.Point(116, 98);
            this.view_one_policeman.Name = "view_one_policeman";
            this.view_one_policeman.Size = new System.Drawing.Size(154, 35);
            this.view_one_policeman.TabIndex = 6;
            this.view_one_policeman.Text = "view one policeman";
            this.view_one_policeman.UseVisualStyleBackColor = true;
            this.view_one_policeman.Click += new System.EventHandler(this.view_one_policeman_Click);
            // 
            // view_all_policeman
            // 
            this.view_all_policeman.Location = new System.Drawing.Point(116, 38);
            this.view_all_policeman.Name = "view_all_policeman";
            this.view_all_policeman.Size = new System.Drawing.Size(154, 35);
            this.view_all_policeman.TabIndex = 5;
            this.view_all_policeman.Text = "view all policemen";
            this.view_all_policeman.UseVisualStyleBackColor = true;
            this.view_all_policeman.Click += new System.EventHandler(this.view_all_policeman_Click);
            // 
            // Policeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 370);
            this.Controls.Add(this.Update_policman);
            this.Controls.Add(this.Delete_policeman);
            this.Controls.Add(this.insert_policeman);
            this.Controls.Add(this.view_one_policeman);
            this.Controls.Add(this.view_all_policeman);
            this.Name = "Policeman";
            this.Text = "Policeman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_policman;
        private System.Windows.Forms.Button Delete_policeman;
        private System.Windows.Forms.Button insert_policeman;
        private System.Windows.Forms.Button view_one_policeman;
        private System.Windows.Forms.Button view_all_policeman;
    }
}