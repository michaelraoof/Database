namespace WindowsFormsApp3
{
    partial class insert_prisoner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.First_name_box = new System.Windows.Forms.TextBox();
            this.Middle_Initial_box = new System.Windows.Forms.TextBox();
            this.Address_box = new System.Windows.Forms.TextBox();
            this.Age_box = new System.Windows.Forms.TextBox();
            this.Prisoner_ID_box = new System.Windows.Forms.TextBox();
            this.Last_Name_box = new System.Windows.Forms.TextBox();
            this.cmb_prisonname_ininsert_prisoner = new System.Windows.Forms.ComboBox();
            this.Save_add_prisoner = new System.Windows.Forms.Button();
            this.cmb_CellNo_for_insertprisoners = new System.Windows.Forms.ComboBox();
            this.Gneder_Prisoner_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First_Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle_Initial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last_Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prisoner_ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Age :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cell_No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Prison_Name :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // First_name_box
            // 
            this.First_name_box.Location = new System.Drawing.Point(236, 29);
            this.First_name_box.Name = "First_name_box";
            this.First_name_box.Size = new System.Drawing.Size(100, 22);
            this.First_name_box.TabIndex = 9;
            // 
            // Middle_Initial_box
            // 
            this.Middle_Initial_box.Location = new System.Drawing.Point(236, 81);
            this.Middle_Initial_box.Name = "Middle_Initial_box";
            this.Middle_Initial_box.Size = new System.Drawing.Size(100, 22);
            this.Middle_Initial_box.TabIndex = 10;
            // 
            // Address_box
            // 
            this.Address_box.Location = new System.Drawing.Point(236, 265);
            this.Address_box.Name = "Address_box";
            this.Address_box.Size = new System.Drawing.Size(100, 22);
            this.Address_box.TabIndex = 12;
            // 
            // Age_box
            // 
            this.Age_box.Location = new System.Drawing.Point(236, 312);
            this.Age_box.Name = "Age_box";
            this.Age_box.Size = new System.Drawing.Size(100, 22);
            this.Age_box.TabIndex = 13;
            // 
            // Prisoner_ID_box
            // 
            this.Prisoner_ID_box.Enabled = false;
            this.Prisoner_ID_box.Location = new System.Drawing.Point(236, 184);
            this.Prisoner_ID_box.Name = "Prisoner_ID_box";
            this.Prisoner_ID_box.Size = new System.Drawing.Size(100, 22);
            this.Prisoner_ID_box.TabIndex = 15;
            // 
            // Last_Name_box
            // 
            this.Last_Name_box.Location = new System.Drawing.Point(236, 131);
            this.Last_Name_box.Name = "Last_Name_box";
            this.Last_Name_box.Size = new System.Drawing.Size(100, 22);
            this.Last_Name_box.TabIndex = 16;
            // 
            // cmb_prisonname_ininsert_prisoner
            // 
            this.cmb_prisonname_ininsert_prisoner.FormattingEnabled = true;
            this.cmb_prisonname_ininsert_prisoner.Location = new System.Drawing.Point(236, 410);
            this.cmb_prisonname_ininsert_prisoner.Name = "cmb_prisonname_ininsert_prisoner";
            this.cmb_prisonname_ininsert_prisoner.Size = new System.Drawing.Size(100, 24);
            this.cmb_prisonname_ininsert_prisoner.TabIndex = 17;
            this.cmb_prisonname_ininsert_prisoner.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Save_add_prisoner
            // 
            this.Save_add_prisoner.Location = new System.Drawing.Point(387, 468);
            this.Save_add_prisoner.Name = "Save_add_prisoner";
            this.Save_add_prisoner.Size = new System.Drawing.Size(87, 39);
            this.Save_add_prisoner.TabIndex = 18;
            this.Save_add_prisoner.Text = "Save";
            this.Save_add_prisoner.UseVisualStyleBackColor = true;
            this.Save_add_prisoner.Click += new System.EventHandler(this.Save_add_prisoner_Click);
            // 
            // cmb_CellNo_for_insertprisoners
            // 
            this.cmb_CellNo_for_insertprisoners.FormattingEnabled = true;
            this.cmb_CellNo_for_insertprisoners.Location = new System.Drawing.Point(236, 357);
            this.cmb_CellNo_for_insertprisoners.Name = "cmb_CellNo_for_insertprisoners";
            this.cmb_CellNo_for_insertprisoners.Size = new System.Drawing.Size(100, 24);
            this.cmb_CellNo_for_insertprisoners.TabIndex = 19;
            this.cmb_CellNo_for_insertprisoners.SelectedIndexChanged += new System.EventHandler(this.cmb_CellNo_for_insertprisoners_SelectedIndexChanged);
            // 
            // Gneder_Prisoner_box
            // 
            this.Gneder_Prisoner_box.Location = new System.Drawing.Point(236, 227);
            this.Gneder_Prisoner_box.Name = "Gneder_Prisoner_box";
            this.Gneder_Prisoner_box.Size = new System.Drawing.Size(100, 22);
            this.Gneder_Prisoner_box.TabIndex = 20;
            // 
            // insert_prisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 519);
            this.Controls.Add(this.Gneder_Prisoner_box);
            this.Controls.Add(this.cmb_CellNo_for_insertprisoners);
            this.Controls.Add(this.Save_add_prisoner);
            this.Controls.Add(this.cmb_prisonname_ininsert_prisoner);
            this.Controls.Add(this.Last_Name_box);
            this.Controls.Add(this.Prisoner_ID_box);
            this.Controls.Add(this.Age_box);
            this.Controls.Add(this.Address_box);
            this.Controls.Add(this.Middle_Initial_box);
            this.Controls.Add(this.First_name_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert_prisoner";
            this.Text = "insert_prisoner";
            this.Load += new System.EventHandler(this.insert_prisoner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox First_name_box;
        private System.Windows.Forms.TextBox Middle_Initial_box;
        private System.Windows.Forms.TextBox Address_box;
        private System.Windows.Forms.TextBox Age_box;
        private System.Windows.Forms.TextBox Prisoner_ID_box;
        private System.Windows.Forms.TextBox Last_Name_box;
        private System.Windows.Forms.ComboBox cmb_prisonname_ininsert_prisoner;
        private System.Windows.Forms.Button Save_add_prisoner;
        private System.Windows.Forms.ComboBox cmb_CellNo_for_insertprisoners;
        private System.Windows.Forms.TextBox Gneder_Prisoner_box;
    }
}