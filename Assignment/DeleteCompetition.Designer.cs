namespace Assignment
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
            this.boxComSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxComSelect
            // 
            this.boxComSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxComSelect.FormattingEnabled = true;
            this.boxComSelect.Location = new System.Drawing.Point(95, 129);
            this.boxComSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxComSelect.Name = "boxComSelect";
            this.boxComSelect.Size = new System.Drawing.Size(625, 45);
            this.boxComSelect.TabIndex = 27;
            this.boxComSelect.SelectedIndexChanged += new System.EventHandler(this.boxComSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Competition :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteCom
            // 
            this.btnDeleteCom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteCom.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCom.Location = new System.Drawing.Point(507, 250);
            this.btnDeleteCom.Name = "btnDeleteCom";
            this.btnDeleteCom.Size = new System.Drawing.Size(213, 75);
            this.btnDeleteCom.TabIndex = 29;
            this.btnDeleteCom.Text = "Delete";
            this.btnDeleteCom.UseVisualStyleBackColor = false;
            this.btnDeleteCom.Click += new System.EventHandler(this.btnDeleteCom_Click);
            // 
            // frmComDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.btnDeleteCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxComSelect);
            this.Name = "frmComDel";
            this.Text = "Delete Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxComSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCom;
    }
}