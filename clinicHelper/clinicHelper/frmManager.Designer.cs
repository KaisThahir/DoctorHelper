namespace clinicHelper
{
    partial class frmManager
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
            this.btnClinicStaff = new System.Windows.Forms.Button();
            this.btnRevenuesExpenses = new System.Windows.Forms.Button();
            this.btnBackups = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClinicStaff
            // 
            this.btnClinicStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClinicStaff.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicStaff.Location = new System.Drawing.Point(613, 158);
            this.btnClinicStaff.Name = "btnClinicStaff";
            this.btnClinicStaff.Size = new System.Drawing.Size(169, 55);
            this.btnClinicStaff.TabIndex = 13;
            this.btnClinicStaff.Text = "Clinic Staff";
            this.btnClinicStaff.UseVisualStyleBackColor = false;
            this.btnClinicStaff.Click += new System.EventHandler(this.btnClinicStaff_Click);
            // 
            // btnRevenuesExpenses
            // 
            this.btnRevenuesExpenses.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRevenuesExpenses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenuesExpenses.Location = new System.Drawing.Point(472, 40);
            this.btnRevenuesExpenses.Name = "btnRevenuesExpenses";
            this.btnRevenuesExpenses.Size = new System.Drawing.Size(181, 55);
            this.btnRevenuesExpenses.TabIndex = 12;
            this.btnRevenuesExpenses.Text = "Revenues and Expenses";
            this.btnRevenuesExpenses.UseVisualStyleBackColor = false;
            this.btnRevenuesExpenses.Click += new System.EventHandler(this.btnRevenuesExpenses_Click);
            // 
            // btnBackups
            // 
            this.btnBackups.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackups.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackups.Location = new System.Drawing.Point(472, 269);
            this.btnBackups.Name = "btnBackups";
            this.btnBackups.Size = new System.Drawing.Size(181, 55);
            this.btnBackups.TabIndex = 11;
            this.btnBackups.Text = "Backups";
            this.btnBackups.UseVisualStyleBackColor = false;
            this.btnBackups.Click += new System.EventHandler(this.btnBackups_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(613, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 55);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicHelper.Properties.Resources.مدير;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 490);
            this.Controls.Add(this.btnClinicStaff);
            this.Controls.Add(this.btnRevenuesExpenses);
            this.Controls.Add(this.btnBackups);
            this.Controls.Add(this.btnClose);
            this.Name = "frmManager";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClinicStaff;
        private System.Windows.Forms.Button btnRevenuesExpenses;
        private System.Windows.Forms.Button btnBackups;
        private System.Windows.Forms.Button btnClose;
    }
}