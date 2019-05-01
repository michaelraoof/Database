namespace WindowsFormsApp3
{
    partial class update_case
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
            this.cmb_Case_no_Update = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.Crime_box_update = new System.Windows.Forms.TextBox();
            this.Penalty_box_update = new System.Windows.Forms.TextBox();
            this.Case_Type_box_update = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Case_no_Update
            // 
            this.cmb_Case_no_Update.FormattingEnabled = true;
            this.cmb_Case_no_Update.Location = new System.Drawing.Point(231, 38);
            this.cmb_Case_no_Update.Name = "cmb_Case_no_Update";
            this.cmb_Case_no_Update.Size = new System.Drawing.Size(100, 24);
            this.cmb_Case_no_Update.TabIndex = 46;
            this.cmb_Case_no_Update.SelectedIndexChanged += new System.EventHandler(this.cmb_Case_no_Update_SelectedIndexChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(361, 235);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 39);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Crime_box_update
            // 
            this.Crime_box_update.Location = new System.Drawing.Point(231, 187);
            this.Crime_box_update.Name = "Crime_box_update";
            this.Crime_box_update.Size = new System.Drawing.Size(100, 22);
            this.Crime_box_update.TabIndex = 44;
            // 
            // Penalty_box_update
            // 
            this.Penalty_box_update.Location = new System.Drawing.Point(231, 137);
            this.Penalty_box_update.Name = "Penalty_box_update";
            this.Penalty_box_update.Size = new System.Drawing.Size(100, 22);
            this.Penalty_box_update.TabIndex = 43;
            // 
            // Case_Type_box_update
            // 
            this.Case_Type_box_update.Location = new System.Drawing.Point(231, 92);
            this.Case_Type_box_update.Name = "Case_Type_box_update";
            this.Case_Type_box_update.Size = new System.Drawing.Size(100, 22);
            this.Case_Type_box_update.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Case_No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Crime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Penalty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Case_Type :";
            // 
            // update_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.cmb_Case_no_Update);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Crime_box_update);
            this.Controls.Add(this.Penalty_box_update);
            this.Controls.Add(this.Case_Type_box_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update_case";
            this.Text = "update_case";
            this.Load += new System.EventHandler(this.update_case_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Case_no_Update;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Crime_box_update;
        private System.Windows.Forms.TextBox Penalty_box_update;
        private System.Windows.Forms.TextBox Case_Type_box_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}