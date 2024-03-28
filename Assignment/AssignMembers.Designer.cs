namespace Assignment
{
    partial class frmMberAssign
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssignMem = new System.Windows.Forms.Button();
            this.boxComSelect = new System.Windows.Forms.ComboBox();
            this.boxMemSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F);
            this.label1.Location = new System.Drawing.Point(102, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Competition:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F);
            this.label2.Location = new System.Drawing.Point(102, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Member:";
            // 
            // btnAssignMem
            // 
            this.btnAssignMem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssignMem.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignMem.Location = new System.Drawing.Point(523, 479);
            this.btnAssignMem.Name = "btnAssignMem";
            this.btnAssignMem.Size = new System.Drawing.Size(213, 75);
            this.btnAssignMem.TabIndex = 18;
            this.btnAssignMem.Text = "Assign";
            this.btnAssignMem.UseVisualStyleBackColor = false;
            // 
            // boxComSelect
            // 
            this.boxComSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxComSelect.FormattingEnabled = true;
            this.boxComSelect.Location = new System.Drawing.Point(111, 332);
            this.boxComSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxComSelect.Name = "boxComSelect";
            this.boxComSelect.Size = new System.Drawing.Size(625, 45);
            this.boxComSelect.TabIndex = 28;
            // 
            // boxMemSelect
            // 
            this.boxMemSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMemSelect.FormattingEnabled = true;
            this.boxMemSelect.Location = new System.Drawing.Point(111, 162);
            this.boxMemSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxMemSelect.Name = "boxMemSelect";
            this.boxMemSelect.Size = new System.Drawing.Size(625, 45);
            this.boxMemSelect.TabIndex = 29;
            // 
            // frmMberAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 690);
            this.Controls.Add(this.boxMemSelect);
            this.Controls.Add(this.boxComSelect);
            this.Controls.Add(this.btnAssignMem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMberAssign";
            this.Text = "Assign Members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssignMem;
        private System.Windows.Forms.ComboBox boxComSelect;
        private System.Windows.Forms.ComboBox boxMemSelect;
    }
}