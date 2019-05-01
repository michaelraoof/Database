namespace WindowsFormsApp3
{
    partial class insert_case
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
            this.Crime_box_insert = new System.Windows.Forms.TextBox();
            this.Case_No_box_insert = new System.Windows.Forms.TextBox();
            this.penalty_box_insert = new System.Windows.Forms.TextBox();
            this.Case_Type_box_insert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_add_prison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crime_box_insert
            // 
            this.Crime_box_insert.Location = new System.Drawing.Point(235, 191);
            this.Crime_box_insert.Name = "Crime_box_insert";
            this.Crime_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Crime_box_insert.TabIndex = 24;
            // 
            // Case_No_box_insert
            // 
            this.Case_No_box_insert.Enabled = false;
            this.Case_No_box_insert.Location = new System.Drawing.Point(235, 45);
            this.Case_No_box_insert.Name = "Case_No_box_insert";
            this.Case_No_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Case_No_box_insert.TabIndex = 23;
            // 
            // penalty_box_insert
            // 
            this.penalty_box_insert.Location = new System.Drawing.Point(235, 141);
            this.penalty_box_insert.Name = "penalty_box_insert";
            this.penalty_box_insert.Size = new System.Drawing.Size(100, 22);
            this.penalty_box_insert.TabIndex = 22;
            // 
            // Case_Type_box_insert
            // 
            this.Case_Type_box_insert.Location = new System.Drawing.Point(235, 96);
            this.Case_Type_box_insert.Name = "Case_Type_box_insert";
            this.Case_Type_box_insert.Size = new System.Drawing.Size(100, 22);
            this.Case_Type_box_insert.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Case_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Crime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Penalty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Case_Type :";
            // 
            // Save_add_prison
            // 
            this.Save_add_prison.Location = new System.Drawing.Point(365, 239);
            this.Save_add_prison.Name = "Save_add_prison";
            this.Save_add_prison.Size = new System.Drawing.Size(87, 39);
            this.Save_add_prison.TabIndex = 25;
            this.Save_add_prison.Text = "Save";
            this.Save_add_prison.UseVisualStyleBackColor = true;
            this.Save_add_prison.Click += new System.EventHandler(this.Save_add_Case_Click);
            // 
            // insert_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 300);
            this.Controls.Add(this.Save_add_prison);
            this.Controls.Add(this.Crime_box_insert);
            this.Controls.Add(this.Case_No_box_insert);
            this.Controls.Add(this.penalty_box_insert);
            this.Controls.Add(this.Case_Type_box_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert_case";
            this.Text = "insert_case";
            this.Load += new System.EventHandler(this.insert_case_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Crime_box_insert;
        private System.Windows.Forms.TextBox Case_No_box_insert;
        private System.Windows.Forms.TextBox penalty_box_insert;
        private System.Windows.Forms.TextBox Case_Type_box_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_add_prison;
    }
}