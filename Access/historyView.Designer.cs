namespace Access
{
    partial class historyView
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.iconButtonHistory = new FontAwesome.Sharp.IconButton();
            this.iconButtonProducts = new FontAwesome.Sharp.IconButton();
            this.labelAngel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonEmployees = new FontAwesome.Sharp.IconButton();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAdmin.SuspendLayout();
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
            this.buttonExit.Location = new System.Drawing.Point(1297, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 35);
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(97, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "*admin";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdmin.ForeColor = System.Drawing.Color.Black;
            this.labelAdmin.Location = new System.Drawing.Point(433, 21);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(566, 50);
            this.labelAdmin.TabIndex = 41;
            this.labelAdmin.Text = "O W N E R   M A N A G E M E N T";
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.FlatAppearance.BorderSize = 0;
            this.iconButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogout.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonLogout.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogout.Location = new System.Drawing.Point(1, 572);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Size = new System.Drawing.Size(279, 76);
            this.iconButtonLogout.TabIndex = 40;
            this.iconButtonLogout.Text = "Log out";
            this.iconButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogout.UseVisualStyleBackColor = true;
            this.iconButtonLogout.Click += new System.EventHandler(this.iconButtonLogout_Click);
            // 
            // iconButtonHistory
            // 
            this.iconButtonHistory.BackColor = System.Drawing.Color.SaddleBrown;
            this.iconButtonHistory.FlatAppearance.BorderSize = 0;
            this.iconButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHistory.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonHistory.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconButtonHistory.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButtonHistory.IconColor = System.Drawing.Color.DarkOrange;
            this.iconButtonHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHistory.Location = new System.Drawing.Point(0, 496);
            this.iconButtonHistory.Name = "iconButtonHistory";
            this.iconButtonHistory.Size = new System.Drawing.Size(280, 76);
            this.iconButtonHistory.TabIndex = 39;
            this.iconButtonHistory.Text = "History";
            this.iconButtonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHistory.UseVisualStyleBackColor = false;
            this.iconButtonHistory.Click += new System.EventHandler(this.iconButtonHistory_Click);
            // 
            // iconButtonProducts
            // 
            this.iconButtonProducts.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButtonProducts.FlatAppearance.BorderSize = 0;
            this.iconButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProducts.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonProducts.ForeColor = System.Drawing.Color.Black;
            this.iconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonProducts.IconColor = System.Drawing.Color.Black;
            this.iconButtonProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProducts.Location = new System.Drawing.Point(-2, 417);
            this.iconButtonProducts.Name = "iconButtonProducts";
            this.iconButtonProducts.Size = new System.Drawing.Size(282, 76);
            this.iconButtonProducts.TabIndex = 38;
            this.iconButtonProducts.Text = "Products";
            this.iconButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProducts.UseVisualStyleBackColor = false;
            this.iconButtonProducts.Click += new System.EventHandler(this.iconButtonProducts_Click);
            // 
            // labelAngel
            // 
            this.labelAngel.AutoSize = true;
            this.labelAngel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAngel.Location = new System.Drawing.Point(58, 241);
            this.labelAngel.Name = "labelAngel";
            this.labelAngel.Size = new System.Drawing.Size(174, 25);
            this.labelAngel.TabIndex = 37;
            this.labelAngel.Text = "Angel Rose Comajes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonEmployees
            // 
            this.iconButtonEmployees.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonEmployees.FlatAppearance.BorderSize = 0;
            this.iconButtonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEmployees.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButtonEmployees.ForeColor = System.Drawing.Color.Black;
            this.iconButtonEmployees.IconChar = FontAwesome.Sharp.IconChar.PersonDress;
            this.iconButtonEmployees.IconColor = System.Drawing.Color.Black;
            this.iconButtonEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEmployees.Location = new System.Drawing.Point(0, 341);
            this.iconButtonEmployees.Name = "iconButtonEmployees";
            this.iconButtonEmployees.Size = new System.Drawing.Size(280, 76);
            this.iconButtonEmployees.TabIndex = 35;
            this.iconButtonEmployees.Text = "Employee";
            this.iconButtonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEmployees.UseVisualStyleBackColor = false;
            this.iconButtonEmployees.Click += new System.EventHandler(this.iconButtonEmployees_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panelAdmin.Controls.Add(this.label2);
            this.panelAdmin.Controls.Add(this.buttonLoad);
            this.panelAdmin.Controls.Add(this.dataGridView1);
            this.panelAdmin.Location = new System.Drawing.Point(280, 90);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1071, 591);
            this.panelAdmin.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(114, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "H                    I                    S                    T                 " +
    "   O                    R                     Y";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Location = new System.Drawing.Point(952, 69);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(78, 29);
            this.buttonLoad.TabIndex = 36;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.dataGridView1.Location = new System.Drawing.Point(38, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(992, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // historyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1351, 681);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.iconButtonLogout);
            this.Controls.Add(this.iconButtonHistory);
            this.Controls.Add(this.iconButtonProducts);
            this.Controls.Add(this.labelAngel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconButtonEmployees);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "historyView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Label label1;
        private Label labelAdmin;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private FontAwesome.Sharp.IconButton iconButtonHistory;
        private FontAwesome.Sharp.IconButton iconButtonProducts;
        private Label labelAngel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonEmployees;
        private Panel panelAdmin;
        private Button buttonLoad;
        private DataGridView dataGridView1;
        private Label label2;
    }
}