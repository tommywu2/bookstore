using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class AddBook : Form
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PubYear { get; set; }
        public string Genre { get; set; }
        public string CoverType { get; set; }
        public string Publisher { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Pages { get; set; }
        public string Fiction { get; set; }

        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            ISBN = txtIsbn.Text;
            Title = txtTitle.Text;
            Author = txtAuthor.Text;
            PubYear = txtPubYear.Text;
            Genre = txtGenre.Text;
            CoverType = txtCoverType.Text;
            Publisher = txtPublisher.Text;
            Stock = txtStock.Text;
            Price = txtPrice.Text;
            Pages = txtPages.Text;
            Fiction = txtFiction.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
