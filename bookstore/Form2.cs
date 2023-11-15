using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Members : Form
    {
        string selectedID;
        public Members()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source=books.db";

            //define the SELECT statement
            string commandText = "SELECT * FROM data";

            //create a datatabke in which to save the data in the books table
            var dataTable = new DataTable();

            //create a data adapter to perform our CRUD operations
            SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(commandText, sqlConnection);

            //opens the connection to the database
            sqlConnection.Open();

            //fill data from database into the datatable
            myAdapter.Fill(dataTable);

            //close connection to the database
            sqlConnection.Close();

            //place data from datatable and place into datagrid view on form
            dgvmembers.DataSource = dataTable;
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void dgvmembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmembers.SelectedRows.Count > 0)
            {
                selectedID = dgvmembers.SelectedRows[0].Cells[0].Value.ToString();
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "data source = books.db";
                //define a select statement
                string commandText = "SELECT * FROM Books WHERE ISBN =" + selectedID;

                //create a datatabke to save data in memory
                var dataTable = new DataTable();

                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlConnection);

                sqlConnection.Open();

                myDataAdapter.Fill(dataTable);

                //fills the controls on the form
                txtGuid.Text = dataTable.Rows[0]["ISBN"].ToString();
                txtName.Text = dataTable.Rows[0]["Title"].ToString();
                txtPhone.Text = dataTable.Rows[0]["Author"].ToString();
                txtEmail.Text = dataTable.Rows[0]["Pub Year"].ToString();
                txtAddress.Text = dataTable.Rows[0]["Publisher"].ToString();
                txtZip.Text = dataTable.Rows[0]["Genre"].ToString();
                txtRegion.Text = dataTable.Rows[0]["Cover Type"].ToString();
                txtCountry.Text = dataTable.Rows[0]["Fiction"].ToString();

                sqlConnection.Close();
            }
        }
    }
}
