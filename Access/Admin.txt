using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Access
{
    public partial class Admin : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Admin()
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, [First Name], [Middle Name], [Last Name], [Contact No] FROM Employees", connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID"].Width = 125;
            dataGridView1.Columns["First Name"].Width = 170;
            dataGridView1.Columns["Middle Name"].Width = 160;
            dataGridView1.Columns["Last Name"].Width = 160;
            dataGridView1.Columns["Contact No"].Width = 160;
        }

        private void ConnectionTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBoxFirstName.Text = row.Cells[0].Value.ToString();
            textBoxMiddleName.Text = row.Cells[1].Value.ToString();
            textBoxLastName.Text = row.Cells[2].Value.ToString();
            textBoxContactNo.Text = row.Cells[4].Value.ToString();
        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb");
            string query = "INSERT INTO Employees ([First Name], [Middle Name], [Last Name], [Contact No]) VALUES (@fn, @mn, @ln, @cn)";

            cmd = new OleDbCommand(query, myConn);
            {
                cmd.Parameters.AddWithValue("@fn", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@mn", textBoxMiddleName.Text);
                cmd.Parameters.AddWithValue("@ln", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@cn", textBoxContactNo.Text);
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            MessageBox.Show("New Employee added successfully!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to remove an employee?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    string query = "DELETE FROM Employees WHERE ID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@id", id);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("Employee removed successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to remove.");
            }
        }

        private void iconButtonProducts_Click(object sender, EventArgs e)
        {
            ProductsAdmin products = new ProductsAdmin();
            products.Show();
            this.Close();
        }

        private void buttonClearEntries_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBoxID.Text = row.Cells[0].Value.ToString();
            textBoxFirstName.Text = row.Cells[1].Value.ToString();
            textBoxMiddleName.Text = row.Cells[2].Value.ToString();
            textBoxLastName.Text = row.Cells[3].Value.ToString();
            textBoxContactNo.Text = row.Cells[4].Value.ToString();
        }

        private void iconButtonEmployees_Click(object sender, EventArgs e)
        {
            Admin ADmin = new Admin();
            ADmin.Show();
            this.Close();
        }

        private void iconButtonHistory_Click(object sender, EventArgs e)
        {
            historyView history = new historyView();
            history.Show();
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

        private void Refresh3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb";
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID, [First Name], [Middle Name], [Last Name], [Contact No] FROM Employees", connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID"].Width = 125;
            dataGridView1.Columns["First Name"].Width = 170;
            dataGridView1.Columns["Middle Name"].Width = 160;
            dataGridView1.Columns["Last Name"].Width = 160;
            dataGridView1.Columns["Contact No"].Width = 160;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            
            /*OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb");

            if (myConn.State != ConnectionState.Open)
            {
                myConn.Open();
            }
            //string query = "Update Student Set LastName = @Lname Where StudentID = @id";
            string query = "UPDATE Employees Set [First Name] = @fn, [Middle Name] = @mn, [Last Name] = @ln, [Contact No] = @cn WHERE ID = @id";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxID.Text));
            cmd.Parameters.AddWithValue("@fn", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@mn", textBoxMiddleName.Text);
            cmd.Parameters.AddWithValue("@ln", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@cn", textBoxContactNo.Text);

            cmd.ExecuteNonQuery();

            myConn.Close();
            MessageBox.Show("Employee information updated successfully.");*/



            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Angel Rose Comajes\\Documents\\Access.accdb");

            if (indexRow >= 0) // check if a row is selected
            {
                // retrieve the ID of the employee from the selected row
                //textBoxID.Text = Convert.ToString(dataGridView1.Rows[indexRow].Cells[3].Value);

                // update query to modify the existing employee's data
                string query = "UPDATE Employees SET [First Name]=@fn, [Middle Name]=@mn, [Last Name]=@ln, [Contact No]=@cn WHERE ID=@id";

            cmd = new OleDbCommand(query, myConn);
                {
                    cmd.Parameters.AddWithValue("@fn", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@mn", textBoxMiddleName.Text);
                    cmd.Parameters.AddWithValue("@ln", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@cn", textBoxContactNo.Text);
                    cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    try
                    {
                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();
                        MessageBox.Show("Employee information updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating employee: " + ex.Message);
                    }
                }
            }
            else{
                MessageBox.Show("Please select an employee to update.");
            }
        }

        private void iconButtonCashier_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.ShowDialog();
            this.Hide();
        }
    }
}
