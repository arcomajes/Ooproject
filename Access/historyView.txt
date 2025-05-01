using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Access
{
    public partial class historyView : Form
    {
        public historyView()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save and Logout?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
            }
        }

        private void iconButtonEmployees_Click(object sender, EventArgs e)
        {
            Admin ADmin = new Admin();
            ADmin.Show();
            this.Close();
        }

        private void iconButtonProducts_Click(object sender, EventArgs e)
        {
            ProductsAdmin products = new ProductsAdmin();
            products.Show();
            this.Close();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Angel Rose Comajes\Documents\Access.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT ID, Product, Price, Quantity, Subtotal, [Date/Time] FROM History", connection);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["ID"].Width = 190;
                    dataGridView1.Columns["Product"].Width = 190;
                    dataGridView1.Columns["Price"].Width = 190;
                    dataGridView1.Columns["Quantity"].Width = 100;
                    dataGridView1.Columns["Subtotal"].Width = 190;
                    dataGridView1.Columns["Date/Time"].Width = 230;
                    dataGridView1.Columns["Date/Time"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";
                    //dataGridView1.Columns["Status"].Width = 160;
                }
            }
        }

        private void Refresh3_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Refresh();
            try
            {
                // Get the current date and time
                DateTime now = DateTime.Now;

                // Add a new row to the DataGridView
                dataGridView1.Rows.Add(now.ToString(), textBoxSearch.Text);
                // Clear any existing data in the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                // Connect to the database and execute the query
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb"))
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT OrderID, OrderDate, Product, Quantity, TotalPrice, EmployeeName FROM OrderHistory WHERE Product LIKE '%" + textBoxSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No results found.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for history: " + ex.Message);
            }*/
        }

            /*private void buttonhistory_Click(object sender, EventArgs e)
            {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, Product, Price, Quantity, Subtotal FROM History", connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID"].Width = 190;
            dataGridView1.Columns["Product"].Width = 190;
            dataGridView1.Columns["Price"].Width = 190;
            dataGridView1.Columns["Quantity"].Width = 190;
            dataGridView1.Columns["Subtotal"].Width = 190;

            }*/
    }
}
