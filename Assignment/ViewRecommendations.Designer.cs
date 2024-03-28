namespace Assignment
{
    partial class frmViewCommend
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
            this.lstViewCommend = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstViewCommend
            // 
            this.lstViewCommend.HideSelection = false;
            this.lstViewCommend.Location = new System.Drawing.Point(145, 182);
            this.lstViewCommend.Name = "lstViewCommend";
            this.lstViewCommend.Size = new System.Drawing.Size(564, 317);
            this.lstViewCommend.TabIndex = 0;
            this.lstViewCommend.UseCompatibleStateImageBehavior = false;
            this.lstViewCommend.SelectedIndexChanged += new System.EventHandler(this.lstViewCommend_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = " View Member Recommendations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmViewCommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewCommend);
            this.Name = "frmViewCommend";
            this.Text = "View Recommendation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewCommend;
        private System.Windows.Forms.Label label1;
    }
}