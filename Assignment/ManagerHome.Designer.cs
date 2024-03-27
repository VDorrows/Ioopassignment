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
            this.lblStuRecommendation = new System.Windows.Forms.LinkLabel();
            this.lblMemAssignment = new System.Windows.Forms.LinkLabel();
            this.lblComDetail = new System.Windows.Forms.LinkLabel();
            this.lblComResult = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(357, 70);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(431, 51);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Manager Dashboard";
            // 
            // lblComManagement
            // 
            this.lblComManagement.AutoSize = true;
            this.lblComManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComManagement.Location = new System.Drawing.Point(359, 212);
            this.lblComManagement.Name = "lblComManagement";
            this.lblComManagement.Size = new System.Drawing.Size(376, 37);
            this.lblComManagement.TabIndex = 2;
            this.lblComManagement.TabStop = true;
            this.lblComManagement.Text = "Competiton Management";
            this.lblComManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComManagement_LinkClicked);
            // 
            // lblStuRecommendation
            // 
            this.lblStuRecommendation.AutoSize = true;
            this.lblStuRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuRecommendation.Location = new System.Drawing.Point(359, 295);
            this.lblStuRecommendation.Name = "lblStuRecommendation";
            this.lblStuRecommendation.Size = new System.Drawing.Size(480, 37);
            this.lblStuRecommendation.TabIndex = 3;
            this.lblStuRecommendation.TabStop = true;
            this.lblStuRecommendation.Text = "View Student Recommendations";
            this.lblStuRecommendation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStuRecommendation_LinkClicked);
            // 
            // lblMemAssignment
            // 
            this.lblMemAssignment.AutoSize = true;
            this.lblMemAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemAssignment.Location = new System.Drawing.Point(359, 371);
            this.lblMemAssignment.Name = "lblMemAssignment";
            this.lblMemAssignment.Size = new System.Drawing.Size(471, 37);
            this.lblMemAssignment.TabIndex = 4;
            this.lblMemAssignment.TabStop = true;
            this.lblMemAssignment.Text = "Assign Members to Competition";
            this.lblMemAssignment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMemAssignment_LinkClicked);
            // 
            // lblComDetail
            // 
            this.lblComDetail.AutoSize = true;
            this.lblComDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComDetail.Location = new System.Drawing.Point(359, 449);
            this.lblComDetail.Name = "lblComDetail";
            this.lblComDetail.Size = new System.Drawing.Size(372, 37);
            this.lblComDetail.TabIndex = 5;
            this.lblComDetail.TabStop = true;
            this.lblComDetail.Text = "View Competition Details";
            this.lblComDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComDetail_LinkClicked);
            // 
            // lblComResult
            // 
            this.lblComResult.AutoSize = true;
            this.lblComResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComResult.Location = new System.Drawing.Point(359, 529);
            this.lblComResult.Name = "lblComResult";
            this.lblComResult.Size = new System.Drawing.Size(413, 37);
            this.lblComResult.TabIndex = 6;
            this.lblComResult.TabStop = true;
            this.lblComResult.Text = "Record Competition Results";
            this.lblComResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblComResult_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(359, 614);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(219, 37);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update Profile";
            // 
            // homeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 729);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblComResult);
            this.Controls.Add(this.lblComDetail);
            this.Controls.Add(this.lblMemAssignment);
            this.Controls.Add(this.lblStuRecommendation);
            this.Controls.Add(this.lblComManagement);
            this.Controls.Add(this.lblTitle1);
            this.Name = "homeManager";
            this.Text = "Manager Home";
            this.Load += new System.EventHandler(this.ManagerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.LinkLabel lblComManagement;
        private System.Windows.Forms.LinkLabel lblStuRecommendation;
        private System.Windows.Forms.LinkLabel lblMemAssignment;
        private System.Windows.Forms.LinkLabel lblComDetail;
        private System.Windows.Forms.LinkLabel lblComResult;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}