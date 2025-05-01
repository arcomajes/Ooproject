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
    public partial class Cashier : Form

    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        public Cashier()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDailySales_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Angel Rose Comajes\Documents\Access.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT SUM(Subtotal) AS Amount FROM History WHERE [Date/Time] >= Date()", connection);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void buttonMonthySales_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Angel Rose Comajes\Documents\Access.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT SUM(Subtotal) AS Amount FROM History WHERE [Date/Time] >= DateAdd('m', -1, Date())", connection);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void buttonYearlySales_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Angel Rose Comajes\Documents\Access.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT SUM(Subtotal) AS Amount FROM History WHERE [Date/Time] >= DateAdd('yyyy', -1, Date())", connection);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void buttonCheckSales_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Angel Rose Comajes\Documents\Access.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("SELECT SUM(Subtotal) AS Amount FROM History WHERE [Date/Time] >= @FromDate AND [Date/Time] <= @ToDate", connection);
                command.Parameters.AddWithValue("@FromDate", fromDate);
                command.Parameters.AddWithValue("@ToDate", toDate);
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && result != DBNull.Value)
                {
                    decimal amount = Convert.ToDecimal(result);
                    textBoxAmount.Text = amount.ToString();
                }
                else
                {
                    textBoxAmount.Text = "0";
                }
            }
        }

    }
}
