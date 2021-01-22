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
            this.tabPatient = new System.Windows.Forms.TabControl();
            this.tabPatientWait = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ReasonTheVisit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Time = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPatientVisetes = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Drug = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Date = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPatientData = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabAnalyzes = new System.Windows.Forms.TabPage();
            this.tabXRay = new System.Windows.Forms.TabPage();
            this.tabEco = new System.Windows.Forms.TabPage();
            this.tabFromDoctor = new System.Windows.Forms.TabPage();
            this.btnTransformation = new System.Windows.Forms.Button();
            this.labDrog = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tboxClinicDiagnosis = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.ClinicDiagnosis = new System.Windows.Forms.Label();
            this.NameDrog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoseAmont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomberDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDrog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPatient.SuspendLayout();
            this.tabPatientWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPatientVisetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.tabPatientWait);
            this.tabPatient.Controls.Add(this.tabPatientVisetes);
            this.tabPatient.Controls.Add(this.tabPatientData);
            this.tabPatient.Location = new System.Drawing.Point(0, 1);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.SelectedIndex = 0;
            this.tabPatient.Size = new System.Drawing.Size(399, 276);
            this.tabPatient.TabIndex = 18;
            // 
            // tabPatientWait
            // 
            this.tabPatientWait.Controls.Add(this.dataGridView1);
            this.tabPatientWait.Location = new System.Drawing.Point(4, 22);
            this.tabPatientWait.Name = "tabPatientWait";
            this.tabPatientWait.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientWait.Size = new System.Drawing.Size(391, 250);
            this.tabPatientWait.TabIndex = 0;
            this.tabPatientWait.Text = "Patient Wait";
            this.tabPatientWait.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ReasonTheVisit,
            this.Time});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReasonTheVisit
            // 
            this.ReasonTheVisit.HeaderText = "Reason The Visit";
            this.ReasonTheVisit.Name = "ReasonTheVisit";
            this.ReasonTheVisit.ReadOnly = true;
            this.ReasonTheVisit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReasonTheVisit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPatientVisetes
            // 
            this.tabPatientVisetes.Controls.Add(this.dataGridView2);
            this.tabPatientVisetes.Location = new System.Drawing.Point(4, 22);
            this.tabPatientVisetes.Name = "tabPatientVisetes";
            this.tabPatientVisetes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientVisetes.Size = new System.Drawing.Size(391, 250);
            this.tabPatientVisetes.TabIndex = 1;
            this.tabPatientVisetes.Text = "Patient Visetes";
            this.tabPatientVisetes.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drug,
            this.Diagnosis,
            this.Date});
            this.dataGridView2.Location = new System.Drawing.Point(2, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(386, 249);
            this.dataGridView2.TabIndex = 0;
            // 
            // Drug
            // 
            this.Drug.HeaderText = "Drug";
            this.Drug.Name = "Drug";
            this.Drug.ReadOnly = true;
            this.Drug.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Drug.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Diagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPatientData
            // 
            this.tabPatientData.Location = new System.Drawing.Point(4, 22);
            this.tabPatientData.Name = "tabPatientData";
            this.tabPatientData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientData.Size = new System.Drawing.Size(391, 250);
            this.tabPatientData.TabIndex = 2;
            this.tabPatientData.Text = "Patient Data";
            this.tabPatientData.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabAnalyzes);
            this.tabControl2.Controls.Add(this.tabXRay);
            this.tabControl2.Controls.Add(this.tabEco);
            this.tabControl2.Controls.Add(this.tabFromDoctor);
            this.tabControl2.Location = new System.Drawing.Point(0, 281);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(397, 212);
            this.tabControl2.TabIndex = 19;
            // 
            // tabAnalyzes
            // 
            this.tabAnalyzes.Location = new System.Drawing.Point(4, 22);
            this.tabAnalyzes.Name = "tabAnalyzes";
            this.tabAnalyzes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalyzes.Size = new System.Drawing.Size(389, 186);
            this.tabAnalyzes.TabIndex = 0;
            this.tabAnalyzes.Text = "Analyzes";
            this.tabAnalyzes.UseVisualStyleBackColor = true;
            // 
            // tabXRay
            // 
            this.tabXRay.Location = new System.Drawing.Point(4, 22);
            this.tabXRay.Name = "tabXRay";
            this.tabXRay.Padding = new System.Windows.Forms.Padding(3);
            this.tabXRay.Size = new System.Drawing.Size(389, 186);
            this.tabXRay.TabIndex = 1;
            this.tabXRay.Text = "XRay";
            this.tabXRay.UseVisualStyleBackColor = true;
            // 
            // tabEco
            // 
            this.tabEco.Location = new System.Drawing.Point(4, 22);
            this.tabEco.Name = "tabEco";
            this.tabEco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEco.Size = new System.Drawing.Size(389, 186);
            this.tabEco.TabIndex = 2;
            this.tabEco.Text = "Eco";
            this.tabEco.UseVisualStyleBackColor = true;
            // 
            // tabFromDoctor
            // 
            this.tabFromDoctor.Location = new System.Drawing.Point(4, 22);
            this.tabFromDoctor.Name = "tabFromDoctor";
            this.tabFromDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFromDoctor.Size = new System.Drawing.Size(389, 186);
            this.tabFromDoctor.TabIndex = 3;
            this.tabFromDoctor.Text = "From Doctor";
            this.tabFromDoctor.UseVisualStyleBackColor = true;
            // 
            // btnTransformation
            // 
            this.btnTransformation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTransformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransformation.Location = new System.Drawing.Point(537, 447);
            this.btnTransformation.Name = "btnTransformation";
            this.btnTransformation.Size = new System.Drawing.Size(145, 39);
            this.btnTransformation.TabIndex = 25;
            this.btnTransformation.Text = "Transformation";
            this.btnTransformation.UseVisualStyleBackColor = false;
            this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
            // 
            // labDrog
            // 
            this.labDrog.AutoSize = true;
            this.labDrog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDrog.Location = new System.Drawing.Point(405, 166);
            this.labDrog.Name = "labDrog";
            this.labDrog.Size = new System.Drawing.Size(57, 25);
            this.labDrog.TabIndex = 22;
            this.labDrog.Text = "Drog";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDrog,
            this.DoseAmont,
            this.NomberDose,
            this.TimeDrog,
            this.DurationDose});
            this.dataGridView3.Location = new System.Drawing.Point(399, 194);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(426, 232);
            this.dataGridView3.TabIndex = 23;
            // 
            // tboxClinicDiagnosis
            // 
            this.tboxClinicDiagnosis.Location = new System.Drawing.Point(401, 29);
            this.tboxClinicDiagnosis.Multiline = true;
            this.tboxClinicDiagnosis.Name = "tboxClinicDiagnosis";
            this.tboxClinicDiagnosis.Size = new System.Drawing.Size(424, 120);
            this.tboxClinicDiagnosis.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(704, 447);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 39);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRecipe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipe.Location = new System.Drawing.Point(406, 447);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(111, 39);
            this.btnRecipe.TabIndex = 24;
            this.btnRecipe.Text = "Recipe";
            this.btnRecipe.UseVisualStyleBackColor = false;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // ClinicDiagnosis
            // 
            this.ClinicDiagnosis.AutoSize = true;
            this.ClinicDiagnosis.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinicDiagnosis.Location = new System.Drawing.Point(400, 1);
            this.ClinicDiagnosis.Name = "ClinicDiagnosis";
            this.ClinicDiagnosis.Size = new System.Drawing.Size(157, 25);
            this.ClinicDiagnosis.TabIndex = 20;
            this.ClinicDiagnosis.Text = "Clinic Diagnosis";
            // 
            // NameDrog
            // 
            this.NameDrog.HeaderText = "Name Drog";
            this.NameDrog.Name = "NameDrog";
            this.NameDrog.ReadOnly = true;
            // 
            // DoseAmont
            // 
            this.DoseAmont.HeaderText = "Dose Amont";
            this.DoseAmont.Name = "DoseAmont";
            this.DoseAmont.ReadOnly = true;
            // 
            // NomberDose
            // 
            this.NomberDose.HeaderText = "NomberDose";
            this.NomberDose.Name = "NomberDose";
            this.NomberDose.ReadOnly = true;
            // 
            // TimeDrog
            // 
            this.TimeDrog.HeaderText = "Time Drog";
            this.TimeDrog.Name = "TimeDrog";
            this.TimeDrog.ReadOnly = true;
            // 
            // DurationDose
            // 
            this.DurationDose.HeaderText = "Duration Dose";
            this.DurationDose.Name = "DurationDose";
            this.DurationDose.ReadOnly = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.tabPatient);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnTransformation);
            this.Controls.Add(this.labDrog);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tboxClinicDiagnosis);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.ClinicDiagnosis);
           // this.Name = "Doctor";
            this.Text = "Doctor";
            this.tabPatient.ResumeLayout(false);
            this.tabPatientWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPatientVisetes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatient;
        private System.Windows.Forms.TabPage tabPatientWait;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Name;
        private System.Windows.Forms.DataGridViewLinkColumn ReasonTheVisit;
        private System.Windows.Forms.DataGridViewLinkColumn Time;
        private System.Windows.Forms.TabPage tabPatientVisetes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewLinkColumn Drug;
        private System.Windows.Forms.DataGridViewLinkColumn Diagnosis;
        private System.Windows.Forms.DataGridViewLinkColumn Date;
        private System.Windows.Forms.TabPage tabPatientData;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabAnalyzes;
        private System.Windows.Forms.TabPage tabXRay;
        private System.Windows.Forms.TabPage tabEco;
        private System.Windows.Forms.TabPage tabFromDoctor;
        private System.Windows.Forms.Button btnTransformation;
        private System.Windows.Forms.Label labDrog;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox tboxClinicDiagnosis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Label ClinicDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDrog;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoseAmont;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomberDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDrog;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationDose;


    }
}