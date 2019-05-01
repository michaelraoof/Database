namespace WindowsFormsApp3
{
    partial class View_All_Visitors
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
            this.Viewfor_all_visitors = new System.Windows.Forms.Button();
            this.dataGridView1_v_all_visitors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_v_all_visitors)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewfor_all_visitors
            // 
            this.Viewfor_all_visitors.Location = new System.Drawing.Point(379, 25);
            this.Viewfor_all_visitors.Name = "Viewfor_all_visitors";
            this.Viewfor_all_visitors.Size = new System.Drawing.Size(75, 23);
            this.Viewfor_all_visitors.TabIndex = 3;
            this.Viewfor_all_visitors.Text = "View";
            this.Viewfor_all_visitors.UseVisualStyleBackColor = true;
            this.Viewfor_all_visitors.Click += new System.EventHandler(this.Viewfor_all_visitors_Click);
            // 
            // dataGridView1_v_all_visitors
            // 
            this.dataGridView1_v_all_visitors.AllowUserToAddRows = false;
            this.dataGridView1_v_all_visitors.AllowUserToDeleteRows = false;
            this.dataGridView1_v_all_visitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_v_all_visitors.Location = new System.Drawing.Point(29, 84);
            this.dataGridView1_v_all_visitors.Name = "dataGridView1_v_all_visitors";
            this.dataGridView1_v_all_visitors.ReadOnly = true;
            this.dataGridView1_v_all_visitors.RowTemplate.Height = 24;
            this.dataGridView1_v_all_visitors.Size = new System.Drawing.Size(832, 334);
            this.dataGridView1_v_all_visitors.TabIndex = 2;
            // 
            // View_All_Visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 430);
            this.Controls.Add(this.Viewfor_all_visitors);
            this.Controls.Add(this.dataGridView1_v_all_visitors);
            this.Name = "View_All_Visitors";
            this.Text = "View_All_Visitors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_v_all_visitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Viewfor_all_visitors;
        private System.Windows.Forms.DataGridView dataGridView1_v_all_visitors;
    }
}