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
            ReadData();
        }

        private void ReadData()
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
            if (dgvbooks.SelectedRows.Count > 0)
            {
                selectedID = dgvbooks.SelectedRows[0].Cells[0].Value.ToString();
                UpdateRecord();
            }
            else
            {
                InsertBook();
            }
        }

        private void UpdateRecord()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source = books.db";

            //define select statement
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "UPDATE books SET title = @BookTitle, author = @BookAuthor, 'pub year' = @YearOfPublication, publisher = @Publisher, stock = @Stock, price = @Price WHERE isbn = @ISBN";
            sqlCommand.Parameters.AddWithValue("@BookTitle", txtTitle.Text);
            sqlCommand.Parameters.AddWithValue("@BookAuthor", txtAuthor.Text);
            sqlCommand.Parameters.AddWithValue("@YearOfPublication", txtPubYear.Text);
            sqlCommand.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            sqlCommand.Parameters.AddWithValue("@Stock", txtStock.Text);
            sqlCommand.Parameters.AddWithValue("@Price", txtPrice.Text);
            sqlCommand.Parameters.AddWithValue("@ISBN", selectedID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your data is updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReadData();
        }

        private void InsertBook()
        {
            //connect to the database
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source = books.db";

            //create sqlite command
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;

            //create sql statement
            sqlCommand.Parameters.AddWithValue("@BookTitle", txtTitle.Text);
            sqlCommand.Parameters.AddWithValue("@BookAuthor", txtAuthor.Text);
            sqlCommand.Parameters.AddWithValue("@YearOfPublication", txtPubYear.Text);
            sqlCommand.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            sqlCommand.Parameters.AddWithValue("@Stock", txtStock.Text);
            sqlCommand.Parameters.AddWithValue("@Price", txtPrice.Text);
            sqlCommand.Parameters.AddWithValue("@ISBN", selectedID);
            sqlCommand.CommandText = "INSERT into books (isbn, title, author, 'pub year', publisher, stock, price) Values (@ISBN, @BookTitle, @BookAuthor, @YearOfPublication, @PUblisher, @Stock, @Price";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your data is saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReadData();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvbooks.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //connect to the database
                    SQLiteConnection sqlConnection = new SQLiteConnection();
                    sqlConnection.ConnectionString = "data source = books.db";

                    //create sqlite command
                    SQLiteCommand sqlCommand = new SQLiteCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "DELETE FROM books WHERE isbn = @ISBN";
                    sqlCommand.Parameters.AddWithValue("@ISBN", selectedID);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Book to be Deleted", "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    ReadData();
                }
            }
        }
    }
}
