namespace ITMat_Scan
{
    partial class MainMenu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoanOutIn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.udlånAfleverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.afslutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 543);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(222, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnLoanOutIn
            // 
            this.btnLoanOutIn.Location = new System.Drawing.Point(167, 286);
            this.btnLoanOutIn.Name = "btnLoanOutIn";
            this.btnLoanOutIn.Size = new System.Drawing.Size(126, 23);
            this.btnLoanOutIn.TabIndex = 1;
            this.btnLoanOutIn.Text = "Udlån/Aflever";
            this.btnLoanOutIn.UseVisualStyleBackColor = true;
            this.btnLoanOutIn.Click += new System.EventHandler(this.btnLoanOutIn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kundeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opretToolStripMenuItem,
            this.udlånAfleverToolStripMenuItem,
            this.toolStripMenuItem3,
            this.afslutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Udlån";
            // 
            // udlånAfleverToolStripMenuItem
            // 
            this.udlånAfleverToolStripMenuItem.Name = "udlånAfleverToolStripMenuItem";
            this.udlånAfleverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.udlånAfleverToolStripMenuItem.Text = "Se udlån";
            // 
            // opretToolStripMenuItem
            // 
            this.opretToolStripMenuItem.Name = "opretToolStripMenuItem";
            this.opretToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opretToolStripMenuItem.Text = "Opret";
            // 
            // kundeToolStripMenuItem
            // 
            this.kundeToolStripMenuItem.Name = "kundeToolStripMenuItem";
            this.kundeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.kundeToolStripMenuItem.Text = "Kunde";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // afslutToolStripMenuItem
            // 
            this.afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            this.afslutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afslutToolStripMenuItem.Text = "Afslut";
            this.afslutToolStripMenuItem.Click += new System.EventHandler(this.afslutToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 660);
            this.Controls.Add(this.btnLoanOutIn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "ITMat Scan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoanOutIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem udlånAfleverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem afslutToolStripMenuItem;
    }
}

