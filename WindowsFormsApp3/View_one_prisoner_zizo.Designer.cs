namespace WindowsFormsApp3
{
    partial class View_one_prisoner
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
            this.dataGridView_for_one_prison = new System.Windows.Forms.DataGridView();
            this.Select_id = new System.Windows.Forms.Label();
            this.Select_ID_for_viewprisonerdata = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_for_one_prison
            // 
            this.dataGridView_for_one_prison.AllowUserToAddRows = false;
            this.dataGridView_for_one_prison.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_prison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_prison.Location = new System.Drawing.Point(45, 90);
            this.dataGridView_for_one_prison.Name = "dataGridView_for_one_prison";
            this.dataGridView_for_one_prison.ReadOnly = true;
            this.dataGridView_for_one_prison.RowTemplate.Height = 24;
            this.dataGridView_for_one_prison.Size = new System.Drawing.Size(944, 285);
            this.dataGridView_for_one_prison.TabIndex = 2;
            this.dataGridView_for_one_prison.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_for_one_prison_CellContentClick);
            // 
            // Select_id
            // 
            this.Select_id.AutoSize = true;
            this.Select_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id.Location = new System.Drawing.Point(330, 23);
            this.Select_id.Name = "Select_id";
            this.Select_id.Size = new System.Drawing.Size(100, 25);
            this.Select_id.TabIndex = 4;
            this.Select_id.Text = "Select ID";
            // 
            // Select_ID_for_viewprisonerdata
            // 
            this.Select_ID_for_viewprisonerdata.FormattingEnabled = true;
            this.Select_ID_for_viewprisonerdata.Location = new System.Drawing.Point(437, 27);
            this.Select_ID_for_viewprisonerdata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_ID_for_viewprisonerdata.Name = "Select_ID_for_viewprisonerdata";
            this.Select_ID_for_viewprisonerdata.Size = new System.Drawing.Size(160, 24);
            this.Select_ID_for_viewprisonerdata.TabIndex = 7;
            this.Select_ID_for_viewprisonerdata.SelectedIndexChanged += new System.EventHandler(this.Select_ID_for_viewprisondata_SelectedIndexChanged);
            // 
            // View_one_prisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 423);
            this.Controls.Add(this.Select_ID_for_viewprisonerdata);
            this.Controls.Add(this.Select_id);
            this.Controls.Add(this.dataGridView_for_one_prison);
            this.Name = "View_one_prisoner";
            this.Text = "View_one_prison";
            this.Load += new System.EventHandler(this.View_one_prisoner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_for_one_prison;
        private System.Windows.Forms.Label Select_id;
        private System.Windows.Forms.ComboBox Select_ID_for_viewprisonerdata;
    }
}