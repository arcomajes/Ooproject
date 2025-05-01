namespace Access
{
    partial class Cashier
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDailySales = new System.Windows.Forms.Button();
            this.buttonMonthySales = new System.Windows.Forms.Button();
            this.buttonYearlySales = new System.Windows.Forms.Button();
            this.buttonCheckSales = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(477, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(167, 126);
            this.dataGridView1.TabIndex = 36;
            // 
            // buttonDailySales
            // 
            this.buttonDailySales.Location = new System.Drawing.Point(117, 47);
            this.buttonDailySales.Name = "buttonDailySales";
            this.buttonDailySales.Size = new System.Drawing.Size(116, 38);
            this.buttonDailySales.TabIndex = 37;
            this.buttonDailySales.Text = "Daily Sales";
            this.buttonDailySales.UseVisualStyleBackColor = true;
            this.buttonDailySales.Click += new System.EventHandler(this.buttonDailySales_Click);
            // 
            // buttonMonthySales
            // 
            this.buttonMonthySales.Location = new System.Drawing.Point(117, 91);
            this.buttonMonthySales.Name = "buttonMonthySales";
            this.buttonMonthySales.Size = new System.Drawing.Size(116, 38);
            this.buttonMonthySales.TabIndex = 38;
            this.buttonMonthySales.Text = "Monthly Sales";
            this.buttonMonthySales.UseVisualStyleBackColor = true;
            this.buttonMonthySales.Click += new System.EventHandler(this.buttonMonthySales_Click);
            // 
            // buttonYearlySales
            // 
            this.buttonYearlySales.Location = new System.Drawing.Point(117, 135);
            this.buttonYearlySales.Name = "buttonYearlySales";
            this.buttonYearlySales.Size = new System.Drawing.Size(116, 38);
            this.buttonYearlySales.TabIndex = 39;
            this.buttonYearlySales.Text = "Yearly Sales";
            this.buttonYearlySales.UseVisualStyleBackColor = true;
            this.buttonYearlySales.Click += new System.EventHandler(this.buttonYearlySales_Click_1);
            // 
            // buttonCheckSales
            // 
            this.buttonCheckSales.Location = new System.Drawing.Point(74, 296);
            this.buttonCheckSales.Name = "buttonCheckSales";
            this.buttonCheckSales.Size = new System.Drawing.Size(141, 52);
            this.buttonCheckSales.TabIndex = 40;
            this.buttonCheckSales.Text = "Check Sales";
            this.buttonCheckSales.UseVisualStyleBackColor = true;
            this.buttonCheckSales.Click += new System.EventHandler(this.buttonCheckSales_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Checked = false;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(74, 223);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(131, 27);
            this.dateTimePickerFrom.TabIndex = 41;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Checked = false;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(248, 223);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(130, 27);
            this.dateTimePickerTo.TabIndex = 42;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(247, 309);
            this.textBoxAmount.Multiline = true;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(215, 34);
            this.textBoxAmount.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(248, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(74, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(248, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "To:";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(546, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonCheckSales);
            this.Controls.Add(this.buttonYearlySales);
            this.Controls.Add(this.buttonMonthySales);
            this.Controls.Add(this.buttonDailySales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private DataGridView dataGridView1;
        private Button buttonDailySales;
        private Button buttonMonthySales;
        private Button buttonYearlySales;
        private Button buttonCheckSales;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private TextBox textBoxAmount;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}