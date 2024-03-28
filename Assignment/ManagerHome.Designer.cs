namespace Assignment
{
    partial class homeManager
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblComManagement = new System.Windows.Forms.LinkLabel();
            this.lblMemRecommendation = new System.Windows.Forms.LinkLabel();
            this.lblMemAssignment = new System.Windows.Forms.LinkLabel();
            this.lblComResult = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Comic Sans MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(256, 46);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(539, 74);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Manager Dashboard";
            // 
            // lblComManagement
            // 
            this.lblComManagement.AutoSize = true;
            this.lblComManagement.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComManagement.LinkColor = System.Drawing.Color.Blue;
            this.lblComManagement.Location = new System.Drawing.Point(261, 204);
            this.lblComManagement.Name = "lblComManagement";
            this.lblComManagement.Size = new System.Drawing.Size(456, 45);
            this.lblComManagement.TabIndex = 2;
            this.lblComManagement.TabStop = true;
            this.lblComManagement.Text = "Competiton Management";
            this.lblComManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComManagement_LinkClicked);
            // 
            // lblMemRecommendation
            // 
            this.lblMemRecommendation.AutoSize = true;
            this.lblMemRecommendation.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemRecommendation.Location = new System.Drawing.Point(261, 285);
            this.lblMemRecommendation.Name = "lblMemRecommendation";
            this.lblMemRecommendation.Size = new System.Drawing.Size(590, 45);
            this.lblMemRecommendation.TabIndex = 3;
            this.lblMemRecommendation.TabStop = true;
            this.lblMemRecommendation.Text = "View Member Recommendations";
            this.lblMemRecommendation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStuRecommendation_LinkClicked);
            // 
            // lblMemAssignment
            // 
            this.lblMemAssignment.AutoSize = true;
            this.lblMemAssignment.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemAssignment.Location = new System.Drawing.Point(261, 363);
            this.lblMemAssignment.Name = "lblMemAssignment";
            this.lblMemAssignment.Size = new System.Drawing.Size(557, 45);
            this.lblMemAssignment.TabIndex = 4;
            this.lblMemAssignment.TabStop = true;
            this.lblMemAssignment.Text = "Assign Member to Competition";
            this.lblMemAssignment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMemAssignment_LinkClicked);
            // 
            // lblComResult
            // 
            this.lblComResult.AutoSize = true;
            this.lblComResult.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblComResult.Location = new System.Drawing.Point(261, 529);
            this.lblComResult.Name = "lblComResult";
            this.lblComResult.Size = new System.Drawing.Size(508, 45);
            this.lblComResult.TabIndex = 6;
            this.lblComResult.TabStop = true;
            this.lblComResult.Text = "Record Competition Results";
            this.lblComResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComResult_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(261, 610);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(269, 45);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "welcome back !";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.Location = new System.Drawing.Point(261, 449);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(604, 45);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Member List of Competition";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // homeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 791);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComResult);
            this.Controls.Add(this.lblMemAssignment);
            this.Controls.Add(this.lblMemRecommendation);
            this.Controls.Add(this.lblComManagement);
            this.Controls.Add(this.lblTitle1);
            this.Name = "homeManager";
            this.Text = "Manager Menu";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.LinkLabel lblComManagement;
        private System.Windows.Forms.LinkLabel lblMemRecommendation;
        private System.Windows.Forms.LinkLabel lblMemAssignment;
        private System.Windows.Forms.LinkLabel lblComResult;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}