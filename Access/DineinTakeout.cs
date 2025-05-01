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
    public partial class DineinTakeout : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public DineinTakeout()
        {
            InitializeComponent();
        }

        private void takeout_btn_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO DiningOption (Takeout) VALUES ('Take-out')";

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
                        ModeOfPayment modeOfPayment = new ModeOfPayment();
                        modeOfPayment.Show();
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

        private void dinein_btn_Click(object sender, EventArgs e)
        {

            
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO DiningOption (DineIn) VALUES ('Dine-In')";

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
                        ModeOfPayment modeOfPayment = new ModeOfPayment();
                        modeOfPayment.Show();
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

        private void pictureBoxTakeOut_Click(object sender, EventArgs e)
        {
            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO DiningOption (Takeout) VALUES ('Take-out')";

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
                        ModeOfPayment modeOfPayment = new ModeOfPayment();
                        modeOfPayment.Show();
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

        private void pictureBoxDineIn_Click(object sender, EventArgs e)
        {


            // Connection string for MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";

            // SQL query to insert the data
            string query = "INSERT INTO DiningOption (DineIn) VALUES ('Dine-In')";

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
                        ModeOfPayment modeOfPayment = new ModeOfPayment();
                        modeOfPayment.Show();
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

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.ShowDialog();
            
        }
    }
}
