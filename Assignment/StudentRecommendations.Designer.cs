﻿namespace Assignment
{
    partial class frmStudentRE
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
            this.listStuRecommend = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStuRecommend
            // 
            this.listStuRecommend.HideSelection = false;
            this.listStuRecommend.Location = new System.Drawing.Point(108, 172);
            this.listStuRecommend.Name = "listStuRecommend";
            this.listStuRecommend.Size = new System.Drawing.Size(803, 421);
            this.listStuRecommend.TabIndex = 0;
            this.listStuRecommend.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recommendation for competition :";
            // 
            // frmStudentRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStuRecommend);
            this.Name = "frmStudentRE";
            this.Text = "Student Recommendations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStuRecommend;
        private System.Windows.Forms.Label label1;
    }
}