namespace prison_system
{
    partial class Form1
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
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.generatereport = new System.Windows.Forms.Button();
            this.prison_name_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(751, 395);
            this.crystalReportViewer3.TabIndex = 0;
            this.crystalReportViewer3.Load += new System.EventHandler(this.crystalReportViewer3_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "prison name";
            // 
            // generatereport
            // 
            this.generatereport.Location = new System.Drawing.Point(529, -1);
            this.generatereport.Name = "generatereport";
            this.generatereport.Size = new System.Drawing.Size(134, 30);
            this.generatereport.TabIndex = 2;
            this.generatereport.Text = "generate report";
            this.generatereport.UseVisualStyleBackColor = true;
            this.generatereport.Click += new System.EventHandler(this.generatereport_Click);
            // 
            // prison_name_combo
            // 
            this.prison_name_combo.FormattingEnabled = true;
            this.prison_name_combo.Location = new System.Drawing.Point(402, 3);
            this.prison_name_combo.Name = "prison_name_combo";
            this.prison_name_combo.Size = new System.Drawing.Size(121, 24);
            this.prison_name_combo.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(751, 395);
            this.Controls.Add(this.prison_name_combo);
            this.Controls.Add(this.generatereport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crystalReportViewer3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generatereport;
        private System.Windows.Forms.ComboBox prison_name_combo;
    }
}

