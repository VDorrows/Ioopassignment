namespace Assignment
{
    partial class frmCompetition
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddComLoad = new System.Windows.Forms.Button();
            this.btnDeleteComLoad = new System.Windows.Forms.Button();
            this.btnEditComLoad = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // btnAddComLoad
            // 
            this.btnAddComLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddComLoad.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComLoad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAddComLoad.Location = new System.Drawing.Point(347, 231);
            this.btnAddComLoad.Name = "btnAddComLoad";
            this.btnAddComLoad.Size = new System.Drawing.Size(312, 75);
            this.btnAddComLoad.TabIndex = 4;
            this.btnAddComLoad.Text = "Add Competition";
            this.btnAddComLoad.UseVisualStyleBackColor = false;
            this.btnAddComLoad.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // btnDeleteComLoad
            // 
            this.btnDeleteComLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteComLoad.Font = new System.Drawing.Font("Arial", 10.125F);
            this.btnDeleteComLoad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDeleteComLoad.Location = new System.Drawing.Point(347, 357);
            this.btnDeleteComLoad.Name = "btnDeleteComLoad";
            this.btnDeleteComLoad.Size = new System.Drawing.Size(312, 75);
            this.btnDeleteComLoad.TabIndex = 5;
            this.btnDeleteComLoad.Text = "Delete Competition";
            this.btnDeleteComLoad.UseVisualStyleBackColor = false;
            this.btnDeleteComLoad.Click += new System.EventHandler(this.btnDeleteCompetition_Click);
            // 
            // btnEditComLoad
            // 
            this.btnEditComLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditComLoad.Font = new System.Drawing.Font("Arial", 10.125F);
            this.btnEditComLoad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEditComLoad.Location = new System.Drawing.Point(347, 483);
            this.btnEditComLoad.Name = "btnEditComLoad";
            this.btnEditComLoad.Size = new System.Drawing.Size(312, 75);
            this.btnEditComLoad.TabIndex = 6;
            this.btnEditComLoad.Text = "Edit Competition";
            this.btnEditComLoad.UseVisualStyleBackColor = false;
            this.btnEditComLoad.Click += new System.EventHandler(this.btnEditCompetiton_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(216, 85);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(589, 67);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "Competiton Management";
            this.lblTitle2.Click += new System.EventHandler(this.lblManagerHome_Click);
            // 
            // frmCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 667);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnEditComLoad);
            this.Controls.Add(this.btnDeleteComLoad);
            this.Controls.Add(this.btnAddComLoad);
            this.Controls.Add(this.label1);
            this.Name = "frmCompetition";
            this.Text = "Competition Management";
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddComLoad;
        private System.Windows.Forms.Button btnDeleteComLoad;
        private System.Windows.Forms.Button btnEditComLoad;
        private System.Windows.Forms.Label lblTitle2;
    }
}