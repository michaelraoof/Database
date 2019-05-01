namespace WindowsFormsApp3
{
    partial class view_one_case
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
            this.Select_Number_for_viewcasedata = new System.Windows.Forms.ComboBox();
            this.Select_id_policeman = new System.Windows.Forms.Label();
            this.dataGridView_for_one_Case = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_Case)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_Number_for_viewcasedata
            // 
            this.Select_Number_for_viewcasedata.FormattingEnabled = true;
            this.Select_Number_for_viewcasedata.Location = new System.Drawing.Point(256, 61);
            this.Select_Number_for_viewcasedata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_Number_for_viewcasedata.Name = "Select_Number_for_viewcasedata";
            this.Select_Number_for_viewcasedata.Size = new System.Drawing.Size(160, 24);
            this.Select_Number_for_viewcasedata.TabIndex = 13;
            this.Select_Number_for_viewcasedata.SelectedIndexChanged += new System.EventHandler(this.Select_Number_for_viewcasedata_SelectedIndexChanged);
            // 
            // Select_id_policeman
            // 
            this.Select_id_policeman.AutoSize = true;
            this.Select_id_policeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_policeman.Location = new System.Drawing.Point(82, 57);
            this.Select_id_policeman.Name = "Select_id_policeman";
            this.Select_id_policeman.Size = new System.Drawing.Size(154, 25);
            this.Select_id_policeman.TabIndex = 12;
            this.Select_id_policeman.Text = "Select Number";
            this.Select_id_policeman.Click += new System.EventHandler(this.Select_id_policeman_Click);
            // 
            // dataGridView_for_one_Case
            // 
            this.dataGridView_for_one_Case.AllowUserToAddRows = false;
            this.dataGridView_for_one_Case.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_Case.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_Case.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_for_one_Case.Name = "dataGridView_for_one_Case";
            this.dataGridView_for_one_Case.ReadOnly = true;
            this.dataGridView_for_one_Case.RowTemplate.Height = 24;
            this.dataGridView_for_one_Case.Size = new System.Drawing.Size(586, 285);
            this.dataGridView_for_one_Case.TabIndex = 11;
            this.dataGridView_for_one_Case.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_for_one_Case_CellContentClick);
            // 
            // view_one_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 496);
            this.Controls.Add(this.Select_Number_for_viewcasedata);
            this.Controls.Add(this.Select_id_policeman);
            this.Controls.Add(this.dataGridView_for_one_Case);
            this.Name = "view_one_case";
            this.Text = "view_one_case";
            this.Load += new System.EventHandler(this.view_one_case_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_Case)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_Number_for_viewcasedata;
        private System.Windows.Forms.Label Select_id_policeman;
        private System.Windows.Forms.DataGridView dataGridView_for_one_Case;
    }
}