namespace Assignment
{
    partial class frmComResult
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
            this.txtComResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.boxComSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtComResult
            // 
            this.txtComResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComResult.Location = new System.Drawing.Point(336, 245);
            this.txtComResult.Name = "txtComResult";
            this.txtComResult.Size = new System.Drawing.Size(396, 44);
            this.txtComResult.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(71, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 45);
            this.label3.TabIndex = 39;
            this.label3.Text = "Insert Result :";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecord.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(519, 411);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(213, 75);
            this.btnRecord.TabIndex = 41;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(71, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 45);
            this.label5.TabIndex = 43;
            this.label5.Text = "Select Competition :";
            // 
            // boxComSelect
            // 
            this.boxComSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxComSelect.FormattingEnabled = true;
            this.boxComSelect.Location = new System.Drawing.Point(79, 135);
            this.boxComSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxComSelect.Name = "boxComSelect";
            this.boxComSelect.Size = new System.Drawing.Size(653, 45);
            this.boxComSelect.TabIndex = 42;
            // 
            // frmComResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxComSelect);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtComResult);
            this.Controls.Add(this.label3);
            this.Name = "frmComResult";
            this.Text = "Competition Results";
            this.Load += new System.EventHandler(this.frmComResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtComResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxComSelect;
    }
}