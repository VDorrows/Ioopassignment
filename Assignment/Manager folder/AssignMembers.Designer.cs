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
            this.listboxCom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxMem = new System.Windows.Forms.ListBox();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxCom
            // 
            this.listboxCom.FormattingEnabled = true;
            this.listboxCom.ItemHeight = 25;
            this.listboxCom.Items.AddRange(new object[] {
            " "});
            this.listboxCom.Location = new System.Drawing.Point(568, 174);
            this.listboxCom.Name = "listboxCom";
            this.listboxCom.Size = new System.Drawing.Size(376, 404);
            this.listboxCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Competition:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Member:";
            // 
            // listboxMem
            // 
            this.listboxMem.FormattingEnabled = true;
            this.listboxMem.ItemHeight = 25;
            this.listboxMem.Items.AddRange(new object[] {
            " "});
            this.listboxMem.Location = new System.Drawing.Point(109, 174);
            this.listboxMem.Name = "listboxMem";
            this.listboxMem.Size = new System.Drawing.Size(376, 404);
            this.listboxMem.TabIndex = 7;
            // 
            // btnAddCom
            // 
            this.btnAddCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCom.Location = new System.Drawing.Point(731, 645);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(213, 75);
            this.btnAddCom.TabIndex = 18;
            this.btnAddCom.Text = "Assign";
            this.btnAddCom.UseVisualStyleBackColor = true;
            // 
            // frmMberAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 776);
            this.Controls.Add(this.btnAddCom);
            this.Controls.Add(this.listboxMem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxCom);
            this.Name = "frmMberAssign";
            this.Text = "Assign Members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxMem;
        private System.Windows.Forms.Button btnAddCom;
    }
}