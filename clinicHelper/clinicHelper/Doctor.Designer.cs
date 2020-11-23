namespace clinicHelper
{
    partial class Doctor
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnBackups = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClinicStaff
            // 
            this.btnClinicStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicStaff.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicStaff.Location = new System.Drawing.Point(608, 277);
            this.btnClinicStaff.Name = "btnClinicStaff";
            this.btnClinicStaff.Size = new System.Drawing.Size(169, 55);
            this.btnClinicStaff.TabIndex = 9;
            this.btnClinicStaff.Text = "Clinic Staff";
            this.btnClinicStaff.UseVisualStyleBackColor = false;
            this.btnClinicStaff.Click += new System.EventHandler(this.btnClinicStaff_Click);
            // 
            // btnRevenuesExpenses
            // 
            this.btnRevenuesExpenses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRevenuesExpenses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenuesExpenses.Location = new System.Drawing.Point(334, 277);
            this.btnRevenuesExpenses.Name = "btnRevenuesExpenses";
            this.btnRevenuesExpenses.Size = new System.Drawing.Size(181, 55);
            this.btnRevenuesExpenses.TabIndex = 8;
            this.btnRevenuesExpenses.Text = "Revenues and Expenses";
            this.btnRevenuesExpenses.UseVisualStyleBackColor = false;
            this.btnRevenuesExpenses.Click += new System.EventHandler(this.btnRevenuesExpenses_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatient.Font = new System.Drawing.Font("Akhbar MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPatient.Location = new System.Drawing.Point(77, 277);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(169, 55);
            this.btnPatient.TabIndex = 7;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnBackups
            // 
            this.btnBackups.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackups.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackups.Location = new System.Drawing.Point(204, 393);
            this.btnBackups.Name = "btnBackups";
            this.btnBackups.Size = new System.Drawing.Size(169, 55);
            this.btnBackups.TabIndex = 6;
            this.btnBackups.Text = "Backups";
            this.btnBackups.UseVisualStyleBackColor = false;
            this.btnBackups.Click += new System.EventHandler(this.btnBackups_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(496, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 55);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clinicHelper.Properties.Resources.طبيبة;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 482);
            this.Controls.Add(this.btnClinicStaff);
            this.Controls.Add(this.btnRevenuesExpenses);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnBackups);
            this.Controls.Add(this.btnClose);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClinicStaff;
        private System.Windows.Forms.Button btnRevenuesExpenses;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnBackups;
        private System.Windows.Forms.Button btnClose;

    }
}