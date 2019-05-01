namespace ProjectDatabase
{
    partial class view_multi_rows_proc
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
            this.view_all_visitors_using_proc = new System.Windows.Forms.Button();
            this.dataGridView1_v_all_visitors_using_proc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_v_all_visitors_using_proc)).BeginInit();
            this.SuspendLayout();
            // 
            // view_all_visitors_using_proc
            // 
            this.view_all_visitors_using_proc.Location = new System.Drawing.Point(414, 32);
            this.view_all_visitors_using_proc.Name = "view_all_visitors_using_proc";
            this.view_all_visitors_using_proc.Size = new System.Drawing.Size(75, 23);
            this.view_all_visitors_using_proc.TabIndex = 5;
            this.view_all_visitors_using_proc.Text = "View";
            this.view_all_visitors_using_proc.UseVisualStyleBackColor = true;
            this.view_all_visitors_using_proc.Click += new System.EventHandler(this.view_all_visitors_using_proc_Click);
            // 
            // dataGridView1_v_all_visitors_using_proc
            // 
            this.dataGridView1_v_all_visitors_using_proc.AllowUserToAddRows = false;
            this.dataGridView1_v_all_visitors_using_proc.AllowUserToDeleteRows = false;
            this.dataGridView1_v_all_visitors_using_proc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_v_all_visitors_using_proc.Location = new System.Drawing.Point(64, 91);
            this.dataGridView1_v_all_visitors_using_proc.Name = "dataGridView1_v_all_visitors_using_proc";
            this.dataGridView1_v_all_visitors_using_proc.ReadOnly = true;
            this.dataGridView1_v_all_visitors_using_proc.RowTemplate.Height = 24;
            this.dataGridView1_v_all_visitors_using_proc.Size = new System.Drawing.Size(832, 334);
            this.dataGridView1_v_all_visitors_using_proc.TabIndex = 4;
            // 
            // view_multi_rows_proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 491);
            this.Controls.Add(this.view_all_visitors_using_proc);
            this.Controls.Add(this.dataGridView1_v_all_visitors_using_proc);
            this.Name = "view_multi_rows_proc";
            this.Text = "view_multi_rows_proc";
            this.Load += new System.EventHandler(this.view_multi_rows_proc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_v_all_visitors_using_proc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_all_visitors_using_proc;
        private System.Windows.Forms.DataGridView dataGridView1_v_all_visitors_using_proc;
    }
}