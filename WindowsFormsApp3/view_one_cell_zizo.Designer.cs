namespace WindowsFormsApp3
{
    partial class view_one_cell
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
            this.Select_Number_for_viewcelldata = new System.Windows.Forms.ComboBox();
            this.Select_id_policeman = new System.Windows.Forms.Label();
            this.dataGridView_for_one_Cell = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_Cell)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_Number_for_viewcelldata
            // 
            this.Select_Number_for_viewcelldata.FormattingEnabled = true;
            this.Select_Number_for_viewcelldata.Location = new System.Drawing.Point(300, 25);
            this.Select_Number_for_viewcelldata.Margin = new System.Windows.Forms.Padding(4);
            this.Select_Number_for_viewcelldata.Name = "Select_Number_for_viewcelldata";
            this.Select_Number_for_viewcelldata.Size = new System.Drawing.Size(160, 24);
            this.Select_Number_for_viewcelldata.TabIndex = 16;
            this.Select_Number_for_viewcelldata.SelectedIndexChanged += new System.EventHandler(this.Select_Number_for_viewcelldata_SelectedIndexChanged);
            // 
            // Select_id_policeman
            // 
            this.Select_id_policeman.AutoSize = true;
            this.Select_id_policeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_id_policeman.Location = new System.Drawing.Point(126, 21);
            this.Select_id_policeman.Name = "Select_id_policeman";
            this.Select_id_policeman.Size = new System.Drawing.Size(154, 25);
            this.Select_id_policeman.TabIndex = 15;
            this.Select_id_policeman.Text = "Select Number";
            // 
            // dataGridView_for_one_Cell
            // 
            this.dataGridView_for_one_Cell.AllowUserToAddRows = false;
            this.dataGridView_for_one_Cell.AllowUserToDeleteRows = false;
            this.dataGridView_for_one_Cell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_one_Cell.Location = new System.Drawing.Point(56, 107);
            this.dataGridView_for_one_Cell.Name = "dataGridView_for_one_Cell";
            this.dataGridView_for_one_Cell.ReadOnly = true;
            this.dataGridView_for_one_Cell.RowTemplate.Height = 24;
            this.dataGridView_for_one_Cell.Size = new System.Drawing.Size(586, 285);
            this.dataGridView_for_one_Cell.TabIndex = 14;
            // 
            // view_one_cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 413);
            this.Controls.Add(this.Select_Number_for_viewcelldata);
            this.Controls.Add(this.Select_id_policeman);
            this.Controls.Add(this.dataGridView_for_one_Cell);
            this.Name = "view_one_cell";
            this.Text = "view_one_cell";
            this.Load += new System.EventHandler(this.view_one_cell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_one_Cell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_Number_for_viewcelldata;
        private System.Windows.Forms.Label Select_id_policeman;
        private System.Windows.Forms.DataGridView dataGridView_for_one_Cell;
    }
}