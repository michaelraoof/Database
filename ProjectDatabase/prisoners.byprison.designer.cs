namespace prison_system
{
    partial class Form3
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
            this.prisoners_prison_combo = new System.Windows.Forms.ComboBox();
            this.Generate_report_buttton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(521, 338);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 150;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // prisoners_prison_combo
            // 
            this.prisoners_prison_combo.FormattingEnabled = true;
            this.prisoners_prison_combo.Location = new System.Drawing.Point(305, 0);
            this.prisoners_prison_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prisoners_prison_combo.Name = "prisoners_prison_combo";
            this.prisoners_prison_combo.Size = new System.Drawing.Size(92, 21);
            this.prisoners_prison_combo.TabIndex = 1;
            // 
            // Generate_report_buttton
            // 
            this.Generate_report_buttton.Location = new System.Drawing.Point(400, 1);
            this.Generate_report_buttton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Generate_report_buttton.Name = "Generate_report_buttton";
            this.Generate_report_buttton.Size = new System.Drawing.Size(94, 23);
            this.Generate_report_buttton.TabIndex = 2;
            this.Generate_report_buttton.Text = "Generate Report";
            this.Generate_report_buttton.UseVisualStyleBackColor = true;
            this.Generate_report_buttton.Click += new System.EventHandler(this.Generate_report_buttton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "prison name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate_report_buttton);
            this.Controls.Add(this.prisoners_prison_combo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox prisoners_prison_combo;
        private System.Windows.Forms.Button Generate_report_buttton;
        private System.Windows.Forms.Label label1;
    }
}