using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace bookstore
{
    public partial class AddMember : Form
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public AddMember()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            GUID = txtGuid.Text;
            Name = txtName.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;
            Address = txtAddress.Text;
            Zip = txtZip.Text;
            Region = txtRegion.Text;
            Country = txtCountry.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
