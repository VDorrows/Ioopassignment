namespace Assignment
{
    partial class AdminHome
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
            this.lblidentity = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Homepage";
            // 
            // lblidentity
            // 
            this.lblidentity.AutoSize = true;
            this.lblidentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentity.Location = new System.Drawing.Point(311, 95);
            this.lblidentity.Name = "lblidentity";
            this.lblidentity.Size = new System.Drawing.Size(0, 25);
            this.lblidentity.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(284, 151);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(200, 58);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add user";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "View User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblidentity);
            this.Controls.Add(this.label1);
            this.Name = "AdminHome";
            this.Text = "Admin_Home";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidentity;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}