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
            ReadData();
        }

        private void ReadData()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source = books.db";

            //define the SELECT statement
            string commandText = "SELECT * FROM data";

            //create a datatable in which to save the data in the members table
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
            dgvMembers.DataSource = dataTable;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void dgvmembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                selectedID = dgvMembers.SelectedRows[0].Cells[0].Value.ToString();
                SQLiteConnection sqlConnection = new SQLiteConnection();
                sqlConnection.ConnectionString = "data source = books.db";
                //define a select statement
                string commandText = "SELECT * FROM data WHERE guid =" + selectedID;

                //create a datatabke to save data in memory
                var dataTable = new DataTable();

                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, sqlConnection);

                sqlConnection.Open();

                myDataAdapter.Fill(dataTable);

                //fills the controls on the form
                txtGuid.Text = dataTable.Rows[0]["GUID"].ToString();
                txtName.Text = dataTable.Rows[0]["Name"].ToString();
                txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
                txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                txtZip.Text = dataTable.Rows[0]["Zip"].ToString();
                txtRegion.Text = dataTable.Rows[0]["Region"].ToString();
                txtCountry.Text = dataTable.Rows[0]["Country"].ToString();

                sqlConnection.Close();
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
            sqlCommand.CommandText = "UPDATE books SET name = @Name, phone = @Phone, email = @Email, address = @Address, postalZip = @Zip, region = @Region, country = @Country WHERE guid = @GUID";

            sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
            sqlCommand.Parameters.AddWithValue("@Zip", txtZip.Text);
            sqlCommand.Parameters.AddWithValue("@Region", txtRegion.Text);
            sqlCommand.Parameters.AddWithValue("@Country", txtCountry.Text);
            sqlCommand.Parameters.AddWithValue("@GUID", selectedID);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your data is updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReadData();
        }

        private void InsertMember()
        {
            //connect to the database
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "data source = books.db";

            //create sqlite command
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;

            //create sql statement

            sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
            sqlCommand.Parameters.AddWithValue("@Zip", txtZip.Text);
            sqlCommand.Parameters.AddWithValue("@Region", txtRegion.Text);
            sqlCommand.Parameters.AddWithValue("@Country", txtCountry.Text);
            sqlCommand.Parameters.AddWithValue("@GUID", selectedID);
            sqlCommand.CommandText = "INSERT into members (guid, name, phone, email, address, postalZip, region, country) Values (@GUID, @Name, @Phone, @Email, @Address, @Zip, @Region, @Country";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your data is saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReadData();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
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
                    sqlCommand.CommandText = "DELETE FROM data WHERE guid = @GUID";
                    sqlCommand.Parameters.AddWithValue("@GUID", selectedID);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Book to be Deleted", "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    ReadData();
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                selectedID = dgvMembers.SelectedRows[0].Cells[0].Value.ToString();
                UpdateRecord();
            }
            else
            {
                InsertMember();
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (AddMember addMember = new AddMember())
            {
                if (addMember.ShowDialog() == DialogResult.OK)
                {
                    string GUID = addMember.GUID;
                    string Name = addMember.Name;
                    string Phone = addMember.Phone;
                    string Email = addMember.Email;
                    string Address = addMember.Address;
                    string Zip = addMember.Zip;
                    string Region = addMember.Region;
                    string Country = addMember.Country;

                    //connect to the database
                    SQLiteConnection sqlConnection = new SQLiteConnection();
                    sqlConnection.ConnectionString = "data source = books.db";

                    //create sqlite command
                    SQLiteCommand sqlCommand = new SQLiteCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.CommandText = "INSERT into books (guid, name, phone, email, address, postalZip, region, country) Values (@GUID, @Name, @Phone, @Email, @Address, @Zip, @Region, @Country";
                    sqlCommand.Parameters.AddWithValue("@GUID", GUID);
                    sqlCommand.Parameters.AddWithValue("@Name", Name);
                    sqlCommand.Parameters.AddWithValue("@Phone", Phone);
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlCommand.Parameters.AddWithValue("@Address", Address);
                    sqlCommand.Parameters.AddWithValue("@Zip", Zip);
                    sqlCommand.Parameters.AddWithValue("@Region", Region);
                    sqlCommand.Parameters.AddWithValue("@Country", Country);

                    
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Your data is saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReadData();
                }
            }
        }

    }
}
