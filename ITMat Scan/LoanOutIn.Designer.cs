namespace ITMat_Scan
{
    partial class LoanOutIn
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
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.txtDatePickedUp = new System.Windows.Forms.TextBox();
            this.txtOutlookName = new System.Windows.Forms.TextBox();
            this.btnSetReturned = new System.Windows.Forms.Button();
            this.btnSetPickedUp = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.statusLine = new System.Windows.Forms.StatusStrip();
            this.statusLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(12, 85);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.ReadOnly = true;
            this.txtDateReturned.Size = new System.Drawing.Size(118, 20);
            this.txtDateReturned.TabIndex = 17;
            // 
            // txtDatePickedUp
            // 
            this.txtDatePickedUp.Location = new System.Drawing.Point(12, 58);
            this.txtDatePickedUp.Name = "txtDatePickedUp";
            this.txtDatePickedUp.ReadOnly = true;
            this.txtDatePickedUp.Size = new System.Drawing.Size(118, 20);
            this.txtDatePickedUp.TabIndex = 16;
            // 
            // txtOutlookName
            // 
            this.txtOutlookName.Location = new System.Drawing.Point(12, 32);
            this.txtOutlookName.Name = "txtOutlookName";
            this.txtOutlookName.ReadOnly = true;
            this.txtOutlookName.Size = new System.Drawing.Size(181, 20);
            this.txtOutlookName.TabIndex = 15;
            // 
            // btnSetReturned
            // 
            this.btnSetReturned.Enabled = false;
            this.btnSetReturned.Location = new System.Drawing.Point(136, 85);
            this.btnSetReturned.Name = "btnSetReturned";
            this.btnSetReturned.Size = new System.Drawing.Size(57, 20);
            this.btnSetReturned.TabIndex = 14;
            this.btnSetReturned.Text = "Afleveret";
            this.btnSetReturned.UseVisualStyleBackColor = true;
            this.btnSetReturned.Click += new System.EventHandler(this.btnSetReturned_Click);
            // 
            // btnSetPickedUp
            // 
            this.btnSetPickedUp.Enabled = false;
            this.btnSetPickedUp.Location = new System.Drawing.Point(136, 58);
            this.btnSetPickedUp.Name = "btnSetPickedUp";
            this.btnSetPickedUp.Size = new System.Drawing.Size(57, 20);
            this.btnSetPickedUp.TabIndex = 13;
            this.btnSetPickedUp.Text = "Afhentet";
            this.btnSetPickedUp.UseVisualStyleBackColor = true;
            this.btnSetPickedUp.Click += new System.EventHandler(this.btnSetPickedUp_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(9, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 13);
            this.lblOrderID.TabIndex = 12;
            this.lblOrderID.Text = "Ordrenummer";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(94, 6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(99, 20);
            this.txtOrderID.TabIndex = 11;
            // 
            // statusLine
            // 
            this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLineLabel});
            this.statusLine.Location = new System.Drawing.Point(0, 127);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(205, 22);
            this.statusLine.SizingGrip = false;
            this.statusLine.TabIndex = 18;
            this.statusLine.Text = "statusStrip1";
            // 
            // statusLineLabel
            // 
            this.statusLineLabel.Name = "statusLineLabel";
            this.statusLineLabel.Size = new System.Drawing.Size(88, 17);
            this.statusLineLabel.Text = "statusLineLabel";
            // 
            // LoanOutIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 149);
            this.Controls.Add(this.statusLine);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDatePickedUp);
            this.Controls.Add(this.txtOutlookName);
            this.Controls.Add(this.btnSetReturned);
            this.Controls.Add(this.btnSetPickedUp);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "LoanOutIn";
            this.Text = "LoanOutIn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoanOutIn_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoanOutIn_KeyPress);
            this.statusLine.ResumeLayout(false);
            this.statusLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.TextBox txtDatePickedUp;
        private System.Windows.Forms.TextBox txtOutlookName;
        private System.Windows.Forms.Button btnSetReturned;
        private System.Windows.Forms.Button btnSetPickedUp;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.StatusStrip statusLine;
        private System.Windows.Forms.ToolStripStatusLabel statusLineLabel;

    }
}