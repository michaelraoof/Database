namespace WindowsFormsApp3
{
    partial class view_one_policeman
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
            this.Select_ID_for_viewpolicemandata = new System.Windows.Forms.ComboBox();
            this.Select_id_policeman = new System.Windows.Forms.Label();
            this.dataGridView_for_one_policeman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_policeman)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_ID_for_viewpolicemandata
            // 
            this.Select_ID_for_viewpolicemandata.FormattingEnabled = true;
            this.Select_ID_for_viewpolicemandata.Location = new System.Drawing.Point(412, 55);
            this.Select_ID_for_viewpolicemandata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_ID_for_viewpolicemandata.Name = "Select_ID_for_viewpolicemandata";
            this.Select_ID_for_viewpolicemandata.Size = new System.Drawing.Size(160, 24);
            this.Select_ID_for_viewpolicemandata.TabIndex = 10;
            this.Select_ID_for_viewpolicemandata.SelectedIndexChanged += new System.EventHandler(this.Select_ID_for_viewpolicemandata_SelectedIndexChanged);
            // 
            // Select_id_policeman
            // 
            this.Select_id_policeman.AutoSize = true;
            this.Select_id_policeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_policeman.Location = new System.Drawing.Point(305, 51);
            this.Select_id_policeman.Name = "Select_id_policeman";
            this.Select_id_policeman.Size = new System.Drawing.Size(100, 25);
            this.Select_id_policeman.TabIndex = 9;
            this.Select_id_policeman.Text = "Select ID";
            // 
            // dataGridView_for_one_policeman
            // 
            this.dataGridView_for_one_policeman.AllowUserToAddRows = false;
            this.dataGridView_for_one_policeman.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_policeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_policeman.Location = new System.Drawing.Point(12, 135);
            this.dataGridView_for_one_policeman.Name = "dataGridView_for_one_policeman";
            this.dataGridView_for_one_policeman.ReadOnly = true;
            this.dataGridView_for_one_policeman.RowTemplate.Height = 24;
            this.dataGridView_for_one_policeman.Size = new System.Drawing.Size(944, 285);
            this.dataGridView_for_one_policeman.TabIndex = 8;
            // 
            // view_one_policeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 477);
            this.Controls.Add(this.Select_ID_for_viewpolicemandata);
            this.Controls.Add(this.Select_id_policeman);
            this.Controls.Add(this.dataGridView_for_one_policeman);
            this.Name = "view_one_policeman";
            this.Text = "view_one_policeman";
            this.Load += new System.EventHandler(this.view_one_policeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_policeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_ID_for_viewpolicemandata;
        private System.Windows.Forms.Label Select_id_policeman;
        private System.Windows.Forms.DataGridView dataGridView_for_one_policeman;
    }
}