namespace Access
{
    partial class ModeOfPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeOfPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.goback = new System.Windows.Forms.Button();
            this.pictureBoxGcash = new System.Windows.Forms.PictureBox();
            this.pictureBoxCash = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGcash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.goback);
            this.panel1.Controls.Add(this.pictureBoxGcash);
            this.panel1.Controls.Add(this.pictureBoxCash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 584);
            this.panel1.TabIndex = 3;
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.Transparent;
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goback.ForeColor = System.Drawing.Color.Red;
            this.goback.Location = new System.Drawing.Point(3, 3);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(42, 29);
            this.goback.TabIndex = 5;
            this.goback.Text = "<<";
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // pictureBoxGcash
            // 
            this.pictureBoxGcash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGcash.Image")));
            this.pictureBoxGcash.Location = new System.Drawing.Point(300, 232);
            this.pictureBoxGcash.Name = "pictureBoxGcash";
            this.pictureBoxGcash.Size = new System.Drawing.Size(153, 204);
            this.pictureBoxGcash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGcash.TabIndex = 4;
            this.pictureBoxGcash.TabStop = false;
            this.pictureBoxGcash.Click += new System.EventHandler(this.pictureBoxGcash_Click);
            // 
            // pictureBoxCash
            // 
            this.pictureBoxCash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCash.Image")));
            this.pictureBoxCash.Location = new System.Drawing.Point(80, 232);
            this.pictureBoxCash.Name = "pictureBoxCash";
            this.pictureBoxCash.Size = new System.Drawing.Size(153, 204);
            this.pictureBoxCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCash.TabIndex = 3;
            this.pictureBoxCash.TabStop = false;
            this.pictureBoxCash.Click += new System.EventHandler(this.pictureBoxCash_Click);
            // 
            // ModeOfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModeOfPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeOfPayment";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGcash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBoxGcash;
        private PictureBox pictureBoxCash;
        private Button goback;
    }
}