﻿namespace Assignment
{
    partial class frmComDel
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
            this.boxCompetition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxCompetition
            // 
            this.boxCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCompetition.FormattingEnabled = true;
            this.boxCompetition.Location = new System.Drawing.Point(185, 68);
            this.boxCompetition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxCompetition.Name = "boxCompetition";
            this.boxCompetition.Size = new System.Drawing.Size(517, 45);
            this.boxCompetition.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select :";
            // 
            // btnDeleteCom
            // 
            this.btnDeleteCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCom.Location = new System.Drawing.Point(489, 248);
            this.btnDeleteCom.Name = "btnDeleteCom";
            this.btnDeleteCom.Size = new System.Drawing.Size(213, 75);
            this.btnDeleteCom.TabIndex = 29;
            this.btnDeleteCom.Text = "Delete";
            this.btnDeleteCom.UseVisualStyleBackColor = true;
            // 
            // frmComDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 422);
            this.Controls.Add(this.btnDeleteCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCompetition);
            this.Name = "frmComDel";
            this.Text = "Delete Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxCompetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCom;
    }
}