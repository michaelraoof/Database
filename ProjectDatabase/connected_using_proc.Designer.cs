namespace ProjectDatabase
{
    partial class connected_using_proc
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
            this.view_one_row_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.view_multi_eow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_one_row_button
            // 
            this.view_one_row_button.Location = new System.Drawing.Point(128, 53);
            this.view_one_row_button.Name = "view_one_row_button";
            this.view_one_row_button.Size = new System.Drawing.Size(132, 39);
            this.view_one_row_button.TabIndex = 0;
            this.view_one_row_button.Text = "view_one_row";
            this.view_one_row_button.UseVisualStyleBackColor = true;
            this.view_one_row_button.Click += new System.EventHandler(this.view_one_row_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(128, 186);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(132, 39);
            this.insert_button.TabIndex = 1;
            this.insert_button.Text = "insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(128, 258);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(132, 39);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(128, 326);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(132, 39);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // view_multi_eow
            // 
            this.view_multi_eow.Location = new System.Drawing.Point(128, 118);
            this.view_multi_eow.Name = "view_multi_eow";
            this.view_multi_eow.Size = new System.Drawing.Size(132, 39);
            this.view_multi_eow.TabIndex = 4;
            this.view_multi_eow.Text = "view_multi_row";
            this.view_multi_eow.UseVisualStyleBackColor = true;
            this.view_multi_eow.Click += new System.EventHandler(this.view_multi_eow_Click);
            // 
            // connected_using_proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 448);
            this.Controls.Add(this.view_multi_eow);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.view_one_row_button);
            this.Name = "connected_using_proc";
            this.Text = "connected_using_proc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_one_row_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button view_multi_eow;
    }
}