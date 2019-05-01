namespace prison_system
{
    partial class Form2
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.visit_date_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(904, 501);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // visit_date_combo
            // 
            this.visit_date_combo.FormattingEnabled = true;
            this.visit_date_combo.Location = new System.Drawing.Point(597, 5);
            this.visit_date_combo.Name = "visit_date_combo";
            this.visit_date_combo.Size = new System.Drawing.Size(124, 24);
            this.visit_date_combo.TabIndex = 1;
            this.visit_date_combo.SelectedIndexChanged += new System.EventHandler(this.visit_date_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "visit date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generate_report
            // 
            this.generate_report.Location = new System.Drawing.Point(743, 5);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(124, 36);
            this.generate_report.TabIndex = 3;
            this.generate_report.Text = "generate report";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 501);
            this.Controls.Add(this.generate_report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visit_date_combo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox visit_date_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate_report;
    }
}