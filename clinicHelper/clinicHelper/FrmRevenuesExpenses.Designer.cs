namespace clinicHelper
{
    partial class FrmRevenuesExpenses
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
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnback1 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPurchases = new System.Windows.Forms.TabPage();
            this.Statement = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Expense = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Date = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRevenuesExpenses = new System.Windows.Forms.TabPage();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRevenuesExpenses.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Date";
            this.Date1.Name = "Date1";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(408, 412);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 41);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnback1
            // 
            this.btnback1.Location = new System.Drawing.Point(558, 412);
            this.btnback1.Name = "btnback1";
            this.btnback1.Size = new System.Drawing.Size(107, 41);
            this.btnback1.TabIndex = 3;
            this.btnback1.Text = "Back";
            this.btnback1.UseVisualStyleBackColor = true;
            this.btnback1.Click += new System.EventHandler(this.btnback1_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(70, 412);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(107, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Date1,
            this.Type,
            this.price,
            this.Number,
            this.TotalPrice});
            this.dataGridView2.Location = new System.Drawing.Point(5, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(713, 402);
            this.dataGridView2.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // tabPurchases
            // 
            this.tabPurchases.Controls.Add(this.btnPrint);
            this.tabPurchases.Controls.Add(this.btnback1);
            this.tabPurchases.Controls.Add(this.btndelete);
            this.tabPurchases.Controls.Add(this.btnSave);
            this.tabPurchases.Controls.Add(this.dataGridView2);
            this.tabPurchases.Location = new System.Drawing.Point(4, 22);
            this.tabPurchases.Name = "tabPurchases";
            this.tabPurchases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchases.Size = new System.Drawing.Size(714, 462);
            this.tabPurchases.TabIndex = 1;
            this.tabPurchases.Text = "Purchases";
            this.tabPurchases.UseVisualStyleBackColor = true;
            // 
            // Statement
            // 
            this.Statement.HeaderText = "Statement";
            this.Statement.Name = "Statement";
            this.Statement.ReadOnly = true;
            // 
            // Expense
            // 
            this.Expense.HeaderText = "Expense";
            this.Expense.Name = "Expense";
            this.Expense.ReadOnly = true;
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue";
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 385);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(578, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 386);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "To";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 423);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 25);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 423);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 27);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 423);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Revenue";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Revenue,
            this.Expense,
            this.Statement});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 373);
            this.dataGridView1.TabIndex = 11;
            // 
            // tabRevenuesExpenses
            // 
            this.tabRevenuesExpenses.Controls.Add(this.dateTimePicker2);
            this.tabRevenuesExpenses.Controls.Add(this.btnBack);
            this.tabRevenuesExpenses.Controls.Add(this.dateTimePicker1);
            this.tabRevenuesExpenses.Controls.Add(this.label5);
            this.tabRevenuesExpenses.Controls.Add(this.label4);
            this.tabRevenuesExpenses.Controls.Add(this.textBox3);
            this.tabRevenuesExpenses.Controls.Add(this.textBox2);
            this.tabRevenuesExpenses.Controls.Add(this.textBox1);
            this.tabRevenuesExpenses.Controls.Add(this.label3);
            this.tabRevenuesExpenses.Controls.Add(this.label2);
            this.tabRevenuesExpenses.Controls.Add(this.label1);
            this.tabRevenuesExpenses.Controls.Add(this.dataGridView1);
            this.tabRevenuesExpenses.Location = new System.Drawing.Point(4, 22);
            this.tabRevenuesExpenses.Name = "tabRevenuesExpenses";
            this.tabRevenuesExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenuesExpenses.Size = new System.Drawing.Size(714, 462);
            this.tabRevenuesExpenses.TabIndex = 0;
            this.tabRevenuesExpenses.Text = "Revenues And Expenses";
            this.tabRevenuesExpenses.UseVisualStyleBackColor = true;
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabRevenuesExpenses);
            this.tabcontrol1.Controls.Add(this.tabPurchases);
            this.tabcontrol1.Location = new System.Drawing.Point(-8, -2);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(722, 488);
            this.tabcontrol1.TabIndex = 1;
            // 
            // FrmRevenuesExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 485);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "FrmRevenuesExpenses";
            this.Text = "RevenuesExpenses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPurchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRevenuesExpenses.ResumeLayout(false);
            this.tabRevenuesExpenses.PerformLayout();
            this.tabcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnback1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.TabPage tabPurchases;
        private System.Windows.Forms.DataGridViewLinkColumn Statement;
        private System.Windows.Forms.DataGridViewLinkColumn Expense;
        private System.Windows.Forms.DataGridViewLinkColumn Revenue;
        private System.Windows.Forms.DataGridViewLinkColumn Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabRevenuesExpenses;
        private System.Windows.Forms.TabControl tabcontrol1;
    }
}