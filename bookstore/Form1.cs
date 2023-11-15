using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class books : Form
    {
        string selectedID;
        public books()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source=books.db";

            //define the SELECT statement
            string commandText = "SELECT * FROM books";

            //create a datatable in which to save the data in the books table
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
            dgvbooks.DataSource = dataTable;
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void dgvbooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvbooks.SelectedRows.Count>0)
            {
                selectedID = dgvbooks.SelectedRows[0].Cells[0].Value.ToString();
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
                txtIsbn.Text = dataTable.Rows[0]["ISBN"].ToString();
                txtTitle.Text = dataTable.Rows[0]["Title"].ToString();
                txtAuthor.Text = dataTable.Rows[0]["Author"].ToString();
                txtPubYear.Text = dataTable.Rows[0]["Pub Year"].ToString();
                txtPublisher.Text = dataTable.Rows[0]["Publisher"].ToString();
                txtGenre.Text = dataTable.Rows[0]["Genre"].ToString();
                txtCoverType.Text = dataTable.Rows[0]["Cover Type"].ToString();
                txtFiction.Text = dataTable.Rows[0]["Fiction"].ToString();
                txtPages.Text = dataTable.Rows[0]["Pages"].ToString();
                txtPrice.Text = dataTable.Rows[0]["Price"].ToString();

                sqlConnection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //create a connection to the sql database
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source = books.db";

            //create an sql command
            SQLiteCommand sqlCommand = new SqlCommand();

            //set connection to
            sqlCommand Connection = sqlConnection;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}
