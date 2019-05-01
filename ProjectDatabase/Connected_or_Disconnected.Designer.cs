namespace ProjectDatabase
{
    partial class Connected_or_Disconnected
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.connected_proc = new System.Windows.Forms.Button();
            this.Get_Reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connected_proc
            // 
            this.connected_proc.Location = new System.Drawing.Point(175, 66);
            this.connected_proc.Margin = new System.Windows.Forms.Padding(4);
            this.connected_proc.Name = "connected_proc";
            this.connected_proc.Size = new System.Drawing.Size(173, 62);
            this.connected_proc.TabIndex = 2;
            this.connected_proc.Text = "Connected_proc";
            this.connected_proc.UseVisualStyleBackColor = true;
            this.connected_proc.Click += new System.EventHandler(this.connected_proc_Click);
            // 
            // Get_Reports
            // 
            this.Get_Reports.Location = new System.Drawing.Point(175, 450);
            this.Get_Reports.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Reports.Name = "Get_Reports";
            this.Get_Reports.Size = new System.Drawing.Size(173, 62);
            this.Get_Reports.TabIndex = 3;
            this.Get_Reports.Text = "Get_Reports";
            this.Get_Reports.UseMnemonic = false;
            this.Get_Reports.UseVisualStyleBackColor = true;
            this.Get_Reports.Click += new System.EventHandler(this.Get_Reports_Click);
            // 
            // Connected_or_Disconnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 560);
            this.Controls.Add(this.Get_Reports);
            this.Controls.Add(this.connected_proc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connected_or_Disconnected";
            this.Text = "Connected_or_Disconnected";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button connected_proc;
        private System.Windows.Forms.Button Get_Reports;
    }
}