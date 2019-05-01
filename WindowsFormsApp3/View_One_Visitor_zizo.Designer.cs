namespace WindowsFormsApp3
{
    partial class View_One_Visitor
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
            this.Select_ID_for_viewVisitordata = new System.Windows.Forms.ComboBox();
            this.Select_id_visitor = new System.Windows.Forms.Label();
            this.dataGridView_for_one_prison = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_ID_for_viewVisitordata
            // 
            this.Select_ID_for_viewVisitordata.FormattingEnabled = true;
            this.Select_ID_for_viewVisitordata.Location = new System.Drawing.Point(431, 37);
            this.Select_ID_for_viewVisitordata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_ID_for_viewVisitordata.Name = "Select_ID_for_viewVisitordata";
            this.Select_ID_for_viewVisitordata.Size = new System.Drawing.Size(160, 24);
            this.Select_ID_for_viewVisitordata.TabIndex = 10;
            this.Select_ID_for_viewVisitordata.SelectedIndexChanged += new System.EventHandler(this.Select_ID_for_viewVisitordata_SelectedIndexChanged);
            // 
            // Select_id_visitor
            // 
            this.Select_id_visitor.AutoSize = true;
            this.Select_id_visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_visitor.Location = new System.Drawing.Point(291, 37);
            this.Select_id_visitor.Name = "Select_id_visitor";
            this.Select_id_visitor.Size = new System.Drawing.Size(100, 25);
            this.Select_id_visitor.TabIndex = 9;
            this.Select_id_visitor.Text = "Select ID";
            // 
            // dataGridView_for_one_prison
            // 
            this.dataGridView_for_one_prison.AllowUserToAddRows = false;
            this.dataGridView_for_one_prison.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_prison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_prison.Location = new System.Drawing.Point(39, 125);
            this.dataGridView_for_one_prison.Name = "dataGridView_for_one_prison";
            this.dataGridView_for_one_prison.ReadOnly = true;
            this.dataGridView_for_one_prison.RowTemplate.Height = 24;
            this.dataGridView_for_one_prison.Size = new System.Drawing.Size(898, 285);
            this.dataGridView_for_one_prison.TabIndex = 8;
            this.dataGridView_for_one_prison.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_for_one_prison_CellContentClick);
            // 
            // View_One_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 462);
            this.Controls.Add(this.Select_ID_for_viewVisitordata);
            this.Controls.Add(this.Select_id_visitor);
            this.Controls.Add(this.dataGridView_for_one_prison);
            this.Name = "View_One_Visitor";
            this.Text = "View_One_Visitor";
            this.Load += new System.EventHandler(this.View_One_Visitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_prison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_ID_for_viewVisitordata;
        private System.Windows.Forms.Label Select_id_visitor;
        private System.Windows.Forms.DataGridView dataGridView_for_one_prison;
    }
}