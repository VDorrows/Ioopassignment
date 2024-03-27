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
            this.label1 = new System.Windows.Forms.Label();
            this.boxCompetition = new System.Windows.Forms.ComboBox();
            this.txtComDescription = new System.Windows.Forms.TextBox();
            this.txtComLocation = new System.Windows.Forms.TextBox();
            this.txtComDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditCom
            // 
            this.btnEditCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCom.Location = new System.Drawing.Point(529, 453);
            this.btnEditCom.Name = "btnEditCom";
            this.btnEditCom.Size = new System.Drawing.Size(213, 75);
            this.btnEditCom.TabIndex = 32;
            this.btnEditCom.Text = "Edit";
            this.btnEditCom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select :";
            // 
            // boxCompetition
            // 
            this.boxCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCompetition.FormattingEnabled = true;
            this.boxCompetition.Location = new System.Drawing.Point(224, 71);
            this.boxCompetition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxCompetition.Name = "boxCompetition";
            this.boxCompetition.Size = new System.Drawing.Size(517, 45);
            this.boxCompetition.TabIndex = 30;
            // 
            // txtComDescription
            // 
            this.txtComDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDescription.Location = new System.Drawing.Point(346, 314);
            this.txtComDescription.Name = "txtComDescription";
            this.txtComDescription.Size = new System.Drawing.Size(396, 44);
            this.txtComDescription.TabIndex = 38;
            // 
            // txtComLocation
            // 
            this.txtComLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComLocation.Location = new System.Drawing.Point(346, 238);
            this.txtComLocation.Name = "txtComLocation";
            this.txtComLocation.Size = new System.Drawing.Size(396, 44);
            this.txtComLocation.TabIndex = 37;
            // 
            // txtComDate
            // 
            this.txtComDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComDate.Location = new System.Drawing.Point(346, 169);
            this.txtComDate.Name = "txtComDate";
            this.txtComDate.Size = new System.Drawing.Size(396, 44);
            this.txtComDate.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 34;
            this.label3.Text = "Location :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date :";
            // 
            // frmComEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 610);
            this.Controls.Add(this.txtComDescription);
            this.Controls.Add(this.txtComLocation);
            this.Controls.Add(this.txtComDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCompetition);
            this.Name = "frmComEdit";
            this.Text = "Edit Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxCompetition;
        private System.Windows.Forms.TextBox txtComDescription;
        private System.Windows.Forms.TextBox txtComLocation;
        private System.Windows.Forms.TextBox txtComDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}