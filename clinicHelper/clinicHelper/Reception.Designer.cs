namespace clinicHelper
{
    partial class Reception
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
            this.btnName = new System.Windows.Forms.TextBox();
            this.rdobtnXRay = new System.Windows.Forms.RadioButton();
            this.rdobtnDoctor = new System.Windows.Forms.RadioButton();
            this.rdobtnAnalyzes = new System.Windows.Forms.RadioButton();
            this.rdobtnEco = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScanner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobtnName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdobtnNumber = new System.Windows.Forms.RadioButton();
            this.Pregnant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smoked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChronicDisease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermanentTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneticDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugAllergy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonTheVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addicted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnName.Location = new System.Drawing.Point(6, 19);
            this.btnName.Multiline = true;
            this.btnName.Name = "btnName";
            this.btnName.ReadOnly = true;
            this.btnName.Size = new System.Drawing.Size(274, 42);
            this.btnName.TabIndex = 20;
            this.btnName.Text = "Name Patient";
            this.btnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdobtnXRay
            // 
            this.rdobtnXRay.AutoSize = true;
            this.rdobtnXRay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnXRay.Location = new System.Drawing.Point(172, 109);
            this.rdobtnXRay.Name = "rdobtnXRay";
            this.rdobtnXRay.Size = new System.Drawing.Size(60, 22);
            this.rdobtnXRay.TabIndex = 19;
            this.rdobtnXRay.TabStop = true;
            this.rdobtnXRay.Text = "XRay";
            this.rdobtnXRay.UseVisualStyleBackColor = true;
            // 
            // rdobtnDoctor
            // 
            this.rdobtnDoctor.AutoSize = true;
            this.rdobtnDoctor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnDoctor.Location = new System.Drawing.Point(172, 76);
            this.rdobtnDoctor.Name = "rdobtnDoctor";
            this.rdobtnDoctor.Size = new System.Drawing.Size(69, 22);
            this.rdobtnDoctor.TabIndex = 18;
            this.rdobtnDoctor.TabStop = true;
            this.rdobtnDoctor.Text = "Doctor";
            this.rdobtnDoctor.UseVisualStyleBackColor = true;
            // 
            // rdobtnAnalyzes
            // 
            this.rdobtnAnalyzes.AutoSize = true;
            this.rdobtnAnalyzes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnAnalyzes.Location = new System.Drawing.Point(6, 81);
            this.rdobtnAnalyzes.Name = "rdobtnAnalyzes";
            this.rdobtnAnalyzes.Size = new System.Drawing.Size(83, 22);
            this.rdobtnAnalyzes.TabIndex = 17;
            this.rdobtnAnalyzes.TabStop = true;
            this.rdobtnAnalyzes.Text = "Analyzes";
            this.rdobtnAnalyzes.UseVisualStyleBackColor = true;
            // 
            // rdobtnEco
            // 
            this.rdobtnEco.AutoSize = true;
            this.rdobtnEco.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnEco.Location = new System.Drawing.Point(6, 109);
            this.rdobtnEco.Name = "rdobtnEco";
            this.rdobtnEco.Size = new System.Drawing.Size(49, 22);
            this.rdobtnEco.TabIndex = 16;
            this.rdobtnEco.TabStop = true;
            this.rdobtnEco.Text = "Eco";
            this.rdobtnEco.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnName);
            this.groupBox2.Controls.Add(this.rdobtnXRay);
            this.groupBox2.Controls.Add(this.rdobtnDoctor);
            this.groupBox2.Controls.Add(this.rdobtnAnalyzes);
            this.groupBox2.Controls.Add(this.btnScanner);
            this.groupBox2.Controls.Add(this.rdobtnEco);
            this.groupBox2.Location = new System.Drawing.Point(366, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 146);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PatientAattachments";
            // 
            // btnScanner
            // 
            this.btnScanner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnScanner.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.Location = new System.Drawing.Point(282, 89);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(114, 42);
            this.btnScanner.TabIndex = 14;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtnName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rdobtnNumber);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 146);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Patient";
            // 
            // rdobtnName
            // 
            this.rdobtnName.AutoSize = true;
            this.rdobtnName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnName.Location = new System.Drawing.Point(6, 76);
            this.rdobtnName.Name = "rdobtnName";
            this.rdobtnName.Size = new System.Drawing.Size(114, 22);
            this.rdobtnName.TabIndex = 17;
            this.rdobtnName.TabStop = true;
            this.rdobtnName.Text = "Name Patient";
            this.rdobtnName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(223, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 42);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 42);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Name Or Number Patient";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdobtnNumber
            // 
            this.rdobtnNumber.AutoSize = true;
            this.rdobtnNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnNumber.Location = new System.Drawing.Point(6, 109);
            this.rdobtnNumber.Name = "rdobtnNumber";
            this.rdobtnNumber.Size = new System.Drawing.Size(78, 22);
            this.rdobtnNumber.TabIndex = 16;
            this.rdobtnNumber.TabStop = true;
            this.rdobtnNumber.Text = "Number";
            this.rdobtnNumber.UseVisualStyleBackColor = true;
            // 
            // Pregnant
            // 
            this.Pregnant.HeaderText = "Pregnant";
            this.Pregnant.Name = "Pregnant";
            // 
            // Smoked
            // 
            this.Smoked.HeaderText = "Smoked";
            this.Smoked.Name = "Smoked";
            // 
            // ChronicDisease
            // 
            this.ChronicDisease.HeaderText = "ChronicDisease";
            this.ChronicDisease.Name = "ChronicDisease";
            // 
            // PermanentTreatment
            // 
            this.PermanentTreatment.HeaderText = "PermanentTreatment";
            this.PermanentTreatment.Name = "PermanentTreatment";
            // 
            // GeneticDiseases
            // 
            this.GeneticDiseases.HeaderText = "GeneticDiseases";
            this.GeneticDiseases.Name = "GeneticDiseases";
            // 
            // DrugAllergy
            // 
            this.DrugAllergy.HeaderText = "DrugAllergy";
            this.DrugAllergy.Name = "DrugAllergy";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // ReasonTheVisit
            // 
            this.ReasonTheVisit.HeaderText = "ReasonTheVisit";
            this.ReasonTheVisit.Name = "ReasonTheVisit";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Addicted
            // 
            this.Addicted.HeaderText = "Addicted";
            this.Addicted.Name = "Addicted";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ReasonTheVisit,
            this.Time,
            this.DrugAllergy,
            this.GeneticDiseases,
            this.PermanentTreatment,
            this.ChronicDisease,
            this.Smoked,
            this.Addicted,
            this.Pregnant});
            this.dataGridView1.Location = new System.Drawing.Point(4, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 326);
            this.dataGridView1.TabIndex = 20;
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reception";
            this.Text = "Reception";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox btnName;
        private System.Windows.Forms.RadioButton rdobtnXRay;
        private System.Windows.Forms.RadioButton rdobtnDoctor;
        private System.Windows.Forms.RadioButton rdobtnAnalyzes;
        private System.Windows.Forms.RadioButton rdobtnEco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdobtnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregnant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smoked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChronicDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermanentTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneticDiseases;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugAllergy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonTheVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addicted;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}