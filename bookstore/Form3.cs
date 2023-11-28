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
    public partial class Form3 : Form
    {
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string YearOfPublication { get; set; }
        public string BookGenre { get; set; }
        public string BookCoverType { get; set; }
        public string Publisher { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Pages { get; set; }
        public string Fiction { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ISBN = txtIsbn.Text;
            BookTitle = txtTitle.Text;
            BookAuthor = txtAuthor.Text;
            YearOfPublication = txtPubYear.Text;
            BookGenre = txtGenre.Text;
            BookCoverType = txtCoverType.Text;
            Publisher = txtPublisher.Text;
            Stock = txtStock.Text;
            Price = txtPrice.Text;
            Pages = txtPages.Text;
            Fiction = txtFiction.Text;
        }
    }
}
