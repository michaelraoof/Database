namespace WindowsFormsApp3
{
    partial class Main_Form
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
            this.Prisoners = new System.Windows.Forms.Button();
            this.Prison = new System.Windows.Forms.Button();
            this.Visitor = new System.Windows.Forms.Button();
            this.Policeman = new System.Windows.Forms.Button();
            this.Cases = new System.Windows.Forms.Button();
            this.Cells = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prisoners
            // 
            this.Prisoners.Location = new System.Drawing.Point(160, 35);
            this.Prisoners.Name = "Prisoners";
            this.Prisoners.Size = new System.Drawing.Size(108, 52);
            this.Prisoners.TabIndex = 0;
            this.Prisoners.Text = "Prisoners";
            this.Prisoners.UseVisualStyleBackColor = true;
            this.Prisoners.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prison
            // 
            this.Prison.Location = new System.Drawing.Point(160, 184);
            this.Prison.Name = "Prison";
            this.Prison.Size = new System.Drawing.Size(108, 52);
            this.Prison.TabIndex = 1;
            this.Prison.Text = "Prison";
            this.Prison.UseVisualStyleBackColor = true;
            this.Prison.Click += new System.EventHandler(this.button2_Click);
            // 
            // Visitor
            // 
            this.Visitor.Location = new System.Drawing.Point(160, 110);
            this.Visitor.Name = "Visitor";
            this.Visitor.Size = new System.Drawing.Size(108, 52);
            this.Visitor.TabIndex = 2;
            this.Visitor.Text = "Visitor";
            this.Visitor.UseVisualStyleBackColor = true;
            this.Visitor.Click += new System.EventHandler(this.Visitor_Click);
            // 
            // Policeman
            // 
            this.Policeman.Location = new System.Drawing.Point(160, 256);
            this.Policeman.Name = "Policeman";
            this.Policeman.Size = new System.Drawing.Size(108, 52);
            this.Policeman.TabIndex = 3;
            this.Policeman.Text = "Policeman";
            this.Policeman.UseVisualStyleBackColor = true;
            this.Policeman.Click += new System.EventHandler(this.Policeman_Click);
            // 
            // Cases
            // 
            this.Cases.Location = new System.Drawing.Point(160, 325);
            this.Cases.Name = "Cases";
            this.Cases.Size = new System.Drawing.Size(108, 52);
            this.Cases.TabIndex = 4;
            this.Cases.Text = "Cases";
            this.Cases.UseVisualStyleBackColor = true;
            this.Cases.Click += new System.EventHandler(this.Cases_Click);
            // 
            // Cells
            // 
            this.Cells.Location = new System.Drawing.Point(160, 406);
            this.Cells.Name = "Cells";
            this.Cells.Size = new System.Drawing.Size(108, 52);
            this.Cells.TabIndex = 5;
            this.Cells.Text = "Cells";
            this.Cells.UseVisualStyleBackColor = true;
            this.Cells.Click += new System.EventHandler(this.Cells_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 488);
            this.Controls.Add(this.Cells);
            this.Controls.Add(this.Cases);
            this.Controls.Add(this.Policeman);
            this.Controls.Add(this.Visitor);
            this.Controls.Add(this.Prison);
            this.Controls.Add(this.Prisoners);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prisoners;
        private System.Windows.Forms.Button Prison;
        private System.Windows.Forms.Button Visitor;
        private System.Windows.Forms.Button Policeman;
        private System.Windows.Forms.Button Cases;
        private System.Windows.Forms.Button Cells;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

