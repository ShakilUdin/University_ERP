
namespace University_ERP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underGradStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underGradStudentToolStripMenuItem,
            this.gradStudentToolStripMenuItem,
            this.partStudentToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // underGradStudentToolStripMenuItem
            // 
            this.underGradStudentToolStripMenuItem.Name = "underGradStudentToolStripMenuItem";
            this.underGradStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.underGradStudentToolStripMenuItem.Text = "UnderGrad Student";
            this.underGradStudentToolStripMenuItem.Click += new System.EventHandler(this.underGradStudentToolStripMenuItem_Click);
            // 
            // gradStudentToolStripMenuItem
            // 
            this.gradStudentToolStripMenuItem.Name = "gradStudentToolStripMenuItem";
            this.gradStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradStudentToolStripMenuItem.Text = "Grad Student";
            this.gradStudentToolStripMenuItem.Click += new System.EventHandler(this.gradStudentToolStripMenuItem_Click);
            // 
            // partStudentToolStripMenuItem
            // 
            this.partStudentToolStripMenuItem.Name = "partStudentToolStripMenuItem";
            this.partStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partStudentToolStripMenuItem.Text = "Part Student";
            this.partStudentToolStripMenuItem.Click += new System.EventHandler(this.partStudentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underGradStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partStudentToolStripMenuItem;
    }
}

