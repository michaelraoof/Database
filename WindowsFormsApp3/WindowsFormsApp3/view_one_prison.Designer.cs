namespace WindowsFormsApp3
{
    partial class view_one_prison
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
            this.Select_Number_for_viewprisondata = new System.Windows.Forms.ComboBox();
            this.Select_id_policeman = new System.Windows.Forms.Label();
            this.dataGridView_for_one_prison = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_Number_for_viewprisondata
            // 
            this.Select_Number_for_viewprisondata.FormattingEnabled = true;
            this.Select_Number_for_viewprisondata.Location = new System.Drawing.Point(261, 25);
            this.Select_Number_for_viewprisondata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_Number_for_viewprisondata.Name = "Select_Number_for_viewprisondata";
            this.Select_Number_for_viewprisondata.Size = new System.Drawing.Size(160, 24);
            this.Select_Number_for_viewprisondata.TabIndex = 19;
            this.Select_Number_for_viewprisondata.SelectedIndexChanged += new System.EventHandler(this.Select_Number_for_viewprisondata_SelectedIndexChanged);
            // 
            // Select_id_policeman
            // 
            this.Select_id_policeman.AutoSize = true;
            this.Select_id_policeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_policeman.Location = new System.Drawing.Point(87, 21);
            this.Select_id_policeman.Name = "Select_id_policeman";
            this.Select_id_policeman.Size = new System.Drawing.Size(138, 25);
            this.Select_id_policeman.TabIndex = 18;
            this.Select_id_policeman.Text = "Select prison";
            // 
            // dataGridView_for_one_prison
            // 
            this.dataGridView_for_one_prison.AllowUserToAddRows = false;
            this.dataGridView_for_one_prison.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_prison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_prison.Location = new System.Drawing.Point(17, 107);
            this.dataGridView_for_one_prison.Name = "dataGridView_for_one_prison";
            this.dataGridView_for_one_prison.ReadOnly = true;
            this.dataGridView_for_one_prison.RowTemplate.Height = 24;
            this.dataGridView_for_one_prison.Size = new System.Drawing.Size(586, 285);
            this.dataGridView_for_one_prison.TabIndex = 17;
            // 
            // view_one_prison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 413);
            this.Controls.Add(this.Select_Number_for_viewprisondata);
            this.Controls.Add(this.Select_id_policeman);
            this.Controls.Add(this.dataGridView_for_one_prison);
            this.Name = "view_one_prison";
            this.Text = "view_one_prison";
            this.Load += new System.EventHandler(this.view_one_prison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_Number_for_viewprisondata;
        private System.Windows.Forms.Label Select_id_policeman;
        private System.Windows.Forms.DataGridView dataGridView_for_one_prison;
    }
}