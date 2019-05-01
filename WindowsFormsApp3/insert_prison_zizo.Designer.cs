namespace WindowsFormsApp3
{
    partial class insert_prison
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
            this.Save_add_prison = new System.Windows.Forms.Button();
            this.Prison_Name_box_insert = new System.Windows.Forms.TextBox();
            this.Location_box_insert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_No_of_prisoners_insert_prison = new System.Windows.Forms.ComboBox();
            this.cmb_no_of_policemen_insert_prison = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save_add_prison
            // 
            this.Save_add_prison.Location = new System.Drawing.Point(364, 221);
            this.Save_add_prison.Name = "Save_add_prison";
            this.Save_add_prison.Size = new System.Drawing.Size(87, 39);
            this.Save_add_prison.TabIndex = 34;
            this.Save_add_prison.Text = "Save";
            this.Save_add_prison.UseVisualStyleBackColor = true;
            this.Save_add_prison.Click += new System.EventHandler(this.Save_add_prison_Click);
            // 
            // Prison_Name_box_insert
            // 
            this.Prison_Name_box_insert.Location = new System.Drawing.Point(234, 27);
            this.Prison_Name_box_insert.Name = "Prison_Name_box_insert";
            this.Prison_Name_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Prison_Name_box_insert.TabIndex = 32;
            // 
            // Location_box_insert
            // 
            this.Location_box_insert.Location = new System.Drawing.Point(234, 78);
            this.Location_box_insert.Name = "Location_box_insert";
            this.Location_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Location_box_insert.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prison_Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "N0_Of_Policemen :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "N0_Of_Prisoners :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Location :";
            // 
            // cmb_No_of_prisoners_insert_prison
            // 
            this.cmb_No_of_prisoners_insert_prison.FormattingEnabled = true;
            this.cmb_No_of_prisoners_insert_prison.Location = new System.Drawing.Point(234, 119);
            this.cmb_No_of_prisoners_insert_prison.Name = "cmb_No_of_prisoners_insert_prison";
            this.cmb_No_of_prisoners_insert_prison.Size = new System.Drawing.Size(100, 24);
            this.cmb_No_of_prisoners_insert_prison.TabIndex = 35;
            // 
            // cmb_no_of_policemen_insert_prison
            // 
            this.cmb_no_of_policemen_insert_prison.FormattingEnabled = true;
            this.cmb_no_of_policemen_insert_prison.Location = new System.Drawing.Point(234, 170);
            this.cmb_no_of_policemen_insert_prison.Name = "cmb_no_of_policemen_insert_prison";
            this.cmb_no_of_policemen_insert_prison.Size = new System.Drawing.Size(100, 24);
            this.cmb_no_of_policemen_insert_prison.TabIndex = 36;
            // 
            // insert_prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.cmb_no_of_policemen_insert_prison);
            this.Controls.Add(this.cmb_No_of_prisoners_insert_prison);
            this.Controls.Add(this.Save_add_prison);
            this.Controls.Add(this.Prison_Name_box_insert);
            this.Controls.Add(this.Location_box_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert_prison";
            this.Text = "insert_prison";
            this.Load += new System.EventHandler(this.insert_prison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_add_prison;
        private System.Windows.Forms.TextBox Prison_Name_box_insert;
        private System.Windows.Forms.TextBox Location_box_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_No_of_prisoners_insert_prison;
        private System.Windows.Forms.ComboBox cmb_no_of_policemen_insert_prison;
    }
}