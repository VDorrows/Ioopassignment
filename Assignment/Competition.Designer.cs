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
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.btnEditCompetiton = new System.Windows.Forms.Button();
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
            // btnAddCompetition
            // 
            this.btnAddCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompetition.Location = new System.Drawing.Point(185, 170);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(335, 75);
            this.btnAddCompetition.TabIndex = 4;
            this.btnAddCompetition.Text = "Add Competition";
            this.btnAddCompetition.UseVisualStyleBackColor = true;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetition.Location = new System.Drawing.Point(185, 277);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(335, 75);
            this.btnDeleteCompetition.TabIndex = 5;
            this.btnDeleteCompetition.Text = "Delete Competition";
            this.btnDeleteCompetition.UseVisualStyleBackColor = true;
            this.btnDeleteCompetition.Click += new System.EventHandler(this.btnDeleteCompetition_Click);
            // 
            // btnEditCompetiton
            // 
            this.btnEditCompetiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompetiton.Location = new System.Drawing.Point(185, 389);
            this.btnEditCompetiton.Name = "btnEditCompetiton";
            this.btnEditCompetiton.Size = new System.Drawing.Size(335, 75);
            this.btnEditCompetiton.TabIndex = 6;
            this.btnEditCompetiton.Text = "Edit Competition";
            this.btnEditCompetiton.UseVisualStyleBackColor = true;
            this.btnEditCompetiton.Click += new System.EventHandler(this.btnEditCompetiton_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(178, 76);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(468, 42);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "Competiton Management:";
            this.lblTitle2.Click += new System.EventHandler(this.lblManagerHome_Click);
            // 
            // frmCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 575);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnEditCompetiton);
            this.Controls.Add(this.btnDeleteCompetition);
            this.Controls.Add(this.btnAddCompetition);
            this.Controls.Add(this.label1);
            this.Name = "frmCompetition";
            this.Text = "Competition Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.Button btnEditCompetiton;
        private System.Windows.Forms.Label lblTitle2;
    }
}