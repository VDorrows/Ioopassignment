namespace Assignment
{
    partial class frmViewMemList
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
            this.btnViewList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxComSelect = new System.Windows.Forms.ComboBox();
            this.lstMemView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewList.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.Location = new System.Drawing.Point(489, 705);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(213, 75);
            this.btnViewList.TabIndex = 32;
            this.btnViewList.Text = "View";
            this.btnViewList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Competition :";
            // 
            // boxComSelect
            // 
            this.boxComSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxComSelect.FormattingEnabled = true;
            this.boxComSelect.Location = new System.Drawing.Point(77, 155);
            this.boxComSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxComSelect.Name = "boxComSelect";
            this.boxComSelect.Size = new System.Drawing.Size(625, 45);
            this.boxComSelect.TabIndex = 30;
            // 
            // lstMemView
            // 
            this.lstMemView.FormattingEnabled = true;
            this.lstMemView.ItemHeight = 25;
            this.lstMemView.Items.AddRange(new object[] {
            " "});
            this.lstMemView.Location = new System.Drawing.Point(77, 252);
            this.lstMemView.Name = "lstMemView";
            this.lstMemView.Size = new System.Drawing.Size(625, 354);
            this.lstMemView.TabIndex = 33;
            // 
            // frmViewMemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 862);
            this.Controls.Add(this.lstMemView);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxComSelect);
            this.Name = "frmViewMemList";
            this.Text = "View Member List";
            this.Load += new System.EventHandler(this.ViewMemberList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxComSelect;
        private System.Windows.Forms.ListBox lstMemView;
    }
}