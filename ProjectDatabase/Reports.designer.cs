namespace prison_system
{
    partial class Reports
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
            this.PrisonersByPrisonbutton = new System.Windows.Forms.Button();
            this.PolicemenByPrisonbutton = new System.Windows.Forms.Button();
            this.Visitsbydatebutton = new System.Windows.Forms.Button();
            this.Prisonersbycrimebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrisonersByPrisonbutton
            // 
            this.PrisonersByPrisonbutton.Location = new System.Drawing.Point(35, 29);
            this.PrisonersByPrisonbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrisonersByPrisonbutton.Name = "PrisonersByPrisonbutton";
            this.PrisonersByPrisonbutton.Size = new System.Drawing.Size(70, 46);
            this.PrisonersByPrisonbutton.TabIndex = 0;
            this.PrisonersByPrisonbutton.Text = "Prisoners By Prison";
            this.PrisonersByPrisonbutton.UseVisualStyleBackColor = true;
            this.PrisonersByPrisonbutton.Click += new System.EventHandler(this.PrisonersByPrisonbutton_Click);
            // 
            // PolicemenByPrisonbutton
            // 
            this.PolicemenByPrisonbutton.Location = new System.Drawing.Point(35, 100);
            this.PolicemenByPrisonbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolicemenByPrisonbutton.Name = "PolicemenByPrisonbutton";
            this.PolicemenByPrisonbutton.Size = new System.Drawing.Size(70, 40);
            this.PolicemenByPrisonbutton.TabIndex = 1;
            this.PolicemenByPrisonbutton.Text = "Policemen By Prison";
            this.PolicemenByPrisonbutton.UseVisualStyleBackColor = true;
            this.PolicemenByPrisonbutton.Click += new System.EventHandler(this.PolicemenByPrisonbutton_Click);
            // 
            // Visitsbydatebutton
            // 
            this.Visitsbydatebutton.Location = new System.Drawing.Point(175, 100);
            this.Visitsbydatebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Visitsbydatebutton.Name = "Visitsbydatebutton";
            this.Visitsbydatebutton.Size = new System.Drawing.Size(71, 45);
            this.Visitsbydatebutton.TabIndex = 2;
            this.Visitsbydatebutton.Text = "Visits By Date";
            this.Visitsbydatebutton.UseVisualStyleBackColor = true;
            this.Visitsbydatebutton.Click += new System.EventHandler(this.Visitsbydatebutton_Click);
            // 
            // Prisonersbycrimebutton
            // 
            this.Prisonersbycrimebutton.Location = new System.Drawing.Point(175, 29);
            this.Prisonersbycrimebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prisonersbycrimebutton.Name = "Prisonersbycrimebutton";
            this.Prisonersbycrimebutton.Size = new System.Drawing.Size(86, 46);
            this.Prisonersbycrimebutton.TabIndex = 3;
            this.Prisonersbycrimebutton.Text = "Prisoners By Crime";
            this.Prisonersbycrimebutton.UseVisualStyleBackColor = true;
            this.Prisonersbycrimebutton.Click += new System.EventHandler(this.Prisonersbycrimebutton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 380);
            this.Controls.Add(this.Prisonersbycrimebutton);
            this.Controls.Add(this.Visitsbydatebutton);
            this.Controls.Add(this.PolicemenByPrisonbutton);
            this.Controls.Add(this.PrisonersByPrisonbutton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrisonersByPrisonbutton;
        private System.Windows.Forms.Button PolicemenByPrisonbutton;
        private System.Windows.Forms.Button Visitsbydatebutton;
        private System.Windows.Forms.Button Prisonersbycrimebutton;
    }
}