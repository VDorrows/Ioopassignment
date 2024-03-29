namespace Assignment
{
    partial class frmProfUpdate
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Updating = new System.Windows.Forms.Button();
            this.NewTBox = new System.Windows.Forms.TextBox();
            this.CNewTBox = new System.Windows.Forms.TextBox();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(286, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(108, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(108, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm password";
            // 
            // Updating
            // 
            this.Updating.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Updating.Font = new System.Drawing.Font("Arial", 10.125F);
            this.Updating.Location = new System.Drawing.Point(504, 581);
            this.Updating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Updating.Name = "Updating";
            this.Updating.Size = new System.Drawing.Size(290, 72);
            this.Updating.TabIndex = 4;
            this.Updating.Text = "Update";
            this.Updating.UseVisualStyleBackColor = false;
            this.Updating.Click += new System.EventHandler(this.Updating_Click);
            // 
            // NewTBox
            // 
            this.NewTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTBox.Location = new System.Drawing.Point(502, 364);
            this.NewTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewTBox.Name = "NewTBox";
            this.NewTBox.Size = new System.Drawing.Size(292, 44);
            this.NewTBox.TabIndex = 6;
            // 
            // CNewTBox
            // 
            this.CNewTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNewTBox.Location = new System.Drawing.Point(502, 469);
            this.CNewTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CNewTBox.Name = "CNewTBox";
            this.CNewTBox.Size = new System.Drawing.Size(292, 44);
            this.CNewTBox.TabIndex = 7;
            this.CNewTBox.TextChanged += new System.EventHandler(this.CNewTBox_TextChanged);
            // 
            // NameTBox
            // 
            this.NameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTBox.Location = new System.Drawing.Point(502, 263);
            this.NameTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(292, 44);
            this.NameTBox.TabIndex = 9;
            this.NameTBox.TextChanged += new System.EventHandler(this.NameTBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(108, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // frmProfUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 781);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CNewTBox);
            this.Controls.Add(this.NewTBox);
            this.Controls.Add(this.Updating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProfUpdate";
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.ProfUpdateManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Updating;
        private System.Windows.Forms.TextBox NewTBox;
        private System.Windows.Forms.TextBox CNewTBox;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.Label label2;
    }
}