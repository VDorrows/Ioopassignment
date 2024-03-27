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
            this.label1 = new System.Windows.Forms.Label();
            this.boxCompetition = new System.Windows.Forms.ComboBox();
            this.txtComRDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select Competition :";
            // 
            // boxCompetition
            // 
            this.boxCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCompetition.FormattingEnabled = true;
            this.boxCompetition.Location = new System.Drawing.Point(126, 116);
            this.boxCompetition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxCompetition.Name = "boxCompetition";
            this.boxCompetition.Size = new System.Drawing.Size(570, 45);
            this.boxCompetition.TabIndex = 29;
            // 
            // txtComRDate
            // 
            this.txtComRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComRDate.Location = new System.Drawing.Point(300, 204);
            this.txtComRDate.Name = "txtComRDate";
            this.txtComRDate.Size = new System.Drawing.Size(396, 44);
            this.txtComRDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date :";
            // 
            // txtComResult
            // 
            this.txtComResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComResult.Location = new System.Drawing.Point(300, 268);
            this.txtComResult.Name = "txtComResult";
            this.txtComResult.Size = new System.Drawing.Size(396, 44);
            this.txtComResult.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 39;
            this.label3.Text = "Result :";
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(483, 375);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(213, 75);
            this.btnRecord.TabIndex = 41;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // frmComResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 584);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtComResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComRDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCompetition);
            this.Name = "frmComResult";
            this.Text = "Competition Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxCompetition;
        private System.Windows.Forms.TextBox txtComRDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecord;
    }
}