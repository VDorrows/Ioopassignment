﻿namespace Assignment
{
    partial class frmComAdd
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
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.txtComDate = new System.Windows.Forms.TextBox();
            this.txtComLocation = new System.Windows.Forms.TextBox();
            this.txtComDescription = new System.Windows.Forms.TextBox();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.Location = new System.Drawing.Point(126, 68);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(216, 51);
            this.lblTitle3.TabIndex = 8;
            this.lblTitle3.Text = "Competiton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(127, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(127, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(127, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(127, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description :";
            // 
            // txtComName
            // 
            this.txtComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComName.Location = new System.Drawing.Point(383, 156);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(396, 44);
            this.txtComName.TabIndex = 13;
            // 
            // txtComDate
            // 
            this.txtComDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDate.Location = new System.Drawing.Point(383, 234);
            this.txtComDate.Name = "txtComDate";
            this.txtComDate.Size = new System.Drawing.Size(396, 44);
            this.txtComDate.TabIndex = 14;
            // 
            // txtComLocation
            // 
            this.txtComLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComLocation.Location = new System.Drawing.Point(383, 303);
            this.txtComLocation.Name = "txtComLocation";
            this.txtComLocation.Size = new System.Drawing.Size(396, 44);
            this.txtComLocation.TabIndex = 15;
            // 
            // txtComDescription
            // 
            this.txtComDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDescription.Location = new System.Drawing.Point(383, 379);
            this.txtComDescription.Name = "txtComDescription";
            this.txtComDescription.Size = new System.Drawing.Size(396, 44);
            this.txtComDescription.TabIndex = 16;
            // 
            // btnAddCom
            // 
            this.btnAddCom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCom.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCom.Location = new System.Drawing.Point(566, 494);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(213, 75);
            this.btnAddCom.TabIndex = 17;
            this.btnAddCom.Text = "Add";
            this.btnAddCom.UseVisualStyleBackColor = false;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // frmComAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 638);
            this.Controls.Add(this.btnAddCom);
            this.Controls.Add(this.txtComDescription);
            this.Controls.Add(this.txtComLocation);
            this.Controls.Add(this.txtComDate);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle3);
            this.Name = "frmComAdd";
            this.Text = "Add Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox txtComDate;
        private System.Windows.Forms.TextBox txtComLocation;
        private System.Windows.Forms.TextBox txtComDescription;
        private System.Windows.Forms.Button btnAddCom;
    }
}