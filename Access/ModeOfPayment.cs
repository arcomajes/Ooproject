using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access
{
    public partial class ModeOfPayment : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public ModeOfPayment()
        {
            InitializeComponent();
        }

        private void gcash_btn_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO ModeOfPayment (Gcash) VALUES ('G-Cash')";

            // Create a new OleDbConnection object
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a new OleDbCommand object with the SQL query and connection
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Execute the SQL query
                        command.ExecuteNonQuery();

                        // Display a success message or perform any additional tasks
                        //MessageBox.Show("Dine-In option saved successfully!");
                        Costumer costumer = new Costumer();
                        costumer.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO ModeOfPayment (Cash) VALUES ('Cash')";

            // Create a new OleDbConnection object
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a new OleDbCommand object with the SQL query and connection
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Execute the SQL query
                        command.ExecuteNonQuery();

                        // Display a success message or perform any additional tasks
                        //MessageBox.Show("Dine-In option saved successfully!");
                        Costumer costumer = new Costumer();
                        costumer.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void pictureBoxCash_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO ModeOfPayment (Cash) VALUES ('Cash')";

            // Create a new OleDbConnection object
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a new OleDbCommand object with the SQL query and connection
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Execute the SQL query
                        command.ExecuteNonQuery();

                        // Display a success message or perform any additional tasks
                        //MessageBox.Show("Dine-In option saved successfully!");
                        Costumer costumer = new Costumer();
                        costumer.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void pictureBoxGcash_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO ModeOfPayment (Gcash) VALUES ('G-Cash')";

            // Create a new OleDbConnection object
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a new OleDbCommand object with the SQL query and connection
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Execute the SQL query
                        command.ExecuteNonQuery();

                        // Display a success message or perform any additional tasks
                        //MessageBox.Show("Dine-In option saved successfully!");
                        Costumer costumer = new Costumer();
                        costumer.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            DineinTakeout dineintakeout = new DineinTakeout();
            this.Close();
            dineintakeout.ShowDialog();
           
        }
    }
}
