namespace Access
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new System.Windows.Forms.Button();
            this.iconButtonlogin = new FontAwesome.Sharp.IconButton();
            this.buttonordernow = new System.Windows.Forms.Button();
            this.Facebook = new FontAwesome.Sharp.IconButton();
            this.Instagram = new FontAwesome.Sharp.IconButton();
            this.Email = new FontAwesome.Sharp.IconButton();
            this.linkLabelInstagram = new System.Windows.Forms.LinkLabel();
            this.linkLabelFacebook = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(493, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 29);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // iconButtonlogin
            // 
            this.iconButtonlogin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonlogin.FlatAppearance.BorderSize = 0;
            this.iconButtonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonlogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonlogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonlogin.IconColor = System.Drawing.Color.White;
            this.iconButtonlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonlogin.IconSize = 25;
            this.iconButtonlogin.Location = new System.Drawing.Point(498, 37);
            this.iconButtonlogin.Name = "iconButtonlogin";
            this.iconButtonlogin.Size = new System.Drawing.Size(36, 29);
            this.iconButtonlogin.TabIndex = 1;
            this.iconButtonlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonlogin.UseVisualStyleBackColor = false;
            this.iconButtonlogin.Click += new System.EventHandler(this.iconButtonlogin_Click);
            // 
            // buttonordernow
            // 
            this.buttonordernow.BackColor = System.Drawing.Color.Transparent;
            this.buttonordernow.FlatAppearance.BorderSize = 0;
            this.buttonordernow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonordernow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonordernow.ForeColor = System.Drawing.Color.Black;
            this.buttonordernow.Location = new System.Drawing.Point(212, 209);
            this.buttonordernow.Name = "buttonordernow";
            this.buttonordernow.Size = new System.Drawing.Size(157, 47);
            this.buttonordernow.TabIndex = 2;
            this.buttonordernow.Text = "Order Now!";
            this.buttonordernow.UseVisualStyleBackColor = false;
            this.buttonordernow.Click += new System.EventHandler(this.buttonordernow_Click);
            // 
            // Facebook
            // 
            this.Facebook.BackColor = System.Drawing.Color.Transparent;
            this.Facebook.FlatAppearance.BorderSize = 0;
            this.Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facebook.ForeColor = System.Drawing.Color.Maroon;
            this.Facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.Facebook.IconColor = System.Drawing.SystemColors.HotTrack;
            this.Facebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Facebook.IconSize = 25;
            this.Facebook.Location = new System.Drawing.Point(0, 543);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(25, 25);
            this.Facebook.TabIndex = 22;
            this.Facebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Facebook.UseVisualStyleBackColor = false;
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // Instagram
            // 
            this.Instagram.BackColor = System.Drawing.Color.Transparent;
            this.Instagram.FlatAppearance.BorderSize = 0;
            this.Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Instagram.ForeColor = System.Drawing.Color.Maroon;
            this.Instagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.Instagram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Instagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Instagram.IconSize = 25;
            this.Instagram.Location = new System.Drawing.Point(-4, 519);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(36, 30);
            this.Instagram.TabIndex = 23;
            this.Instagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Instagram.UseVisualStyleBackColor = false;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.FlatAppearance.BorderSize = 0;
            this.Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email.ForeColor = System.Drawing.Color.Maroon;
            this.Email.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.Email.IconColor = System.Drawing.Color.White;
            this.Email.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Email.IconSize = 25;
            this.Email.Location = new System.Drawing.Point(-4, 560);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 29);
            this.Email.TabIndex = 24;
            this.Email.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Email.UseVisualStyleBackColor = false;
            // 
            // linkLabelInstagram
            // 
            this.linkLabelInstagram.AutoSize = true;
            this.linkLabelInstagram.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelInstagram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelInstagram.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelInstagram.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabelInstagram.Location = new System.Drawing.Point(23, 522);
            this.linkLabelInstagram.Name = "linkLabelInstagram";
            this.linkLabelInstagram.Size = new System.Drawing.Size(28, 20);
            this.linkLabelInstagram.TabIndex = 26;
            this.linkLabelInstagram.TabStop = true;
            this.linkLabelInstagram.Text = "igs";
            this.linkLabelInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInstagram_LinkClicked);
            // 
            // linkLabelFacebook
            // 
            this.linkLabelFacebook.AutoSize = true;
            this.linkLabelFacebook.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelFacebook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelFacebook.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelFacebook.Location = new System.Drawing.Point(22, 543);
            this.linkLabelFacebook.Name = "linkLabelFacebook";
            this.linkLabelFacebook.Size = new System.Drawing.Size(23, 20);
            this.linkLabelFacebook.TabIndex = 26;
            this.linkLabelFacebook.TabStop = true;
            this.linkLabelFacebook.Text = "fb";
            this.linkLabelFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFacebook_LinkClicked);
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelEmail.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelEmail.Location = new System.Drawing.Point(23, 562);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(46, 20);
            this.linkLabelEmail.TabIndex = 27;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Contact us:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.linkLabelInstagram);
            this.Controls.Add(this.linkLabelFacebook);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.buttonordernow);
            this.Controls.Add(this.iconButtonlogin);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit;
        private FontAwesome.Sharp.IconButton iconButtonlogin;
        private Button buttonordernow;
        private FontAwesome.Sharp.IconButton Facebook;
        private FontAwesome.Sharp.IconButton Instagram;
        private FontAwesome.Sharp.IconButton Email;
        private LinkLabel linkLabelInstagram;
        private LinkLabel linkLabelFacebook;
        private LinkLabel linkLabelEmail;
        private Label label1;
    }
}