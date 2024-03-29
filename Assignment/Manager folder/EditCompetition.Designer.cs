using System;

namespace Assignment
{
    partial class frmComEdit
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
            this.btnEditCom = new System.Windows.Forms.Button();
            this.txtComDescription = new System.Windows.Forms.TextBox();
            this.txtComLocation = new System.Windows.Forms.TextBox();
            this.txtComDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listboxComSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEditCom
            // 
            this.btnEditCom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditCom.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCom.Location = new System.Drawing.Point(567, 461);
            this.btnEditCom.Name = "btnEditCom";
            this.btnEditCom.Size = new System.Drawing.Size(213, 75);
            this.btnEditCom.TabIndex = 32;
            this.btnEditCom.Text = "Edit";
            this.btnEditCom.UseVisualStyleBackColor = false;
            this.btnEditCom.Click += new System.EventHandler(this.btnEditCom_Click);
            // 
            // txtComDescription
            // 
            this.txtComDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDescription.Location = new System.Drawing.Point(384, 362);
            this.txtComDescription.Name = "txtComDescription";
            this.txtComDescription.Size = new System.Drawing.Size(396, 44);
            this.txtComDescription.TabIndex = 38;
            // 
            // txtComLocation
            // 
            this.txtComLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComLocation.Location = new System.Drawing.Point(384, 290);
            this.txtComLocation.Name = "txtComLocation";
            this.txtComLocation.Size = new System.Drawing.Size(396, 44);
            this.txtComLocation.TabIndex = 37;
            // 
            // txtComDate
            // 
            this.txtComDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDate.Location = new System.Drawing.Point(384, 221);
            this.txtComDate.Name = "txtComDate";
            this.txtComDate.Size = new System.Drawing.Size(396, 44);
            this.txtComDate.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(128, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(128, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 45);
            this.label3.TabIndex = 34;
            this.label3.Text = "Location :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(128, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(119, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 45);
            this.label5.TabIndex = 40;
            this.label5.Text = "Select Competition :";
            // 
            // listboxComSelect
            // 
            this.listboxComSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxComSelect.FormattingEnabled = true;
            this.listboxComSelect.Location = new System.Drawing.Point(127, 115);
            this.listboxComSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listboxComSelect.Name = "listboxComSelect";
            this.listboxComSelect.Size = new System.Drawing.Size(653, 45);
            this.listboxComSelect.TabIndex = 39;
            this.listboxComSelect.SelectedIndexChanged += new System.EventHandler(this.listboxComSelect_SelectedIndexChanged);
            // 
            // frmComEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 714);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listboxComSelect);
            this.Controls.Add(this.txtComDescription);
            this.Controls.Add(this.txtComLocation);
            this.Controls.Add(this.txtComDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditCom);
            this.Name = "frmComEdit";
            this.Text = "Edit Competition";
            this.Load += new System.EventHandler(this.frmComEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmComEdit_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnEditCom;
        private System.Windows.Forms.TextBox txtComDescription;
        private System.Windows.Forms.TextBox txtComLocation;
        private System.Windows.Forms.TextBox txtComDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listboxComSelect;
    }
}