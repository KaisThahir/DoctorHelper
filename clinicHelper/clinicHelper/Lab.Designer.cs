namespace clinicHelper
{
    partial class Lab
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
            this.buttontest = new System.Windows.Forms.Button();
            this.buttontest2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttontest
            // 
            this.buttontest.Location = new System.Drawing.Point(24, 24);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(75, 23);
            this.buttontest.TabIndex = 0;
            this.buttontest.Text = "button1";
            this.buttontest.UseVisualStyleBackColor = true;
            this.buttontest.Click += new System.EventHandler(this.buttontest_Click);
            // 
            // buttontest2
            // 
            this.buttontest2.Location = new System.Drawing.Point(24, 54);
            this.buttontest2.Name = "buttontest2";
            this.buttontest2.Size = new System.Drawing.Size(75, 23);
            this.buttontest2.TabIndex = 1;
            this.buttontest2.Text = "button1";
            this.buttontest2.UseVisualStyleBackColor = true;
            this.buttontest2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 321);
            this.Controls.Add(this.buttontest2);
            this.Controls.Add(this.buttontest);
            this.Name = "Lab";
            this.Text = "Lab";
            this.Load += new System.EventHandler(this.Lab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.Button buttontest2;
    }
}