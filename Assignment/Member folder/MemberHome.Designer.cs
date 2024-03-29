namespace hehehe
{
    partial class MemberHome
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
            this.lblemail = new System.Windows.Forms.Label();
            this.enroll_unenroll = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Button();
            this.competition = new System.Windows.Forms.Button();
            this.suggestion = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(12, 27);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(79, 29);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "label1";
            this.lblemail.Click += new System.EventHandler(this.id_Click);
            // 
            // enroll_unenroll
            // 
            this.enroll_unenroll.Location = new System.Drawing.Point(110, 147);
            this.enroll_unenroll.Name = "enroll_unenroll";
            this.enroll_unenroll.Size = new System.Drawing.Size(166, 62);
            this.enroll_unenroll.TabIndex = 2;
            this.enroll_unenroll.Text = "enroll  unenroll";
            this.enroll_unenroll.UseVisualStyleBackColor = true;
            this.enroll_unenroll.Click += new System.EventHandler(this.enroll_unenroll_Click);
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(110, 248);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(166, 62);
            this.schedule.TabIndex = 3;
            this.schedule.Text = "training scedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // performance
            // 
            this.performance.Location = new System.Drawing.Point(110, 350);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(166, 62);
            this.performance.TabIndex = 4;
            this.performance.Text = "performance record";
            this.performance.UseVisualStyleBackColor = true;
            // 
            // competition
            // 
            this.competition.Location = new System.Drawing.Point(417, 147);
            this.competition.Name = "competition";
            this.competition.Size = new System.Drawing.Size(166, 62);
            this.competition.TabIndex = 5;
            this.competition.Text = "competition";
            this.competition.UseVisualStyleBackColor = true;
            // 
            // suggestion
            // 
            this.suggestion.Location = new System.Drawing.Point(417, 248);
            this.suggestion.Name = "suggestion";
            this.suggestion.Size = new System.Drawing.Size(166, 62);
            this.suggestion.TabIndex = 6;
            this.suggestion.Text = "send suggestion";
            this.suggestion.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(417, 350);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(166, 62);
            this.update.TabIndex = 7;
            this.update.Text = "update profile";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // MemberHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.update);
            this.Controls.Add(this.suggestion);
            this.Controls.Add(this.competition);
            this.Controls.Add(this.performance);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.enroll_unenroll);
            this.Controls.Add(this.lblemail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "MemberHome";
            this.Text = "profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button enroll_unenroll;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button performance;
        private System.Windows.Forms.Button competition;
        private System.Windows.Forms.Button suggestion;
        private System.Windows.Forms.Button update;
    }
}

