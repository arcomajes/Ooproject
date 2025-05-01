using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonClearEntries_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text;
            string password = this.textBoxPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (username == "admin" && password == "admin")
            {
                Admin admin = new Admin();
                admin.ShowDialog();
                //await Task.Delay(1000);
                this.Hide();
            }
            else
            {
                MessageBox.Show("\tAdmin Credentials Wrong\t");

            }
        }
    }
}
