namespace Access
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonPrevious = new FontAwesome.Sharp.IconButton();
            this.buttonClearEntries = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.iconButtonPrevious);
            this.panel2.Controls.Add(this.buttonClearEntries);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.Admin);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Location = new System.Drawing.Point(506, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 550);
            this.panel2.TabIndex = 1;
            // 
            // iconButtonPrevious
            // 
            this.iconButtonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonPrevious.FlatAppearance.BorderSize = 0;
            this.iconButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPrevious.ForeColor = System.Drawing.Color.Maroon;
            this.iconButtonPrevious.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            this.iconButtonPrevious.IconColor = System.Drawing.Color.Maroon;
            this.iconButtonPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPrevious.IconSize = 25;
            this.iconButtonPrevious.Location = new System.Drawing.Point(2, 3);
            this.iconButtonPrevious.Name = "iconButtonPrevious";
            this.iconButtonPrevious.Size = new System.Drawing.Size(36, 29);
            this.iconButtonPrevious.TabIndex = 21;
            this.iconButtonPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPrevious.UseVisualStyleBackColor = false;
            this.iconButtonPrevious.Click += new System.EventHandler(this.iconButtonPrevious_Click);
            // 
            // buttonClearEntries
            // 
            this.buttonClearEntries.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClearEntries.FlatAppearance.BorderSize = 0;
            this.buttonClearEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntries.Location = new System.Drawing.Point(305, 277);
            this.buttonClearEntries.Name = "buttonClearEntries";
            this.buttonClearEntries.Size = new System.Drawing.Size(122, 29);
            this.buttonClearEntries.TabIndex = 20;
            this.buttonClearEntries.Text = "Clear Entries";
            this.buttonClearEntries.UseVisualStyleBackColor = false;
            this.buttonClearEntries.Click += new System.EventHandler(this.buttonClearEntries_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(161, 239);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(250, 32);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(161, 161);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(250, 33);
            this.textBoxUsername.TabIndex = 18;
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLogin.Location = new System.Drawing.Point(192, 343);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 45);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(71, 244);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 23);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(71, 165);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 23);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(179, 44);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(164, 45);
            this.Admin.TabIndex = 14;
            this.Admin.Text = "A D M I N";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(448, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonExit;
        private Button buttonClearEntries;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private Label labelPassword;
        private Label labelUsername;
        private Label Admin;
        private FontAwesome.Sharp.IconButton iconButtonPrevious;
    }
}