namespace Access
{
    partial class DineinTakeout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DineinTakeout));
            this.pictureBoxTakeOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxDineIn = new System.Windows.Forms.PictureBox();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDineIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTakeOut
            // 
            this.pictureBoxTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTakeOut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTakeOut.Image")));
            this.pictureBoxTakeOut.Location = new System.Drawing.Point(259, 216);
            this.pictureBoxTakeOut.Name = "pictureBoxTakeOut";
            this.pictureBoxTakeOut.Size = new System.Drawing.Size(148, 246);
            this.pictureBoxTakeOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTakeOut.TabIndex = 2;
            this.pictureBoxTakeOut.TabStop = false;
            this.pictureBoxTakeOut.Click += new System.EventHandler(this.pictureBoxTakeOut_Click);
            // 
            // pictureBoxDineIn
            // 
            this.pictureBoxDineIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDineIn.Image")));
            this.pictureBoxDineIn.Location = new System.Drawing.Point(62, 216);
            this.pictureBoxDineIn.Name = "pictureBoxDineIn";
            this.pictureBoxDineIn.Size = new System.Drawing.Size(153, 243);
            this.pictureBoxDineIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDineIn.TabIndex = 3;
            this.pictureBoxDineIn.TabStop = false;
            this.pictureBoxDineIn.Click += new System.EventHandler(this.pictureBoxDineIn_Click);
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.Transparent;
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goback.ForeColor = System.Drawing.Color.Red;
            this.goback.Location = new System.Drawing.Point(-2, 2);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(42, 29);
            this.goback.TabIndex = 4;
            this.goback.Text = "<<";
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.exit_Click);
            // 
            // DineinTakeout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 584);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.pictureBoxDineIn);
            this.Controls.Add(this.pictureBoxTakeOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DineinTakeout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DineinTakeout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDineIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBoxTakeOut;
        private PictureBox pictureBoxDineIn;
        private Button goback;
    }
}